#pragma checksum "C:\Users\Mark Hopper\Documents\VS Code Projects\Claims Application\Pages\LossView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1d165d2fb16a446d9825f4e2190dce470ad89d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Claims_Application.Pages.Pages_LossView), @"mvc.1.0.razor-page", @"/Pages/LossView.cshtml")]
namespace Claims_Application.Pages
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
#line 1 "C:\Users\Mark Hopper\Documents\VS Code Projects\Claims Application\Pages\_ViewImports.cshtml"
using Claims_Application;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mark Hopper\Documents\VS Code Projects\Claims Application\Pages\LossView.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1d165d2fb16a446d9825f4e2190dce470ad89d2", @"/Pages/LossView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0653547ded2c70c7ac34ce48fadc0389d1b19a0c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_LossView : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Mark Hopper\Documents\VS Code Projects\Claims Application\Pages\LossView.cshtml"
  
    ViewData["Title"] = "LossView Page";
    ViewData["PageName"] = "LossView"; //Keep Track of Page Name (used to Enable / Disable certain buttons and links)

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome - ");
#nullable restore
#line 10 "C:\Users\Mark Hopper\Documents\VS Code Projects\Claims Application\Pages\LossView.cshtml"
                               Write(Model.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h3>Loss Types</h3>\r\n</div>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Mark Hopper\Documents\VS Code Projects\Claims Application\Pages\LossView.cshtml"
 if (Model.LossTypes != null) //Generate Loss Types Table if we've managed to Retrieve Data
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table border=""1"" style=""width:100%;"">
        <tr>
            <td style=""width:20%;"">
                Loss Type ID
            </td>
            <td style=""width:20%;"">
                Loss Type Code
            </td>
            <td style=""width:60%;"">
                Loss Type Description
            </td>
        </tr>


");
#nullable restore
#line 30 "C:\Users\Mark Hopper\Documents\VS Code Projects\Claims Application\Pages\LossView.cshtml"
         foreach (var item in Model.LossTypes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td style=\"width:20%;\">\r\n                    ");
#nullable restore
#line 34 "C:\Users\Mark Hopper\Documents\VS Code Projects\Claims Application\Pages\LossView.cshtml"
               Write(Html.DisplayFor(modelItem => item.LossTypeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td style=\"width:20%;\">\r\n                    ");
#nullable restore
#line 37 "C:\Users\Mark Hopper\Documents\VS Code Projects\Claims Application\Pages\LossView.cshtml"
               Write(Html.DisplayFor(modelItem => item.LossTypeCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td style=\"width:60%;\">\r\n                    ");
#nullable restore
#line 40 "C:\Users\Mark Hopper\Documents\VS Code Projects\Claims Application\Pages\LossView.cshtml"
               Write(Html.DisplayFor(modelItem => item.LossTypeDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 43 "C:\Users\Mark Hopper\Documents\VS Code Projects\Claims Application\Pages\LossView.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 45 "C:\Users\Mark Hopper\Documents\VS Code Projects\Claims Application\Pages\LossView.cshtml"
} else {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"color:red\">Unable to Retrieve Loss Type Data</div>\r\n");
#nullable restore
#line 47 "C:\Users\Mark Hopper\Documents\VS Code Projects\Claims Application\Pages\LossView.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LossViewModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LossViewModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LossViewModel>)PageContext?.ViewData;
        public LossViewModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
