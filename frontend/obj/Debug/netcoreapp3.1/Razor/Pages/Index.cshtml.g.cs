#pragma checksum "C:\Code\microservice\frontend\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd0f54c26fa3cc5a34b40216c7633a522a75042b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(frontend.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace frontend.Pages
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
#line 1 "C:\Code\microservice\frontend\Pages\_ViewImports.cshtml"
using frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd0f54c26fa3cc5a34b40216c7633a522a75042b", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"900db365c46cea34bb4e0129831d6a7fb099d04c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Code\microservice\frontend\Pages\Index.cshtml"
  
     ViewData["Title"] = "Home page";
 

#line default
#line hidden
#nullable disable
            WriteLiteral("Weather Forecast:\r\n\r\n <table class=\"table\">\r\n     <thead>\r\n         <tr>\r\n             <th>Date</th>\r\n             <th>Temp. (C)</th>\r\n             <th>Temp. (F)</th>\r\n             <th>Summary</th>\r\n         </tr>\r\n     </thead>\r\n     <tbody>\r\n");
#nullable restore
#line 18 "C:\Code\microservice\frontend\Pages\Index.cshtml"
          foreach (var forecast in @Model.Forecasts)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <tr>\r\n                 <td>");
#nullable restore
#line 21 "C:\Code\microservice\frontend\Pages\Index.cshtml"
                Write(forecast.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                 <td>");
#nullable restore
#line 22 "C:\Code\microservice\frontend\Pages\Index.cshtml"
                Write(forecast.TemperatureC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                 <td>");
#nullable restore
#line 23 "C:\Code\microservice\frontend\Pages\Index.cshtml"
                Write(forecast.TemperatureF);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                 <td>");
#nullable restore
#line 24 "C:\Code\microservice\frontend\Pages\Index.cshtml"
                Write(forecast.Summary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             </tr>\r\n");
#nullable restore
#line 26 "C:\Code\microservice\frontend\Pages\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("     </tbody>\r\n </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
