#pragma checksum "D:\Repository\GitHub_Gerbut1986\Google-APIs\Gmail_API\Gmail_API\Views\Gmail\SendEmailView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e92f62a285a5e3206de4a481f8c3c689e073a848"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gmail_SendEmailView), @"mvc.1.0.view", @"/Views/Gmail/SendEmailView.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Repository\GitHub_Gerbut1986\Google-APIs\Gmail_API\Gmail_API\Views\_ViewImports.cshtml"
using Gmail_API;

#line default
#line hidden
#line 2 "D:\Repository\GitHub_Gerbut1986\Google-APIs\Gmail_API\Gmail_API\Views\_ViewImports.cshtml"
using Gmail_API.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e92f62a285a5e3206de4a481f8c3c689e073a848", @"/Views/Gmail/SendEmailView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9644cbc1d55fdbe0d7e874e003b6123ed8bd272e", @"/Views/_ViewImports.cshtml")]
    public class Views_Gmail_SendEmailView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#line 2 "D:\Repository\GitHub_Gerbut1986\Google-APIs\Gmail_API\Gmail_API\Views\Gmail\SendEmailView.cshtml"
  
    ViewData["Title"] = "SendEmailView";

#line default
#line hidden
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n");
#line 9 "D:\Repository\GitHub_Gerbut1986\Google-APIs\Gmail_API\Gmail_API\Views\Gmail\SendEmailView.cshtml"
     using (Html.BeginForm("SendEmail", "Gmail"))
    {

#line default
#line hidden
            WriteLiteral("        <label for=\"subject\"> Subject: </label>\r\n        <input required type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 258, "\"", 287, 1);
#line 12 "D:\Repository\GitHub_Gerbut1986\Google-APIs\Gmail_API\Gmail_API\Views\Gmail\SendEmailView.cshtml"
WriteAttributeValue("", 266, ViewBag.userDatas[1], 266, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" name=\"subject\" id=\"subject\" />\r\n");
            WriteLiteral("        <label for=\"subject\"> To: </label>\r\n        <input required type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 423, "\"", 437, 1);
#line 15 "D:\Repository\GitHub_Gerbut1986\Google-APIs\Gmail_API\Gmail_API\Views\Gmail\SendEmailView.cshtml"
WriteAttributeValue("", 431, Model, 431, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" name=\"emailTo\" id=\"emailTo\" />\r\n        <br />\r\n");
            WriteLiteral("        <label for=\"subject\"> Text of the Message: </label>\r\n        <textarea class=\"form-control\" name=\"body\" id=\"body\"></textarea>\r\n        <br />\r\n");
            WriteLiteral("        <input type=\"submit\" class=\"btn btn-primary\" value=\"Send Message\" />\r\n");
#line 23 "D:\Repository\GitHub_Gerbut1986\Google-APIs\Gmail_API\Gmail_API\Views\Gmail\SendEmailView.cshtml"
    }

#line default
#line hidden
            WriteLiteral("</div>\r\n\r\n");
#line 26 "D:\Repository\GitHub_Gerbut1986\Google-APIs\Gmail_API\Gmail_API\Views\Gmail\SendEmailView.cshtml"
 if (Model != null)
{

#line default
#line hidden
            WriteLiteral("    <script>\r\n        var emailId = \'");
#line 29 "D:\Repository\GitHub_Gerbut1986\Google-APIs\Gmail_API\Gmail_API\Views\Gmail\SendEmailView.cshtml"
                  Write(ViewBag.userDatas[0]);

#line default
#line hidden
            WriteLiteral("\';\r\n\r\n        $(new Object()).load(\'https://localhost:44318/Gmail/GetEmailContent?emailId\' + emailId, function (data) {\r\n            CREDITOR.instances[\'body\'].setData(data);\r\n        });\r\n    </script>\r\n");
#line 35 "D:\Repository\GitHub_Gerbut1986\Google-APIs\Gmail_API\Gmail_API\Views\Gmail\SendEmailView.cshtml"
}

#line default
#line hidden
            WriteLiteral("\r\n\r\n<script>\r\n    CREDITOR.replace(\'body\');\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
