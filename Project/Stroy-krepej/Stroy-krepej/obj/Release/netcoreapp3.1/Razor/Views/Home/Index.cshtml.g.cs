#pragma checksum "C:\Users\Win10Pro\Desktop\Stroy-krepej\Stroy-krepej\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65d1880d118ea666f31730faed9a52a87ec39bb1"
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
#line 2 "C:\Users\Win10Pro\Desktop\Stroy-krepej\Stroy-krepej\Views\_ViewImports.cshtml"
using Stroy_krepej.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Win10Pro\Desktop\Stroy-krepej\Stroy-krepej\Views\_ViewImports.cshtml"
using Stroy_krepej.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Win10Pro\Desktop\Stroy-krepej\Stroy-krepej\Views\_ViewImports.cshtml"
using Stroy_krepej.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Win10Pro\Desktop\Stroy-krepej\Stroy-krepej\Views\_ViewImports.cshtml"
using Stroy_krepej.Models.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65d1880d118ea666f31730faed9a52a87ec39bb1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aafa978a8e48d9bcadc70219256d9b586583dbb6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TextField>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Win10Pro\Desktop\Stroy-krepej\Stroy-krepej\Views\Home\Index.cshtml"
   
    ViewBag.Title = Model.MetaTitle;
    ViewBag.Description = Model.MetaDescription;
    ViewBag.KeyWords = Model.MetaKeyWords;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 8 "C:\Users\Win10Pro\Desktop\Stroy-krepej\Stroy-krepej\Views\Home\Index.cshtml"
Write(Html.Raw(Model.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TextField> Html { get; private set; }
    }
}
#pragma warning restore 1591