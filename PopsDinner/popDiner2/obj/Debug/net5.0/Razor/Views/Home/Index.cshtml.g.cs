#pragma checksum "D:\cleanarch\popDiner2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "522a12694abb4459149052e9333bf3ff81a9717f"
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
#line 1 "D:\cleanarch\popDiner2\Views\_ViewImports.cshtml"
using popsDiner.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\cleanarch\popDiner2\Views\_ViewImports.cshtml"
using popsDiner.Domain.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\cleanarch\popDiner2\Views\_ViewImports.cshtml"
using popsDiner.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\cleanarch\popDiner2\Views\_ViewImports.cshtml"
using popsDiner.Application.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\cleanarch\popDiner2\Views\_ViewImports.cshtml"
using popsDiner.Application.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\cleanarch\popDiner2\Views\_ViewImports.cshtml"
using popsDiner.Application.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\cleanarch\popDiner2\Views\_ViewImports.cshtml"
using popsDiner.Application.Mapping;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"522a12694abb4459149052e9333bf3ff81a9717f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7561697443329eef8c0c3d12fa7ff89ebaba7692", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 4 "D:\cleanarch\popDiner2\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("Carousel"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<h2>Những sản phẩm bán chạy</h2>\n<h4>Sự lựa chọn tuyệt vời dành cho bạn!</h4>\n\n<div class=\"row\">\n\n");
#nullable restore
#line 11 "D:\cleanarch\popDiner2\Views\Home\Index.cshtml"
     foreach (var item in Model.ItemsOfTheWeek)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\cleanarch\popDiner2\Views\Home\Index.cshtml"
   Write(Html.Partial("ItemOfTheWeek", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\cleanarch\popDiner2\Views\Home\Index.cshtml"
                                            
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
