#pragma checksum "C:\Sumana\Study\GC-C#.NetBootcamp\Day29\IdentityFrameworkExercise\IdentityFrameworkSample\IdentityFrameworkSample\Views\ToDo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5f31cdfa649780967355f4acb1f7e7c9f7777da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDo_Index), @"mvc.1.0.view", @"/Views/ToDo/Index.cshtml")]
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
#line 1 "C:\Sumana\Study\GC-C#.NetBootcamp\Day29\IdentityFrameworkExercise\IdentityFrameworkSample\IdentityFrameworkSample\Views\_ViewImports.cshtml"
using IdentityFrameworkSample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Sumana\Study\GC-C#.NetBootcamp\Day29\IdentityFrameworkExercise\IdentityFrameworkSample\IdentityFrameworkSample\Views\_ViewImports.cshtml"
using IdentityFrameworkSample.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5f31cdfa649780967355f4acb1f7e7c9f7777da", @"/Views/ToDo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1849c9f1d9636ca77ff968473402f41c34465459", @"/Views/_ViewImports.cshtml")]
    public class Views_ToDo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Todo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/StyleSheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ic_menu_edit.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ic_menu_delete.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("X"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("../ToDo/ChangeStatus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("table"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5f31cdfa649780967355f4acb1f7e7c9f7777da6794", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e5f31cdfa649780967355f4acb1f7e7c9f7777da7056", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Sumana\Study\GC-C#.NetBootcamp\Day29\IdentityFrameworkExercise\IdentityFrameworkSample\IdentityFrameworkSample\Views\ToDo\Index.cshtml"
  
    ViewData["Title"] = "ToDo";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4>ToDo List</h4>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5f31cdfa649780967355f4acb1f7e7c9f7777da9250", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Sumana\Study\GC-C#.NetBootcamp\Day29\IdentityFrameworkExercise\IdentityFrameworkSample\IdentityFrameworkSample\Views\ToDo\Index.cshtml"
     if (Model.Count != 0)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <input type=""text"" id=""searchText"" onkeyup=""searchFunction()"" placeholder=""Search task description.."">
        <table id=""todoList""class=""table table-striped table-bordered"">
            <tr>
                <th>Description</th>
                <th class=""underlined"" onclick=""sortTable(1)"">Due Date</th>
                <th class=""underlined"" onclick=""sortTable(2)"">Complete</th>
                <th></th>
            </tr>
");
#nullable restore
#line 21 "C:\Sumana\Study\GC-C#.NetBootcamp\Day29\IdentityFrameworkExercise\IdentityFrameworkSample\IdentityFrameworkSample\Views\ToDo\Index.cshtml"
             foreach (Todo t in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 24 "C:\Sumana\Study\GC-C#.NetBootcamp\Day29\IdentityFrameworkExercise\IdentityFrameworkSample\IdentityFrameworkSample\Views\ToDo\Index.cshtml"
                   Write(t.TodoDesc);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td id=\"dateCol\">");
#nullable restore
#line 25 "C:\Sumana\Study\GC-C#.NetBootcamp\Day29\IdentityFrameworkExercise\IdentityFrameworkSample\IdentityFrameworkSample\Views\ToDo\Index.cshtml"
                                Write(t.DueDate.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td id=\"completeCol\">\r\n                        <div class=\"switch\">\r\n");
#nullable restore
#line 28 "C:\Sumana\Study\GC-C#.NetBootcamp\Day29\IdentityFrameworkExercise\IdentityFrameworkSample\IdentityFrameworkSample\Views\ToDo\Index.cshtml"
                             if (t.Complete == true)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <input type=\"checkbox\" name=\"Complete\" value=\"true\" checked disabled />\r\n                                <input type=\"checkbox\" name=\"Complete\" value=\"false\" hidden />\r\n");
#nullable restore
#line 32 "C:\Sumana\Study\GC-C#.NetBootcamp\Day29\IdentityFrameworkExercise\IdentityFrameworkSample\IdentityFrameworkSample\Views\ToDo\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <input type=\"checkbox\" name=\"Complete\" value=\"true\" disabled />\r\n                                <input type=\"checkbox\" name=\"Complete\" value=\"false\" hidden />\r\n");
#nullable restore
#line 37 "C:\Sumana\Study\GC-C#.NetBootcamp\Day29\IdentityFrameworkExercise\IdentityFrameworkSample\IdentityFrameworkSample\Views\ToDo\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a");
                BeginWriteAttribute("href", " href=\"", 1623, "\"", 1678, 4);
                WriteAttributeValue("", 1630, "../ToDo/ChangeStatus?id=", 1630, 24, true);
#nullable restore
#line 38 "C:\Sumana\Study\GC-C#.NetBootcamp\Day29\IdentityFrameworkExercise\IdentityFrameworkSample\IdentityFrameworkSample\Views\ToDo\Index.cshtml"
WriteAttributeValue("", 1654, t.Id, 1654, 5, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1659, "&status=", 1659, 8, true);
#nullable restore
#line 38 "C:\Sumana\Study\GC-C#.NetBootcamp\Day29\IdentityFrameworkExercise\IdentityFrameworkSample\IdentityFrameworkSample\Views\ToDo\Index.cshtml"
WriteAttributeValue("", 1667, t.Complete, 1667, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e5f31cdfa649780967355f4acb1f7e7c9f7777da13697", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</a>\r\n                        </div>\r\n");
                WriteLiteral("                    </td>\r\n                    <td id=\"deleteCol\"><a");
                BeginWriteAttribute("href", " href=\"", 1996, "\"", 2030, 2);
                WriteAttributeValue("", 2003, "../ToDo/DeleteToDo?Id=", 2003, 22, true);
#nullable restore
#line 42 "C:\Sumana\Study\GC-C#.NetBootcamp\Day29\IdentityFrameworkExercise\IdentityFrameworkSample\IdentityFrameworkSample\Views\ToDo\Index.cshtml"
WriteAttributeValue("", 2025, t.Id, 2025, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" onclick=\"return confirm(\'Are you sure you want to delete this item?\')\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e5f31cdfa649780967355f4acb1f7e7c9f7777da15607", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 44 "C:\Sumana\Study\GC-C#.NetBootcamp\Day29\IdentityFrameworkExercise\IdentityFrameworkSample\IdentityFrameworkSample\Views\ToDo\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n");
#nullable restore
#line 46 "C:\Sumana\Study\GC-C#.NetBootcamp\Day29\IdentityFrameworkExercise\IdentityFrameworkSample\IdentityFrameworkSample\Views\ToDo\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h5>Your Todo list is currently empty.</h5>\r\n");
#nullable restore
#line 50 "C:\Sumana\Study\GC-C#.NetBootcamp\Day29\IdentityFrameworkExercise\IdentityFrameworkSample\IdentityFrameworkSample\Views\ToDo\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <p><a href=\"../ToDo/AddTodo\" class=\"btn btn-primary\">Add a Todo item here!</a></p>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    function searchFunction() {
        // Declare variables
        var input, filter, table, tr, td, i, txtValue;
        input = document.getElementById(""searchText"");
        filter = input.value.toUpperCase();
        table = document.getElementById(""todoList"");
        tr = table.getElementsByTagName(""tr"");

        // Loop through all table rows, and hide those who don't match the search query
        for (i = 0; i < tr.length; i++) {
            td = tr[i].getElementsByTagName(""td"")[0];
            if (td) {
                txtValue = td.textContent || td.innerText;
                if (txtValue.toUpperCase().indexOf(filter) > -1) {
                    tr[i].style.display = """";
                } else {
                    tr[i].style.display = ""none"";
                }
            }
        }
    }

    function sortTable(n) {
  var table, rows, switching, i, x, y, shouldSwitch, dir, switchcount = 0;
  table = document.getElementById(""todoList"");
  switching = true;");
            WriteLiteral(@"
  // Set the sorting direction to ascending:
  dir = ""asc"";
  /* Make a loop that will continue until
  no switching has been done: */
  while (switching) {
    // Start by saying: no switching is done:
    switching = false;
    rows = table.rows;
    /* Loop through all table rows (except the
    first, which contains table headers): */
    for (i = 1; i < (rows.length - 1); i++) {
      // Start by saying there should be no switching:
      shouldSwitch = false;
      /* Get the two elements you want to compare,
      one from current row and one from the next: */
      x = rows[i].getElementsByTagName(""TD"")[n];
      y = rows[i + 1].getElementsByTagName(""TD"")[n];
      /* Check if the two rows should switch place,
      based on the direction, asc or desc: */
      if (dir == ""asc"") {
        if (x.innerHTML.toLowerCase() > y.innerHTML.toLowerCase()) {
          // If so, mark as a switch and break the loop:
          shouldSwitch = true;
          break;
        }
      } else ");
            WriteLiteral(@"if (dir == ""desc"") {
        if (x.innerHTML.toLowerCase() < y.innerHTML.toLowerCase()) {
          // If so, mark as a switch and break the loop:
          shouldSwitch = true;
          break;
        }
      }
    }
    if (shouldSwitch) {
      /* If a switch has been marked, make the switch
      and mark that a switch has been done: */
      rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
      switching = true;
      // Each time a switch is done, increase this count by 1:
      switchcount ++;
    } else {
      /* If no switching has been done AND the direction is ""asc"",
      set the direction to ""desc"" and run the while loop again. */
      if (switchcount == 0 && dir == ""asc"") {
        dir = ""desc"";
        switching = true;
      }
    }
  }
}
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Todo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
