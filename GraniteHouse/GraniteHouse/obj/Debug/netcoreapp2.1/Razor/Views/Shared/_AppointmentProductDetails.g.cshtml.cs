#pragma checksum "C:\Users\risin\Desktop\Granite House\GraniteHouse\GraniteHouse\Views\Shared\_AppointmentProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb4b5b368319fbb60691ae9b2b46987bc93dff3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AppointmentProductDetails), @"mvc.1.0.view", @"/Views/Shared/_AppointmentProductDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_AppointmentProductDetails.cshtml", typeof(AspNetCore.Views_Shared__AppointmentProductDetails))]
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
#line 1 "C:\Users\risin\Desktop\Granite House\GraniteHouse\GraniteHouse\Views\_ViewImports.cshtml"
using GraniteHouse;

#line default
#line hidden
#line 2 "C:\Users\risin\Desktop\Granite House\GraniteHouse\GraniteHouse\Views\_ViewImports.cshtml"
using GraniteHouse.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb4b5b368319fbb60691ae9b2b46987bc93dff3d", @"/Views/Shared/_AppointmentProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"add87ae52faa7df67fbebca5d3c39a845d0e03fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AppointmentProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GraniteHouse.Models.Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\risin\Desktop\Granite House\GraniteHouse\GraniteHouse\Views\Shared\_AppointmentProductDetails.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
            BeginContext(69, 216, true);
            WriteLiteral("    <table class=\"table table-striped\" style=\"width:100%;\">\r\n        <tr class=\"table-info\">\r\n            <th style=\"text-align:center; width:20%;\"></th>\r\n            <th style=\"text-align:center;\">\r\n                ");
            EndContext();
            BeginContext(285, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b4277f0a1154d729818d4ffa370bf21", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 8 "C:\Users\risin\Desktop\Granite House\GraniteHouse\GraniteHouse\Views\Shared\_AppointmentProductDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FirstOrDefault().Name);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(339, 82, true);
            WriteLiteral("\r\n            </th>\r\n            <th style=\"text-align:center;\">\r\n                ");
            EndContext();
            BeginContext(421, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71b93cb01bc24ee699a35e826e14388d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 11 "C:\Users\risin\Desktop\Granite House\GraniteHouse\GraniteHouse\Views\Shared\_AppointmentProductDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FirstOrDefault().Price);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(476, 82, true);
            WriteLiteral("\r\n            </th>\r\n            <th style=\"text-align:center;\">\r\n                ");
            EndContext();
            BeginContext(558, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a168864b8c74f3aa4e25f7b09e0931d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 14 "C:\Users\risin\Desktop\Granite House\GraniteHouse\GraniteHouse\Views\Shared\_AppointmentProductDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FirstOrDefault().ShadeColor);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(618, 82, true);
            WriteLiteral("\r\n            </th>\r\n            <th style=\"text-align:center;\">\r\n                ");
            EndContext();
            BeginContext(700, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd193770ac174cdd8cb35857c362f639", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 17 "C:\Users\risin\Desktop\Granite House\GraniteHouse\GraniteHouse\Views\Shared\_AppointmentProductDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FirstOrDefault().ProductTypes.Name);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(767, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th style=\"text-align:center;\"></th>\r\n        </tr>\r\n");
            EndContext();
#line 21 "C:\Users\risin\Desktop\Granite House\GraniteHouse\GraniteHouse\Views\Shared\_AppointmentProductDetails.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(902, 81, true);
            WriteLiteral("            <tr style=\"padding:50px\">\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(983, 260, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59cc6dcbafcb404f8ae9d2d40453e02c", async() => {
                BeginContext(1073, 30, true);
                WriteLiteral("\r\n                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1103, "\"", 1120, 1);
#line 26 "C:\Users\risin\Desktop\Granite House\GraniteHouse\GraniteHouse\Views\Shared\_AppointmentProductDetails.cshtml"
WriteAttributeValue("", 1109, item.Image, 1109, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1121, 118, true);
                WriteLiteral(" style=\"width:100%; margin:auto; display:block; border-radius:5px; border:1px solid #bbb9b9;\" />\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 25 "C:\Users\risin\Desktop\Granite House\GraniteHouse\GraniteHouse\Views\Shared\_AppointmentProductDetails.cshtml"
                                                                                        WriteLiteral(item.Id);

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
            BeginContext(1243, 93, true);
            WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align:center\">\r\n                    ");
            EndContext();
            BeginContext(1337, 31, false);
#line 30 "C:\Users\risin\Desktop\Granite House\GraniteHouse\GraniteHouse\Views\Shared\_AppointmentProductDetails.cshtml"
               Write(Html.DisplayFor(c => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1368, 93, true);
            WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align:center\">\r\n                    ");
            EndContext();
            BeginContext(1462, 32, false);
#line 33 "C:\Users\risin\Desktop\Granite House\GraniteHouse\GraniteHouse\Views\Shared\_AppointmentProductDetails.cshtml"
               Write(Html.DisplayFor(c => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1494, 93, true);
            WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align:center\">\r\n                    ");
            EndContext();
            BeginContext(1588, 37, false);
#line 36 "C:\Users\risin\Desktop\Granite House\GraniteHouse\GraniteHouse\Views\Shared\_AppointmentProductDetails.cshtml"
               Write(Html.DisplayFor(c => item.ShadeColor));

#line default
#line hidden
            EndContext();
            BeginContext(1625, 93, true);
            WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align:center\">\r\n                    ");
            EndContext();
            BeginContext(1719, 44, false);
#line 39 "C:\Users\risin\Desktop\Granite House\GraniteHouse\GraniteHouse\Views\Shared\_AppointmentProductDetails.cshtml"
               Write(Html.DisplayFor(c => item.ProductTypes.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1763, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 42 "C:\Users\risin\Desktop\Granite House\GraniteHouse\GraniteHouse\Views\Shared\_AppointmentProductDetails.cshtml"
        }

#line default
#line hidden
            BeginContext(1818, 14, true);
            WriteLiteral("    </table>\r\n");
            EndContext();
#line 44 "C:\Users\risin\Desktop\Granite House\GraniteHouse\GraniteHouse\Views\Shared\_AppointmentProductDetails.cshtml"

}
else
{

#line default
#line hidden
            BeginContext(1846, 55, true);
            WriteLiteral("    <div>No items added to the shopping cart...</div>\r\n");
            EndContext();
#line 49 "C:\Users\risin\Desktop\Granite House\GraniteHouse\GraniteHouse\Views\Shared\_AppointmentProductDetails.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GraniteHouse.Models.Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591