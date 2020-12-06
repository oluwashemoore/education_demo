#pragma checksum "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\Reports\Attendance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f483d96f26742a86b840ac7d0410fd77d5c552c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reports_Attendance), @"mvc.1.0.view", @"/Views/Reports/Attendance.cshtml")]
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
#line 1 "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\_ViewImports.cshtml"
using web_demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\_ViewImports.cshtml"
using web_demo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\Reports\Attendance.cshtml"
using web_demo.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f483d96f26742a86b840ac7d0410fd77d5c552c", @"/Views/Reports/Attendance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"227cf24d5922b7a82fb79fb3efcdf5e72204f65d", @"/Views/_ViewImports.cshtml")]
    public class Views_Reports_Attendance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Attendance", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\Reports\Attendance.cshtml"
  
    ViewData["Title"] = "Attendance";
    var students = ViewData["students"] as List<Student>;
    var data = ViewData["data"] as string;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f483d96f26742a86b840ac7d0410fd77d5c552c4174", async() => {
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label\">Schools:</label>\r\n            <select name=\"schoolId\">\r\n");
#nullable restore
#line 13 "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\Reports\Attendance.cshtml"
                 foreach (var school in ViewData["schools"] as List<School>)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f483d96f26742a86b840ac7d0410fd77d5c552c4890", async() => {
#nullable restore
#line 15 "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\Reports\Attendance.cshtml"
                                               Write(school.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("name", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\Reports\Attendance.cshtml"
                            WriteLiteral(school.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 16 "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\Reports\Attendance.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </select>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label\">Subjects: </label>\r\n\r\n            <select name=\"subjectId\">\r\n");
#nullable restore
#line 24 "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\Reports\Attendance.cshtml"
                 foreach (var subject in ViewData["subjects"] as List<Subject>)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f483d96f26742a86b840ac7d0410fd77d5c552c7816", async() => {
#nullable restore
#line 26 "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\Reports\Attendance.cshtml"
                                           Write(subject.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\Reports\Attendance.cshtml"
                       WriteLiteral(subject.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 27 "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\Reports\Attendance.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </select>
        </div>

        <div class=""form-group"">
            <label class=""control-label"">From: </label>

            <input  name=""From"" type=""date"" />
        </div>

        <div class=""form-group"">
            <label class=""control-label"">To: </label>

            <input name=""To"" type=""date"" />
        </div>


        

        <div class=""form-group"">
            <input type=""submit"" value=""Generate"" class=""btn btn-primary"" />
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 51 "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\Reports\Attendance.cshtml"
 if (data == "data")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Students\r\n            </th>\r\n");
#nullable restore
#line 59 "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\Reports\Attendance.cshtml"
             foreach (var attendance in ViewData["attendances"] as List<Attendance>)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th>\r\n                    ");
#nullable restore
#line 62 "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\Reports\Attendance.cshtml"
               Write(attendance.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n");
#nullable restore
#line 64 "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\Reports\Attendance.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 69 "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\Reports\Attendance.cshtml"
         foreach (var student in ViewData["students"] as List<Student>)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\Reports\Attendance.cshtml"
           Write(student.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 73 "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\Reports\Attendance.cshtml"
                              Write(student.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n");
#nullable restore
#line 76 "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\Reports\Attendance.cshtml"
             foreach (var attendance in ViewData["attendances"] as List<Attendance>)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>\r\n");
#nullable restore
#line 79 "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\Reports\Attendance.cshtml"
              
                var studentAttendancedetails = attendance.AttendanceDetails.SingleOrDefault(x => x.StudentId == student.ID);
                var status = studentAttendancedetails != null ? studentAttendancedetails.Status : false;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\Reports\Attendance.cshtml"
             if (status)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <i style=\"color:#00FF00;\" class=\"fas fa-check\"></i>\r\n");
#nullable restore
#line 86 "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\Reports\Attendance.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <i style=\"color:#FF0000;\" class=\"fas fa-times\"></i>\r\n");
#nullable restore
#line 90 "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\Reports\Attendance.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </td>\r\n");
#nullable restore
#line 92 "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\Reports\Attendance.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 96 "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\Reports\Attendance.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 101 "D:\PRIVATE\NGN EDUCATIONAL\Demo\web-demo\web-demo\Views\Reports\Attendance.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
