#pragma checksum "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8238a85458b14c5f69f77066b137471edabde2b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SchoolPlanner2.Pages.AdminPanel.Pages_AdminPanel_Index), @"mvc.1.0.razor-page", @"/Pages/AdminPanel/Index.cshtml")]
namespace SchoolPlanner2.Pages.AdminPanel
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
#line 1 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\_ViewImports.cshtml"
using SchoolPlanner2;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8238a85458b14c5f69f77066b137471edabde2b5", @"/Pages/AdminPanel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15862ed59ffcb9c3c02b2703d004528a695f7aeb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AdminPanel_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Tasks/Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1 class=\"weeklyOverview\">Weekly Overview</h1>\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<div class=\"div-orari\">\r\n    <table id=\"weekday\">\r\n        <thead>\r\n            <tr>\r\n                <th>Monday</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 123 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
             foreach (var item in Model.Subject)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n");
#nullable restore
#line 127 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
                         if (item.Day.Equals("Monday"))
                        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
                                                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 131 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <table id=\"weekday\">\r\n        <thead>\r\n            <tr>\r\n                <th>Tuesday</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 142 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
             foreach (var item in Model.Subject)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n");
#nullable restore
#line 146 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
                         if (item.Day.Equals("Tuesday"))
                        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 147 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 147 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
                                                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 150 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <table id=\"weekday\">\r\n        <thead>\r\n            <tr>\r\n                <th>Wednesday</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 160 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
             foreach (var item in Model.Subject)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n");
#nullable restore
#line 164 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
                         if (item.Day.Equals("Wednesday"))
                        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 165 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 165 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
                                                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 168 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <table id=\"weekday\">\r\n\r\n        <thead>\r\n            <tr>\r\n                <th>Thursday</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 180 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
             foreach (var item in Model.Subject)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n");
#nullable restore
#line 184 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
                         if (item.Day.Equals("Thursday"))
                        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 185 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 185 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
                                                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 188 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <table id=\"weekday\">\r\n\r\n        <thead>\r\n            <tr>\r\n                <th>Friday</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 200 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
             foreach (var item in Model.Subject)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n");
#nullable restore
#line 204 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
                         if (item.Day.Equals("Friday"))
                        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 205 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 205 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
                                                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 208 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <table id=\"weekday\">\r\n\r\n        <thead>\r\n            <tr>\r\n                <th>Saturday</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 220 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
             foreach (var item in Model.Subject)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n");
#nullable restore
#line 224 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
                         if (item.Day.Equals("Saturday"))
                        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 225 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 225 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
                                                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 228 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <table id=\"weekday\">\r\n\r\n        <thead>\r\n            <tr>\r\n                <th>Sunday</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 240 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
             foreach (var item in Model.Subject)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n");
#nullable restore
#line 244 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
                         if (item.Day.Equals("Sunday"))
                        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 245 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 245 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
                                                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 248 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n<br />\r\n<div class=\"taskAndExam\">\r\n    <div class=\"AllTaskDiv\">\r\n        <h1 class=\"tasksOverview\">\r\n            Tasks Overview\r\n        </h1>\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 263 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
         foreach (var item in Model.Task)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"singleTaskDiv\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8238a85458b14c5f69f77066b137471edabde2b514463", async() => {
                WriteLiteral("<p class=\"taskTitle\">");
#nullable restore
#line 266 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
                                                                                   Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 266 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
                                         WriteLiteral(item.TaskID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n        <p class=\"taskDetail\">");
#nullable restore
#line 267 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
                         Write(Html.DisplayFor(modelItem => item.Detail));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"taskType\">");
#nullable restore
#line 268 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TypeOfTask));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <br />\r\n        <p class=\"taskSubject\">");
#nullable restore
#line 270 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
                          Write(Html.DisplayFor(modelItem => item.Subject.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"taskDueDate\">");
#nullable restore
#line 271 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
                          Write(Html.DisplayFor(modelItem => item.DueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 7780, "\"", 7833, 1);
#nullable restore
#line 273 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
WriteAttributeValue("", 7787, Url.Action("Complete", new{id = item.TaskID}), 7787, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Complete</a>\r\n\r\n    </div>\r\n");
#nullable restore
#line 276 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"AllExamDiv\">\r\n        <h1 class=\"tasksOverview\">\r\n            Exams Overview\r\n        </h1>\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 285 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
         foreach (var item in Model.Exam)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"singleTaskDiv\">\r\n                ");
#nullable restore
#line 288 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Subject.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 289 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateAndTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 290 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Room));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 292 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\AdminPanel\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n<br />\r\n<br />\r\n\r\n\r\n\r\n");
            WriteLiteral(@"

<style>



    .AllTaskDiv {
        float: left;
        margin-bottom: 120px;
    }

    .AllExamDiv {
        float: right;
    }

    #weekday {
        padding-left: 50px;
        display: inline-block;
        text-align: center
    }

        #weekday th {
            color: darkslateblue
        }

        #weekday td {
            color: black;
            position: inherit;
            font-size: 14px
        }

    .div-orari {
        display: flex;
    }

    .weeklyOverview {
        text-align: center;
        margin-bottom: 50px;
    }

    .tasksOverview {
        text-align: left;
        margin-bottom:20px;
    }

    .singleTaskDiv {
        width: 300px;
        height: 85px;
        margin-bottom: 30px;
        border: 4px solid #000;
    }

    .taskTitle {
        display: block;
        text-align:center;
        font-size: 20px;
        color: blue;
        margin-bottom: 0px;
    }

    .taskDetail {
        display: inl");
            WriteLiteral(@"ine-block;
        margin-bottom: 0px;
    }

    .taskType {
        display: inline-block;
        float: right;
        margin-bottom: 0px;
        padding-right: 3px;
        margin-bottom: 20px;
    }

    .taskDueDate {
        display: inline-block;
        margin-bottom: 0px;
    }

    .taskSubject {
        display: inline-block;
        margin-bottom: 0px;
    }

    .taskDetail {
        display: inline-block;
        margin-bottom: 0px;
    }

    .taskDetailLink{

    }
</style>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SchoolPlanner2.Pages.AdminPanel.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SchoolPlanner2.Pages.AdminPanel.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SchoolPlanner2.Pages.AdminPanel.IndexModel>)PageContext?.ViewData;
        public SchoolPlanner2.Pages.AdminPanel.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591