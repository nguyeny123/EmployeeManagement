#pragma checksum "D:\Book\deploy\EmployeeManagertest\Views\EmployeeManager\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee6ab4af2f626edc6e3ed8806b1d3b9cd3bc4c9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeManager_Delete), @"mvc.1.0.view", @"/Views/EmployeeManager/Delete.cshtml")]
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
#line 1 "D:\Book\deploy\EmployeeManagertest\Views\_ViewImports.cshtml"
using EmployeeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Book\deploy\EmployeeManagertest\Views\_ViewImports.cshtml"
using EmployeeManager.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Book\deploy\EmployeeManagertest\Views\_ViewImports.cshtml"
using EmployeeManager.Security;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee6ab4af2f626edc6e3ed8806b1d3b9cd3bc4c9d", @"/Views/EmployeeManager/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dc6fb9e7a8d171233c4e4b47269820a42fea79a", @"/Views/_ViewImports.cshtml")]
    public class Views_EmployeeManager_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("deleteForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "EmployeeManager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<script>
    $(document).ready(function () {

        if (!sessionStorage.hasOwnProperty(""token"")) {
            window.location.href = ""/EmployeeManager/SignIn"";
        }

        var options = {};
        options.url = ""/api/employees/"" + $(""#employeeID"").val();
        options.type = ""GET"";
        options.dataType = ""json"";
        options.beforeSend = function (request) {
            request.setRequestHeader(""Authorization"", ""Bearer "" + sessionStorage.getItem(""token""));
            $(""h3.message"").html(""Wait..."");
        };
        options.success = function (data) {
            $(""#firstName"").html(data.firstName);
            $(""#lastName"").html(data.lastName);
            $(""#title"").html(data.title);
            $(""#birthDate"").html(data.birthDate.substring(0, 10));
            $(""#hireDate"").html(data.hireDate.substring(0, 10));
            $(""#country"").html(data.country);
            $(""#notes"").html(data.notes);
            $(""h3.message"").html("""");
        };
       ");
            WriteLiteral(@" options.error = function (xhr) {
            if (xhr.status == 401) {
                window.location.href = ""/EmployeeManager/SignIn"";
            }
            $(""h3.message"").html(""Error while calling the API!"");
        };
        $.ajax(options);



        $(""#delete"").click(function () {
            var options = {};
            options.url = ""/api/employees/"" + $(""#employeeID"").val();
            options.type = ""DELETE"";
            options.contentType = ""application/json"";
            options.beforeSend = function (request) {
                request.setRequestHeader(""Authorization"", ""Bearer "" + sessionStorage.getItem(""token""));
                $(""h3.message"").html(""Wait..."");
            };
            options.success = function () {
                sessionStorage.setItem(""message"", ""Employee deleted successfully!"");
                window.location.href = ""/EmployeeManager/List"";
            };
            options.error = function (xhr) {
                if (xhr.status == 401");
            WriteLiteral(@") {
                    window.location.href = ""/EmployeeManager/SignIn"";
                }
                $(""h3.message"").html(""Error while calling the API!"");
            };
            $.ajax(options);
        });
    });

</script>



<h2>Delete Existing Employee</h2>

<h3 class=""message"">
    Warning : You are about to delete an employee record.
</h3>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee6ab4af2f626edc6e3ed8806b1d3b9cd3bc4c9d7414", async() => {
                WriteLiteral("\r\n\r\n\r\n    <table border=\"0\">\r\n        <tr>\r\n            <td class=\"right\">\r\n                Employee ID :\r\n            </td>\r\n            <td>\r\n                <span>");
#nullable restore
#line 79 "D:\Book\deploy\EmployeeManagertest\Views\EmployeeManager\Delete.cshtml"
                 Write(ViewBag.EmployeeID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                <input type=\"hidden\" id=\"employeeID\" name=\"employeeID\"");
                BeginWriteAttribute("value", " value=\"", 2714, "\"", 2741, 1);
#nullable restore
#line 80 "D:\Book\deploy\EmployeeManagertest\Views\EmployeeManager\Delete.cshtml"
WriteAttributeValue("", 2722, ViewBag.EmployeeID, 2722, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
            </td>
        </tr>
        <tr>
            <td class=""right"">
                First Name :
            </td>
            <td>
                <span id=""firstName""></span>
            </td>
        </tr>
        <tr>
            <td class=""right"">
                Last Name :
            </td>
            <td>
                <span id=""lastName""></span>
            </td>
        </tr>
        <tr>
            <td class=""right"">
                Title :
            </td>
            <td>
                <span id=""title""></span>
            </td>
        </tr>
        <tr>
            <td class=""right"">
                Birth Date :
            </td>
            <td>
                <span id=""birthDate""></span>
            </td>
        </tr>
        <tr>
            <td class=""right"">
                Hire Date :
            </td>
            <td>
                <span id=""hireDate""></span>
            </td>
        </tr>
        <tr>
            <td cla");
                WriteLiteral(@"ss=""right"">
                Country :
            </td>
            <td>
                <span id=""country""></span>
            </td>
        </tr>
        <tr>
            <td class=""right"">
                Notes :
            </td>
            <td>
                <span id=""notes""></span>
            </td>
        </tr>
        <tr>
            <td colspan=""2"">
                <button id=""delete"" type=""button"" class=""btn btn-primary"">Delete</button>
            </td>
        </tr>
    </table>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<br />\r\n<br />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee6ab4af2f626edc6e3ed8806b1d3b9cd3bc4c9d11253", async() => {
                WriteLiteral("Back to Employee Listing");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
