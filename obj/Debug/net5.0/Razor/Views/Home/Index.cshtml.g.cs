#pragma checksum "D:\FormacaoBootstrap5AluraCursos\Meteora\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41c7feb24164ee810cd8100b78a9c89871147edf"
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
#line 1 "D:\FormacaoBootstrap5AluraCursos\Meteora\Views\_ViewImports.cshtml"
using Meteora;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FormacaoBootstrap5AluraCursos\Meteora\Views\_ViewImports.cshtml"
using Meteora.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41c7feb24164ee810cd8100b78a9c89871147edf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eb88085fce929e7fc4d4c50634c358f73196b44", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("border border-secondary m-3 p-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\FormacaoBootstrap5AluraCursos\Meteora\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""carouselExampleCaptions"" class=""carousel slide"" data-bs-ride=""carousel"">
    <div class=""carousel-indicators"">
        <button type=""button"" data-bs-target=""#carouselExampleCaptions"" data-bs-slide-to=""0"" class=""active"" aria-current=""true"" aria-label=""Slide 1""></button>
        <button type=""button"" data-bs-target=""#carouselExampleCaptions"" data-bs-slide-to=""1"" aria-label=""Slide 2""></button>
        <button type=""button"" data-bs-target=""#carouselExampleCaptions"" data-bs-slide-to=""2"" aria-label=""Slide 3""></button>
    </div>
    <div class=""carousel-inner"">
        <div class=""carousel-item active"">
            <img src=""..."" class=""d-block w-100"" alt=""..."">
            <div class=""carousel-caption d-none d-md-block"">
                <h5>First slide label</h5>
                <p>Some representative placeholder content for the first slide.</p>
            </div>
        </div>
        <div class=""carousel-item"">
            <img src=""..."" class=""d-block w-100"" alt=""..."">
            <d");
            WriteLiteral(@"iv class=""carousel-caption d-none d-md-block"">
                <h5>Second slide label</h5>
                <p>Some representative placeholder content for the second slide.</p>
            </div>
        </div>
        <div class=""carousel-item"">
            <img src=""..."" class=""d-block w-100"" alt=""..."">
            <div class=""carousel-caption d-none d-md-block"">
                <h5>Third slide label</h5>
                <p>Some representative placeholder content for the third slide.</p>
            </div>
        </div>
    </div>
    <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#carouselExampleCaptions"" data-bs-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""visually-hidden"">Previous</span>
    </button>
    <button class=""carousel-control-next"" type=""button"" data-bs-target=""#carouselExampleCaptions"" data-bs-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
      ");
            WriteLiteral(@"  <span class=""visually-hidden"">Next</span>
    </button>
</div>

<h2 class=""text-center"">Busque por categoria:</h2>
<div class=""container row mx-auto g-4"">
    <div class=""col-6 col-md-4 col-xxl-2"">
        <div class=""card"">
            <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""180"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Image cap"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#868e96""></rect><text x=""50%"" y=""50%"" fill=""#dee2e6"" dy="".3em"">Image cap</text></svg>
            <div class=""card-header"">
                <p class=""text-center"">Categoria</p>
            </div>
        </div>
    </div>
    <div class=""col-6 col-md-4 col-xxl-2"">
        <div class=""card"">
            <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""180"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Image cap"" preserveAspectRatio=""xMidYMid slice"" fo");
            WriteLiteral(@"cusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#868e96""></rect><text x=""50%"" y=""50%"" fill=""#dee2e6"" dy="".3em"">Image cap</text></svg>
            <div class=""card-header"">
                <p class=""text-center"">Categoria</p>
            </div>
        </div>
    </div>
    <div class=""col-6 col-md-4 col-xxl-2"">
        <div class=""card"">
            <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""180"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Image cap"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#868e96""></rect><text x=""50%"" y=""50%"" fill=""#dee2e6"" dy="".3em"">Image cap</text></svg>
            <div class=""card-header"">
                <p class=""text-center"">Categoria</p>
            </div>
        </div>
    </div>
    <div class=""col-6 col-md-4 col-xxl-2"">
        <div class=""card"">
            <svg class=""bd-placeholder-img card-img-top"" w");
            WriteLiteral(@"idth=""100%"" height=""180"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Image cap"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#868e96""></rect><text x=""50%"" y=""50%"" fill=""#dee2e6"" dy="".3em"">Image cap</text></svg>
            <div class=""card-header"">
                <p class=""text-center"">Categoria</p>
            </div>
        </div>
    </div>
    <div class=""col-6 col-md-4 col-xxl-2"">
        <div class=""card"">
            <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""180"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Image cap"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#868e96""></rect><text x=""50%"" y=""50%"" fill=""#dee2e6"" dy="".3em"">Image cap</text></svg>
            <div class=""card-header"">
                <p class=""text-center"">Categoria</p>
            </div>
        </di");
            WriteLiteral(@"v>
    </div>
    <div class=""col-6 col-md-4 col-xxl-2"">
        <div class=""card"">
            <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""180"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Image cap"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#868e96""></rect><text x=""50%"" y=""50%"" fill=""#dee2e6"" dy="".3em"">Image cap</text></svg>
            <div class=""card-header"">
                <p class=""text-center"">Categoria</p>
            </div>
        </div>
    </div>
</div>
<h2 class=""text-center"">Produtos que estão bombando!</h2>
<div class=""container row mx-auto"">
    <div class=""col-12 col-md-6 col-xxl-4 pb-4"">
        <div class=""card"">
            <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""180"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Image cap"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</t");
            WriteLiteral(@"itle><rect width=""100%"" height=""100%"" fill=""#868e96""></rect><text x=""50%"" y=""50%"" fill=""#dee2e6"" dy="".3em"">Image cap</text></svg>
            <div class=""card-body"">
                <h5 class=""card-title"">Produto</h5>
                <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                <p>R$ 30,00</p>
                <a href=""#"" class=""btn btn-primary"">Ver mais</a>
            </div>
        </div>
    </div>
    <div class=""col-12 col-md-6 col-xxl-4 pb-4"">
        <div class=""card"">
            <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""180"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Image cap"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#868e96""></rect><text x=""50%"" y=""50%"" fill=""#dee2e6"" dy="".3em"">Image cap</text></svg>
            <div class=""card-body"">
                <h5 class=""card-");
            WriteLiteral(@"title"">Produto</h5>
                <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                <p>R$ 30,00</p>
                <a href=""#"" class=""btn btn-primary"">Ver mais</a>
            </div>
        </div>
    </div>
    <div class=""col-12 col-md-6 col-xxl-4 pb-4"">
        <div class=""card"">
            <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""180"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Image cap"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#868e96""></rect><text x=""50%"" y=""50%"" fill=""#dee2e6"" dy="".3em"">Image cap</text></svg>
            <div class=""card-body"">
                <h5 class=""card-title"">Produto</h5>
                <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                <p>R$ 30,00</p>
         ");
            WriteLiteral(@"       <a href=""#"" class=""btn btn-primary"">Ver mais</a>
            </div>
        </div>
    </div>
    <div class=""col-12 col-md-6 col-xxl-4 pb-4"">
        <div class=""card"">
            <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""180"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Image cap"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#868e96""></rect><text x=""50%"" y=""50%"" fill=""#dee2e6"" dy="".3em"">Image cap</text></svg>
            <div class=""card-body"">
                <h5 class=""card-title"">Produto</h5>
                <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                <p>R$ 30,00</p>
                <a href=""#"" class=""btn btn-primary"">Ver mais</a>
            </div>
        </div>
    </div>
    <div class=""col-12 col-md-6 col-xxl-4 pb-4"">
        <div class=""card"">
            <svg ");
            WriteLiteral(@"class=""bd-placeholder-img card-img-top"" width=""100%"" height=""180"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Image cap"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#868e96""></rect><text x=""50%"" y=""50%"" fill=""#dee2e6"" dy="".3em"">Image cap</text></svg>
            <div class=""card-body"">
                <h5 class=""card-title"">Produto</h5>
                <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                <p>R$ 30,00</p>
                <a href=""#"" class=""btn btn-primary"">Ver mais</a>
            </div>
        </div>
    </div>
    <div class=""col-12 col-md-6 col-xxl-4 pb-4"">
        <div class=""card"">
            <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""180"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Image cap"" preserveAspectRatio=""xMidYMid slice"" focusable=""fals");
            WriteLiteral(@"e""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#868e96""></rect><text x=""50%"" y=""50%"" fill=""#dee2e6"" dy="".3em"">Image cap</text></svg>
            <div class=""card-body"">
                <h5 class=""card-title"">Produto</h5>
                <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                <p>R$ 30,00</p>
                <a href=""#"" class=""btn btn-primary"">Ver mais</a>
            </div>
        </div>
    </div>
</div>
<section class=""pb-4"">
    <h2 class=""text-center"">Conheça todas as nossas facilidades</h2>
    <div class=""d-flex flex-column flex-lg-row align-items-center justify-content-center gap-3 px-3"">
        <div class=""divs-facilidades d-flex align-items-center"">
            <div><i class=""bi bi-x-diamond fs-1""></i></div>
            <div>
                <div class=""ms-3"">PAGUE PELO PIX</div>
                <div class=""texto-menor ms-3"">Ganhe 5% OFF em pagamentos via PIX</div>
");
            WriteLiteral(@"            </div>
        </div>
        <div class=""divs-facilidades d-flex align-items-center"">
            <div><i class=""bi bi-arrow-repeat fs-1""></i></div>
            <div>
                <div class=""ms-3"">TROCA GRÁTIS</div>
                <div class=""texto-menor ms-3"">Fique livre para trocar em até 30 dias.</div>
            </div>
        </div>
        <div class=""divs-facilidades d-flex align-items-center"">
            <div><i class=""bi bi-flower1 fs-1""></i></div>
            <div>
                <div class=""ms-3"">SUSTENTABILIDADE</div>
                <div class=""texto-menor ms-3"">Moda responsável, que respeita o meio ambiente.</div>
            </div>
        </div>
    </div>
</section>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41c7feb24164ee810cd8100b78a9c89871147edf16694", async() => {
                WriteLiteral(@"
    <h5 class=""text-center"">Quer receber nossas novidades, promoções exclusivas e 10% OFF na primeira compra? Cadastre-se!</h5>
    <div class=""input-group my-3"">
        <input type=""email"" class=""form-control border-secondary rounded-0"" placeholder=""Digite seu e-mail"" aria-label=""Digite seu e-mail"" aria-describedby=""button-addon2"" />
        <button type=""button"" id=""button-addon2"">Enviar</button>
    </div>
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
