#pragma checksum "C:\Users\colin\source\repos\devQuiz\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb18f50501b32e42f17f782d3fda8f350361740b"
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
#line 1 "C:\Users\colin\source\repos\devQuiz\Views\_ViewImports.cshtml"
using SuperHeroSpeedNetworking;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb18f50501b32e42f17f782d3fda8f350361740b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"445dc3196d0eab10adf7c93e795ad44f70880a9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Hero", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Villian", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmhro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\colin\source\repos\devQuiz\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div id=""event-container"" style=""margin-bottom:15px;"">
    <h4 class=""event-name"">Event Name</h4>
    <span class=""event-date""></span> • <span class=""event-hero-count""></span> • <span class=""event-timeslot-count""></span>
</div>
<ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
    <li class=""nav-item"">
        <a class=""nav-link active"" id=""heroes-tab"" data-toggle=""tab"" href=""#heroes"" role=""tab"" aria-controls=""home"" aria-selected=""true"">Heroes</a>
    </li>
    <li class=""nav-item"">
        <a class=""nav-link"" id=""meetings-tab"" data-toggle=""tab"" href=""#meetings"" role=""tab"" aria-controls=""meetings"" aria-selected=""false"">Meetings</a>
    </li>
</ul>
<div class=""tab-content"" id=""myTabContent"">
    <div class=""tab-pane fade show active"" id=""heroes"" role=""tabpanel"" aria-labelledby=""heroes-tab"">
        <div style=""margin-bottom: 6px;"" class=""clearfix"">
            <button class=""btn btn-light btn-sm pull-right"" type=""button"" id=""add-hero"">
                <i class=""fa fa-user-plus""></i> Add H");
            WriteLiteral("ero\r\n            </button>\r\n        </div>\r\n\r\n        <table");
            BeginWriteAttribute("class", " class=\"", 1129, "\"", 1137, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""table-heroes"">
        </table>
    </div>
    <div class=""tab-pane fade"" id=""meetings"" role=""tabpanel"" aria-labelledby=""meetings-tab"">
        <div class=""jumbotron"" id=""no-meetings-container"">
            <h1 class=""display-4"">No Meetings Created!</h1>
            <p class=""lead"">Are you ready to generate your meetings?  </p>
            <hr class=""my-4"">
            <p>Before you do so, make sure you have an even number of heroes!</p>
            <p class=""lead"">
                <button class=""btn btn-primary btn-lg"" type=""button"" id=""match-heroes"">
                    Create Meetings
                </button>
            </p>
        </div>
        <table class=""table table-bordered table-sm sh-table"" id=""table-matches"" style=""display:none"">
            <thead>
                <tr>
                    <th>Time</th>
                    <th>Participant 1</th>
                    <th>Participant 2</th>
                    <th>Table #</th>
                </tr>
            </thead>");
            WriteLiteral(@"
            <tbody>
                <tr>
                    <td colspan=""4"">
                        <div style=""padding:15px 15px;"">
                            Add code to populate table (BONUS)
                        </div>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</div>


<div class=""modal fade"" id=""hero-form"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Hero Form</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
            </div>
            <div class=""modal-body"">
                <p>Add code to create/update hero & preferences</p>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb18f50501b32e42f17f782d3fda8f350361740b8156", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""usr""><span class=""glyphicon glyphicon-user""></span> User</label>
                        <input type=""text"" class=""form-control"" id=""usr"" placeholder=""Add new User"" required>
                    </div>
                    <div class=""form-group"">
                        <label for=""side""><span class=""glyphicon glyphicon-eye-open""></span> Side</label>
                        <select name=""drpside"" id=""drpside"" placeholder=""Select Side"" required>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb18f50501b32e42f17f782d3fda8f350361740b9004", async() => {
                    WriteLiteral("Choose...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb18f50501b32e42f17f782d3fda8f350361740b10258", async() => {
                    WriteLiteral("Hero");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb18f50501b32e42f17f782d3fda8f350361740b11508", async() => {
                    WriteLiteral("Villian");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </select>
                    </div>
                    <div class=""form-group"">
                        <label for=""side""><span class=""glyphicon glyphicon-eye-open""></span> Preferences</label>
                        <div>
                            <table id=""tblPrefs"" cellpadding=""0"" cellspacing=""0"" border=""1"">
                                <thead>
                                    <tr>
                                        <th class=""glyphicon glyphicon-user"">Hero Id</th>
                                        <th class=""glyphicon glyphicon-user"">Rank</th>
                                        <th class=""glyphicon glyphicon-user""></th>
                                    </tr>
                                </thead>
                                <tbody>
                                </tbody>
                                <tfoot>
                                    <tr>
                                        <td><input  class=""form-control"" type");
                WriteLiteral(@"=""text"" id=""heroid"" placeholder=""Add Hero Id"" required /></td>
                                        <td><input  class=""form-control"" type=""number"" id=""rnk"" placeholder=""Add Rank"" min=""1"" max=""5"" required /></td>
                                        <td><input  class=""btn btn-primary btn-lg"" id=""addheroBtn"" type=""button"" value=""Add"" /></td>
                                    </tr>
                                </tfoot>
                            </table>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""submit"" class=""btn btn-primary"" id=""submitBtn"">Save</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n\r\n");
                WriteLiteral("    <script type=\"text/javascript\">\r\n        $(function() {\r\n            var url = \'");
#nullable restore
#line 128 "C:\Users\colin\source\repos\devQuiz\Views\Home\Index.cshtml"
                  Write(Url.Action("Get", "Events"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n            var id = \'");
#nullable restore
#line 129 "C:\Users\colin\source\repos\devQuiz\Views\Home\Index.cshtml"
                 Write(Model);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';

            function getEvent(eventId) {
                var query = {
                    url: url,
                    cache: true,
                    async: true,
                    type: 'GET',
                    parameters: { id: eventId },
                    callback: function (event) {
                        showEvent(event);
                    }
                }
                Sh.Ajax.execute(query);
            }

            getEvent(id);

            function showEvent(event) {
                showEventDetails(event);
                showEventHeroes(event);
                showEventMeetings(event);
            }
            function showEventMeetings(event) {
                if (!event.meetings || event.meetings.length === 0) {
                    $('#no-meetings-container').show();
                    $('#table-matches').hide();
                } else {
                    $('#no-meetings-container').hide();
                    $('#table-matches').show();
");
                WriteLiteral(@"
                    // INSERT CODE TO SHOW MEETINGS
                }
            }
            function showEventDetails(event) {
                var $eventContainer = $('#event-container');
                $eventContainer.find('.event-name').html(event.name);
                $eventContainer.find('.event-hero-count').html(event.heroes.length  + ' heroes');
                $eventContainer.find('.event-timeslot-count').html(event.numberOfTimeslots + ' timeslots');
                //utc date
                var date = new Date(event.startUtc);
                let options = { weekday: 'short', year: 'numeric', month: 'short', day: 'numeric', hour: 'numeric', minute: 'numeric', timeZone: 'America/Los_Angeles', timeZoneName: 'short'};

                console.log('TIME ZONE ', new Intl.DateTimeFormat('en-US', options).format(date).replace(/,/g, ''));

                $eventContainer.find('.event-date').html(new Intl.DateTimeFormat('en-US', options).format(date).replace(/,/g, ''));
               /");
                WriteLiteral(@"/ $eventContainer.find('.event-date').html(psdt.toDateString() + ' ' + psdt.toLocaleTimeString() + ' ' + zone );
            }
            function showEventHeroes(event) {
                var options = {
                    people: event.heroes
                };

                var heroTable = $('#table-heroes').heroTable(options).bind('herotable:deleted', function (e, hero) {

                    })
                    .bind('herotable:edit', function (e, hero) {
                        showHeroForm(hero);
                    }).validate(
                        {
                            rules: {
                                Preferences: {
                                    required: true,
                                    min: 1
                                }
                            },
                            messages: {
                                name: {
                                    required: ""User did not select any preferences"",
                 ");
                WriteLiteral(@"                   min: jQuery.validator.format(""User did not select any preferences"")
                                }
                            }
                        });

                //$('#table-heroes').validate(
                //    {
                //        rules: {
                //            Preferences: {
                //                required: true,
                //                min: 1
                //            }
                //        },
                //        messages: {
                //            name: {
                //                required: ""User did not select any preferences"",
                //                min: ""User did not select any preferences"" //jQuery.validator.format(""User did not select any preferences"")
                //            }
                //        }
                //    });
            }
            function showHeroForm(hero) {
                $('#hero-form').modal({ backdrop: 'static' });
            ");
                WriteLiteral(@"    if (hero) {
                    $('#hero-form').find('.modal-title').html('Edit Hero Registration: ' + hero.name);
                } else {
                    $('#hero-form').find('.modal-title').html('Add Hero');
                }
            }

            // bind events
            $('#add-hero').click(function () {
                showHeroForm();
            });
            $('#match-heroes').click(function () {
                createMeetings(function (event) {
                    showEventMeetings(event);
                });
            });
            var count = 0;
            $(document).on('click', '#addheroBtn', function () {
                
                if (count < 5) {
                    Add();

                }
                count = count + 1;
              
            });
            //$(document).on('click', '#submitBtn', function () {
            //    alert('out');
            //    //var x = document.getElementById(""frmhro"");
            //    //var");
                WriteLiteral(@" txt = """";
            //    //var i;
            //    //for (i = 0; i < x.length; i++) {
            //    //    txt = txt + x.elements[i].value + ""<br>"";
            //    //}
            //    $('frmhro').serializeArray();
            //    alert(txt);
            //});
            $('#frmhro').validate({

                messages: {
                    drpside: {
                        required: ""Please select an option from the list, you cannot select 'Choose...'"",
                    },
                }
            });
            //jQuery.validator.setDefaults({
            //    debug: true,
            //    success: ""valid""
            //});
            //$('#frmhro').validate({
            //    rules: {
            //        rnk: {
            //            required: true,
            //            range: [0, 5]
            //        }
            //    }
            //});
            function createMeetings(callback) {
                alert(""Add code to create meet");
                WriteLiteral(@"ings based of a hero's preferences..."");
                // add code to create meetings
                // trigger callback to populate meetings onto the form
                // callback(updatedEvent);
            }

            function Add() {
                AddRow($(""#heroid"").val(), $(""#rnk"").val());
                $(""#heroid"").val("""");
                $(""#rnk"").val("""");
            };

           function AddRow(heroid, rank) {
                //Get the reference of the Table's TBODY element.
                var tBody = $(""#tblPrefs > TBODY"")[0];

                //Add Row.
                row = tBody.insertRow(-1);

                //Add heroid cell.
                var cell = $(row.insertCell(-1));
                cell.html(heroid);

                //Add rank cell.
                cell = $(row.insertCell(-1));
                cell.html(rank);

                //Add Button cell.
               cell = $(row.insertCell(-1));
               var btnRemove = $('<input />', {
");
                WriteLiteral(@"                   type: 'button',
                   value: 'Remove',
                   on: {
                       click: function () {
                           Remove(this);
                           //alert(this.value);
                       }
                   }
               });
               cell.append(btnRemove);
            };

            function Remove(button) {

                //Determine the reference of the Row using the Button.
                var row = $(button).closest(""TR"");

                var name = $(""TD"", row).eq(0).html();
                if (confirm(""Do you want to delete: "" + name)) {

                    //Get the reference of the Table.
                    var table = $(""#tblPrefs"")[0];

                    //Delete the Table row using it's Index.
                    table.deleteRow(row[0].rowIndex);
                }
            };

        });
    </script>
");
            }
            );
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