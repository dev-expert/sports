#pragma checksum "E:\asp.netCoreDemo\Sports\Sports\Sports\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bacfef5bb838bd11130046c5140d440a6da58563"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 1 "E:\asp.netCoreDemo\Sports\Sports\Sports\Views\_ViewImports.cshtml"
using Sports;

#line default
#line hidden
#line 2 "E:\asp.netCoreDemo\Sports\Sports\Sports\Views\_ViewImports.cshtml"
using Sports.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bacfef5bb838bd11130046c5140d440a6da58563", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fb2f32a1d7c90eca9ffa878cb0cd7e64b846c98", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sports.ViewModels.TestDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddAthelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteTest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\asp.netCoreDemo\Sports\Sports\Sports\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 32, true);
            WriteLiteral("\r\n<h1>List of Atheletes</h1>\r\n\r\n");
            EndContext();
#line 9 "E:\asp.netCoreDemo\Sports\Sports\Sports\Views\Home\Details.cshtml"
 if (User.Identity.IsAuthenticated && User.IsInRole("Coach"))
{

#line default
#line hidden
            BeginContext(182, 17, true);
            WriteLiteral("    <p>\r\n        ");
            EndContext();
            BeginContext(199, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bacfef5bb838bd11130046c5140d440a6da585634999", async() => {
                BeginContext(278, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 12 "E:\asp.netCoreDemo\Sports\Sports\Sports\Views\Home\Details.cshtml"
                                                            WriteLiteral(Model.TestID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(292, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
            BeginContext(306, 157, true);
            WriteLiteral("    <p>\r\n        <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#myModal\">\r\n            Delete\r\n        </button>\r\n    </p>\r\n");
            EndContext();
#line 20 "E:\asp.netCoreDemo\Sports\Sports\Sports\Views\Home\Details.cshtml"
}

#line default
#line hidden
            BeginContext(466, 243, true);
            WriteLiteral(" \r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Ranking\r\n            </th>\r\n            <th>\r\n                Distance\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "E:\asp.netCoreDemo\Sports\Sports\Sports\Views\Home\Details.cshtml"
         foreach (var item in Model.testSubscriptions)
        {

#line default
#line hidden
            BeginContext(776, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(837, 42, false);
#line 39 "E:\asp.netCoreDemo\Sports\Sports\Sports\Views\Home\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ranking));

#line default
#line hidden
            EndContext();
            BeginContext(879, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(947, 43, false);
#line 42 "E:\asp.netCoreDemo\Sports\Sports\Sports\Views\Home\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Distance));

#line default
#line hidden
            EndContext();
            BeginContext(990, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 44 "E:\asp.netCoreDemo\Sports\Sports\Sports\Views\Home\Details.cshtml"
                 if (User.Identity.IsAuthenticated && User.IsInRole("Coach"))
                {

#line default
#line hidden
            BeginContext(1113, 95, true);
            WriteLiteral("                    <td>\r\n                        <button type=\"button\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1208, "\"", 1256, 3);
            WriteAttributeValue("", 1218, "editAthelete(", 1218, 13, true);
#line 47 "E:\asp.netCoreDemo\Sports\Sports\Sports\Views\Home\Details.cshtml"
WriteAttributeValue("", 1231, item.TestSubscriptionID, 1231, 24, false);

#line default
#line hidden
            WriteAttributeValue("", 1255, ")", 1255, 1, true);
            EndWriteAttribute();
            BeginContext(1257, 52, true);
            WriteLiteral(">Edit Athelete</button>\r\n                    </td>\r\n");
            EndContext();
#line 49 "E:\asp.netCoreDemo\Sports\Sports\Sports\Views\Home\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(1328, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 51 "E:\asp.netCoreDemo\Sports\Sports\Sports\Views\Home\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(1358, 588, true);
            WriteLiteral(@"    </tbody>
</table>
<div class=""modal"" id=""myModal"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">

            <!-- Modal Header -->
            <div class=""modal-header"">
                <h4 class=""modal-title"">Delete</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>

            <!-- Modal body -->
            <div class=""modal-body"">
                Are you sure ?

            </div>

            <!-- Modal footer -->
            <div class=""modal-footer"">
                ");
            EndContext();
            BeginContext(1946, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bacfef5bb838bd11130046c5140d440a6da5856311547", async() => {
                BeginContext(2047, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "E:\asp.netCoreDemo\Sports\Sports\Sports\Views\Home\Details.cshtml"
                                                                                          WriteLiteral(Model.TestID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2057, 1051, true);
            WriteLiteral(@"
                <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Close</button>
            </div>

        </div>
    </div>
</div>
<div class=""modal"" id=""editModal"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">

            <!-- Modal Header -->
            <div class=""modal-header"">
                <h1 class=""modal-title"">Edit Athelete</h1>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>

            <!-- Modal body -->
            <div class=""modal-body"" id=""dialog"">
                

            </div>

            <!-- Modal footer -->
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Close</button>
            </div>

        </div>
    </div>
</div>
<script>
    function DeleteModal() {
        $(""#myModal"").modal('show');
    }
    function editAthelete(id) {
        $.ajax({
            type:");
            WriteLiteral(" \"Get\",\r\n            url: \'");
            EndContext();
            BeginContext(3109, 26, false);
#line 110 "E:\asp.netCoreDemo\Sports\Sports\Sports\Views\Home\Details.cshtml"
             Write(Url.Action("editAthelete"));

#line default
#line hidden
            EndContext();
            BeginContext(3135, 502, true);
            WriteLiteral(@"/'+ id,
            contentType: ""application/json; charset=utf-8"",
            dataType: ""html"",
            success: function (response) {
                $('#dialog').html(response);
                $('#editModal').modal('show');
            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }
        });

    }
   
</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sports.ViewModels.TestDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
