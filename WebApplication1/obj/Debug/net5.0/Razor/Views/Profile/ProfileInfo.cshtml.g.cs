#pragma checksum "D:\прога\WebApplication1\WebApplication1\Views\Profile\ProfileInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d11f284688909e2f89b431ba03634216573997c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_ProfileInfo), @"mvc.1.0.view", @"/Views/Profile/ProfileInfo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d11f284688909e2f89b431ba03634216573997c", @"/Views/Profile/ProfileInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aee0385dae4c09cbbedeaf392bb99e034a4cdc84", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Profile_ProfileInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Entity.Profile>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""card col-md-12"" style=""margin: 10px;"">
    <div class=""card-buttons-group"">
        <button class='btn btn-primary' id='addProfileCardId'>Add</button>
    </div>
</div>

<div class=""row"">
  <div class=""col-sm-6"">
    <div class=""card"">
      <div class=""card-body"">
        <h5 class=""card-title"">Profile data</h5>
        <ul class=""list-group list-group-flush"">
            <li class=""list-group-item"">");
#nullable restore
#line 15 "D:\прога\WebApplication1\WebApplication1\Views\Profile\ProfileInfo.cshtml"
                                   Write(Model?.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\">");
#nullable restore
#line 16 "D:\прога\WebApplication1\WebApplication1\Views\Profile\ProfileInfo.cshtml"
                                   Write(Model?.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
          </ul>
      </div>
    </div>
  </div>
  <div class=""col-sm-6"">
    <div class=""card"">
      <div class=""card-body"">
        <h5 class=""card-title"">---------</h5>
        <p class=""card-text"">-------------</p>
        <a href=""#"" class=""btn btn-primary"">Move</a>
      </div>
    </div>
  </div>
</div>

<div class=""modal fade"" id=""modal"" tabindex=""-1"">
  <div class=""modal-dialog"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"">Info about phones</h5>
      </div>
      <div class=""modal-body"">

      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-close btn-secondary"" data-bs-dismiss=""modal"">Close</button>
");
#nullable restore
#line 43 "D:\прога\WebApplication1\WebApplication1\Views\Profile\ProfileInfo.cshtml"
         if (User.IsInRole("Admin"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <button type=\"button\" class=\"btn btn-primary\" id=\"saveBtn\">Save</button>   \r\n");
#nullable restore
#line 46 "D:\прога\WebApplication1\WebApplication1\Views\Profile\ProfileInfo.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n\r\n");
            DefineSection("pageScripts", async() => {
                WriteLiteral(@"
 <script>
    let modal = $('#modal'); 
    
    function model() {
        const model = {
            age: $('input#Age').val(),
            address: $('input#Address').val()
        }            
        return model;
    };
    
    $('#saveBtn').on('click', function () {
       $.ajax({
           url: '");
#nullable restore
#line 67 "D:\прога\WebApplication1\WebApplication1\Views\Profile\ProfileInfo.cshtml"
            Write(Url.Action("Save"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
           type: 'POST',
           data: model(),
       }) 
    });
    
    $('#addProfileCardId').on('click', function () {
         $.ajax({
            type: 'GET',
            url : '/Profile/Save',
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Entity.Profile> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
