#pragma checksum "D:\прога\WebApplication1\WebApplication1\Views\Phone\TopPhones.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3da32827ed30caf39a13d1555bc89fbf94ba20b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Phone_TopPhones), @"mvc.1.0.view", @"/Views/Phone/TopPhones.cshtml")]
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
#line 1 "D:\прога\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3da32827ed30caf39a13d1555bc89fbf94ba20b", @"/Views/Phone/TopPhones.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aee0385dae4c09cbbedeaf392bb99e034a4cdc84", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Phone_TopPhones : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.TopPhones>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/modal.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\прога\WebApplication1\WebApplication1\Views\Phone\TopPhones.cshtml"
  
    ViewBag.Title = "Popular phones";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\прога\WebApplication1\WebApplication1\Views\Phone\TopPhones.cshtml"
  
    var cardStyle = "col-md-6";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .card-buttons-group {
        text-align: right;
        padding: 10px;
    }
</style>

<div class=""card col-md-12"" style=""margin: 10px;"">
    <div class=""card-buttons-group"">
        <button class='btn btn-primary' id='compareBtnId'>Comparing</button>
    </div>
</div>



    <div class=""row"">
");
#nullable restore
#line 28 "D:\прога\WebApplication1\WebApplication1\Views\Phone\TopPhones.cshtml"
         foreach (var phone in Model.data.phones)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 560, "\"", 605, 4);
            WriteAttributeValue("", 568, "row", 568, 3, true);
            WriteAttributeValue(" ", 571, "row-cols-1", 572, 11, true);
#nullable restore
#line 30 "D:\прога\WebApplication1\WebApplication1\Views\Phone\TopPhones.cshtml"
WriteAttributeValue(" ", 582, cardStyle, 583, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 593, "text-center", 594, 12, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                \r\n                <div class=\"col\" style=\"padding: 15px; padding-left: 60px\">\r\n                    <div class=\"card\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 772, "\"", 790, 1);
#nullable restore
#line 34 "D:\прога\WebApplication1\WebApplication1\Views\Phone\TopPhones.cshtml"
WriteAttributeValue("", 778, Model.image, 778, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top card-image\"");
            BeginWriteAttribute("alt", " alt=\"", 823, "\"", 846, 1);
#nullable restore
#line 34 "D:\прога\WebApplication1\WebApplication1\Views\Phone\TopPhones.cshtml"
WriteAttributeValue("", 829, phone.phone_name, 829, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">Name: ");
#nullable restore
#line 36 "D:\прога\WebApplication1\WebApplication1\Views\Phone\TopPhones.cshtml"
                                                    Write(phone.phone_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\">Model: ");
#nullable restore
#line 37 "D:\прога\WebApplication1\WebApplication1\Views\Phone\TopPhones.cshtml"
                                                   Write(phone.slug.Substring(0, @phone.slug.IndexOf('-')));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <ul class=\"list-group list-group-flush\">\r\n                            <li class=\"list-group-item\">Views: ");
#nullable restore
#line 40 "D:\прога\WebApplication1\WebApplication1\Views\Phone\TopPhones.cshtml"
                                                          Write(phone.hits);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                            <li class=\"list-group-item\">Deatails: ");
#nullable restore
#line 41 "D:\прога\WebApplication1\WebApplication1\Views\Phone\TopPhones.cshtml"
                                                             Write(phone.detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        </ul>\r\n                        <div class=\"card-body\">\r\n                            <button class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1497, "\"", 1565, 8);
            WriteAttributeValue("", 1507, "openModal({", 1507, 11, true);
            WriteAttributeValue(" ", 1518, "url:", 1519, 5, true);
            WriteAttributeValue(" ", 1523, "\'/Phone/GetPhone\',", 1524, 19, true);
            WriteAttributeValue(" ", 1542, "data:", 1543, 6, true);
            WriteAttributeValue(" ", 1548, "\'", 1549, 2, true);
#nullable restore
#line 44 "D:\прога\WebApplication1\WebApplication1\Views\Phone\TopPhones.cshtml"
WriteAttributeValue("", 1550, phone.slug, 1550, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1561, "\'", 1561, 1, true);
            WriteAttributeValue(" ", 1562, "})", 1563, 3, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                                    data-toggle=\"ajax-modal\" data-target=\"Modal\">Open</button>\r\n                                \r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 51 "D:\прога\WebApplication1\WebApplication1\Views\Phone\TopPhones.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>   \r\n\r\n");
            DefineSection("pageScripts", async() => {
                WriteLiteral("\r\n    \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3da32827ed30caf39a13d1555bc89fbf94ba20b8969", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
       let modal = $('#modal'); 
    
       function model() { 
            return {
                name: $('input#Name').val(),
                model: $('input#Model').val(),
                price: $('input#Price').val(),
                description: $('input#Description').val(),
                avatar: $('input#Avatar').val(),
            }
        };
        
        function like(phone) {
            $.ajax({
                url: '");
#nullable restore
#line 72 "D:\прога\WebApplication1\WebApplication1\Views\Phone\TopPhones.cshtml"
                 Write(Url.Action("LikeDevice"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                type: \'Post\',\r\n                data: phone,\r\n            });\r\n        } \r\n       \r\n       $(\'#saveBtn\').on(\'click\', function () {\r\n           $.ajax({\r\n               url: \'");
#nullable restore
#line 80 "D:\прога\WebApplication1\WebApplication1\Views\Phone\TopPhones.cshtml"
                Write(Url.Action("Save"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n               type: \'POST\',\r\n               data: model(),\r\n           }) \r\n        });\r\n        \r\n       $(\'#compareBtnId\').on(\'click\', function (){\r\n           $.ajax({\r\n               type: \'GET\',\r\n               url : \'");
#nullable restore
#line 89 "D:\прога\WebApplication1\WebApplication1\Views\Phone\TopPhones.cshtml"
                 Write(Url.Action("Compare"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
               success: function (response) {
                   $('.modal-dialog').addClass(""modal-lg"");
                   modal.find("".modal-body"").html(response);
                   modal.modal('show')
               }
           });
       });
        
       $("".btn-close"").click(function(){
            modal.modal('hide');
       });
       
       $('#addCarId').on('click', function () {
           $.ajax({
              type: 'GET',
              url : '/Car/Save',
              success: function (response) {
                  $('.modal-dialog').removeClass(""modal-lg"");
                  modal.find("".modal-body"").html(response);
                  modal.modal('show')
              },
              failure: function () {
                modal.modal('hide')
              },
              error: function (response) {
                  alert(response.responseText);
              }
          });
       });
       
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.TopPhones> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
