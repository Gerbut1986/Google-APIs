#pragma checksum "C:\Users\Admin\source\repos\Gmail_API\Get_Attachment\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd1e7359cec7f33c2e686c12acdf2a2cb60b87fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Admin\source\repos\Gmail_API\Get_Attachment\Views\_ViewImports.cshtml"
using Get_Attachment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\Gmail_API\Get_Attachment\Views\_ViewImports.cshtml"
using Get_Attachment.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\source\repos\Gmail_API\Get_Attachment\Views\Home\Index.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd1e7359cec7f33c2e686c12acdf2a2cb60b87fb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4869f4c39f7620e4a6782065a7f5265d2c0fabf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Get_Attachment.Models.My_Message>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/mvc-grid/mvc-grid.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"content \">\r\n    <div class=\"container\">\r\n        <!-- your content here -->\r\n");
#nullable restore
#line 8 "C:\Users\Admin\source\repos\Gmail_API\Get_Attachment\Views\Home\Index.cshtml"
         if (User.Identity.IsAuthenticated && (Model != null))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\source\repos\Gmail_API\Get_Attachment\Views\Home\Index.cshtml"
        Write(Html
              .Grid(Model)
              .Build(columns =>
              {
                  columns.Add(model => model.Id).Titled("ID");
                  columns.Add(model => model.Title).Titled("Email title");
                  columns.Add(model => model.From).Titled("From");
                  columns.Add(model => model.Date_Received).Titled("Date Receive");
                  columns.Add(model => model.Attachment_Count).Titled("Count Attach");
                  columns.Add(model => $"<input type =\"button\" data-toggle=\"modal\" data-target=\"#exampleModalCenter\"   value=\"View\" class=\"btn btn-primary btn-sm\" onClick=\"showMsgBody(\'{model.EmailId}\');\"></input>").Encoded(false);

              }).Empty("No data found").Filterable().Sortable().Css("table").AppendCss("table-hover").Pageable(pager =>
            {
                    //pager.PageSizes = new Dictionary<int, String> { { 5, "5" }, { 10, "10" }, { 20, "20" } };
                    pager.ShowPageSizes = true;
                    pager.PagesToDisplay = 3;
                    pager.CurrentPage = 1;
                    pager.RowsPerPage = 10;
            })
            );

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Admin\source\repos\Gmail_API\Get_Attachment\Views\Home\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>

<!-- Modal -->
<div class=""modal fade "" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-body"">
                <div>
                    <textarea id=""CKEditor"" name=""CKEditor""></textarea>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

<!-- Web Grid -->
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd1e7359cec7f33c2e686c12acdf2a2cb60b87fb6339", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    [].forEach.call(document.getElementsByClassName('mvc-grid'), function (element) {
        new MvcGrid(element);
    });
</script>

<!-- CKEditor -->
<script>CKEDITOR.replace('CKEditor');</script>

<!-- Show Email (Button View) -->

<script>
    function showMsgBody(EmailId)
    {
        CKEDITOR.instances['CKEditor']
        $(new Object()).load('");
#nullable restore
#line 67 "C:\Users\Admin\source\repos\Gmail_API\Get_Attachment\Views\Home\Index.cshtml"
                         Write(Url.Action("GetMsgBody", "Google"));

#line default
#line hidden
#nullable disable
            WriteLiteral("?EmailId=\' + EmailId, function(data){\r\n     CKEDITOR.instances[\'CKEditor\'].setData(data);});\r\n    }\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Get_Attachment.Models.My_Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591
