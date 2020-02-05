namespace Get_Attachment.Controllers
{
    using System;
    using System.Text;
    using Google.Apis.Gmail.v1;
    using Google.Apis.Services;
    using Get_Attachment.Models;
    using System.Threading.Tasks;
    using System.Security.Claims;
    using Google.Apis.Auth.OAuth2;
    using Microsoft.AspNetCore.Mvc;
    using Google.Apis.Gmail.v1.Data;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Authentication;

    public class GoogleController : Controller
    {
        string accessToken;

        async void GetToken() => accessToken = await HttpContext.GetTokenAsync("access_token");

        GmailService GetService()
        {
            GetToken();
            var credential = GoogleCredential.FromAccessToken(accessToken);
            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential
            });

            return service;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAttachments(string LabelId, string nameLabel)
        {
            string UserEmail = User.FindFirst(c => c.Type == ClaimTypes.Email).Value;
            var service = GetService();
            List<My_Message> listMessages = new List<My_Message>();
            List<Message> result = new List<Message>();

            My_Message messages = new My_Message();

            // Define parameters of request.
            var emailListRequest = service.Users.Messages.List(UserEmail);
            emailListRequest.IncludeSpamTrash = false;
            emailListRequest.LabelIds = LabelId;
            emailListRequest.MaxResults = 1000;
            emailListRequest.Q = "has:attachment";

            // List messages.
            ListMessagesResponse emailListResponse = await emailListRequest.ExecuteAsync();

            if (emailListResponse != null && emailListResponse.Messages != null)
            {
                foreach (var email in emailListResponse.Messages)
                {                   
                    var emailInfoRequest = service.Users.Messages.Get(UserEmail, email.Id);
                    var emailInfoResponse = await emailInfoRequest.ExecuteAsync();
                    if (emailInfoResponse != null)
                    {
                        My_Message message = new My_Message();
                        message.Id = listMessages.Count + 1;
                        message.EmailId = email.Id;

                        foreach (var mParts in emailInfoResponse.Payload.Headers)
                        {
                            if (mParts.Name == "Date")
                                message.Date_Received = mParts.Value;
                            else if (mParts.Name == "From")
                                message.From = mParts.Value;
                            else if (mParts.Name == "Subject")
                                message.Title = mParts.Value;

                            IList<MessagePart> parts = emailInfoResponse.Payload.Parts;
                            foreach (MessagePart part in parts)
                                message.Attachment_Count = int.Parse(part.PartId);
                        }

                        listMessages.Add(message);
                        emailListRequest.PageToken = emailListResponse.NextPageToken;
                    }
                }
            }
               
            ViewBag.Message = nameLabel;
            return View("~/Views/Home/Index.cshtml", listMessages);
        }

        String GetNestedParts(IList<MessagePart> part, string current)
        {
            string str = current;
            if (part == null) return str;
            else foreach (var parts in part)
                    if (parts.Parts == null)
                        if (parts.Body != null && parts.Body.Data != null)
                            str += parts.Body.Data;
                        else return GetNestedParts(parts.Parts, str);

            return str;
        }


        public async Task<IActionResult> GetMsgBody(string EmailId) // Show Email Body JavaScript
        {
            string UserEmail = User.FindFirst(c => c.Type == ClaimTypes.Email).Value;
            var service = GetService();

            var emailInfoRequest = service.Users.Messages.Get(UserEmail, EmailId);

            emailInfoRequest.Format = UsersResource.MessagesResource.GetRequest.FormatEnum.Raw;

            Message message = await service.Users.Messages.Get(UserEmail, EmailId).ExecuteAsync();

            A.body = message.Snippet;

            byte[] data = null; int i = 0;
            IList<MessagePart> parts = message.Payload.Parts;
            String[] attach_name = new string[parts.Count - 1];
            object[] dataArr = new object[parts.Count - 1];
            foreach (MessagePart part in parts)
            {
                if (!String.IsNullOrEmpty(part.Filename))
                {
                    String attId = part.Body.AttachmentId;
                    MessagePartBody attachPart = service.Users.Messages.Attachments.Get(UserEmail, EmailId, attId).Execute();
              
                    attach_name[i++] += part.Filename;

                    data = Decode(attachPart.Data);
                    //System.IO.File.WriteAllBytes(System.IO.Path.Combine(@"C:\Users\Admin\source\repos\Gmail_API\Get_Attachment", part.Filename), data);
                }
            }
         
            if (A.body == String.Empty)
                A.body = "There is no message text... The Content is EMPTY!";
            ViewBag.data = data;
            ViewBag.name = attach_name;
            //PartialView("~/Views/Home/Index.cshtml", ViewBag.name);

            return PartialView("~/Views/Google/MsgBody.cshtml", A.body);
        }

        string Base64UrlDecode(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "<strong>Message body was not returned from Google</strong>";

            string InputStr = input.Replace("-", "+").Replace("_", "/");
            return Encoding.UTF8.GetString(Convert.FromBase64String(InputStr));

        }

        byte[] Decode(string text)
        {
            string output = text;
            output = output.Replace('-', '+'); // 62nd char of encoding
            output = output.Replace('_', '/'); // 63rd char of encoding
            switch (output.Length % 4)
            { // Pad with trailing '='s
                case 0: break; // No pad chars in this case
                case 2: output += "=="; break; // Two pad chars
                case 3: output += "="; break;  // One pad char            
            }
            byte[] converted = Convert.FromBase64String(output); // Standard base64 decoder
            return converted;
        }

        string Encode(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);

            return Convert.ToBase64String(bytes)
                .Replace('+', '-')
                .Replace('/', '_')
                .Replace("=", "");
        }

        public static class A { public static string body { get; set; } }
    }
}