#pragma checksum "D:\Study\Demo\Test-Triangle\Source\TestTriangle.HOA.MVCWebApp\TestTriangle.Web\Views\Customer\UpdateCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c81cd7806c0976bac6e577671e5bae7a061bdce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_UpdateCustomer), @"mvc.1.0.view", @"/Views/Customer/UpdateCustomer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/UpdateCustomer.cshtml", typeof(AspNetCore.Views_Customer_UpdateCustomer))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c81cd7806c0976bac6e577671e5bae7a061bdce", @"/Views/Customer/UpdateCustomer.cshtml")]
    public class Views_Customer_UpdateCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TestTriangleHOA.Web.Models.Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 803, true);
            WriteLiteral(@"<section class=""content-header"">
    <h1>
        Customer
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <!-- Horizontal Form -->
    <div class=""box box-info"">
        <div class=""box-header with-border"">
            <h3 class=""box-title"">Update Customer</h3>
        </div>
        <!-- /.box-header -->
        <!-- form start -->
        <form class=""form-horizontal"" method=""post"" action=""/Customer/UpdateCustomer"">
            <div class=""box-body"">
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">* FirstName</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""FirstName"" placeholder=""FirstName""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 847, "\"", 871, 1);
#line 21 "D:\Study\Demo\Test-Triangle\Source\TestTriangle.HOA.MVCWebApp\TestTriangle.Web\Views\Customer\UpdateCustomer.cshtml"
WriteAttributeValue("", 855, Model.FirstName, 855, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(872, 27, true);
            WriteLiteral(">\r\n                        ");
            EndContext();
            BeginContext(900, 79, false);
#line 22 "D:\Study\Demo\Test-Triangle\Source\TestTriangle.HOA.MVCWebApp\TestTriangle.Web\Views\Customer\UpdateCustomer.cshtml"
                   Write(Html.ValidationMessageFor(m => m.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(979, 337, true);
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">LastName</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""LastName"" placeholder=""LastName""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1316, "\"", 1339, 1);
#line 28 "D:\Study\Demo\Test-Triangle\Source\TestTriangle.HOA.MVCWebApp\TestTriangle.Web\Views\Customer\UpdateCustomer.cshtml"
WriteAttributeValue("", 1324, Model.LastName, 1324, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1340, 335, true);
            WriteLiteral(@">
                    </div>
                </div>
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Address</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""Address"" placeholder=""Address""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1675, "\"", 1697, 1);
#line 34 "D:\Study\Demo\Test-Triangle\Source\TestTriangle.HOA.MVCWebApp\TestTriangle.Web\Views\Customer\UpdateCustomer.cshtml"
WriteAttributeValue("", 1683, Model.Address, 1683, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1698, 326, true);
            WriteLiteral(@">
                    </div>
                </div>
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">City</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""City"" placeholder=""City""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2024, "\"", 2043, 1);
#line 40 "D:\Study\Demo\Test-Triangle\Source\TestTriangle.HOA.MVCWebApp\TestTriangle.Web\Views\Customer\UpdateCustomer.cshtml"
WriteAttributeValue("", 2032, Model.City, 2032, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2044, 329, true);
            WriteLiteral(@">
                    </div>
                </div>
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">State</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""State"" placeholder=""State""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2373, "\"", 2393, 1);
#line 46 "D:\Study\Demo\Test-Triangle\Source\TestTriangle.HOA.MVCWebApp\TestTriangle.Web\Views\Customer\UpdateCustomer.cshtml"
WriteAttributeValue("", 2381, Model.State, 2381, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2394, 237, true);
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"inputEmail3\" class=\"col-sm-2 control-label\">* Country</label>\r\n                    <div class=\"col-sm-10\">\r\n");
            EndContext();
            BeginContext(2761, 18426, true);
            WriteLiteral(@"                        <select id=""country"" name=""country"" class=""form-control"" required>
                            <option value=""Afganistan"">Afghanistan</option>
                            <option value=""Albania"">Albania</option>
                            <option value=""Algeria"">Algeria</option>
                            <option value=""American Samoa"">American Samoa</option>
                            <option value=""Andorra"">Andorra</option>
                            <option value=""Angola"">Angola</option>
                            <option value=""Anguilla"">Anguilla</option>
                            <option value=""Antigua & Barbuda"">Antigua & Barbuda</option>
                            <option value=""Argentina"">Argentina</option>
                            <option value=""Armenia"">Armenia</option>
                            <option value=""Aruba"">Aruba</option>
                            <option value=""Australia"">Australia</option>
                            <option value=""Aust");
            WriteLiteral(@"ria"">Austria</option>
                            <option value=""Azerbaijan"">Azerbaijan</option>
                            <option value=""Bahamas"">Bahamas</option>
                            <option value=""Bahrain"">Bahrain</option>
                            <option value=""Bangladesh"">Bangladesh</option>
                            <option value=""Barbados"">Barbados</option>
                            <option value=""Belarus"">Belarus</option>
                            <option value=""Belgium"">Belgium</option>
                            <option value=""Belize"">Belize</option>
                            <option value=""Benin"">Benin</option>
                            <option value=""Bermuda"">Bermuda</option>
                            <option value=""Bhutan"">Bhutan</option>
                            <option value=""Bolivia"">Bolivia</option>
                            <option value=""Bonaire"">Bonaire</option>
                            <option value=""Bosnia & Herzegovina"">Bosnia & Herzegovina");
            WriteLiteral(@"</option>
                            <option value=""Botswana"">Botswana</option>
                            <option value=""Brazil"">Brazil</option>
                            <option value=""British Indian Ocean Ter"">British Indian Ocean Ter</option>
                            <option value=""Brunei"">Brunei</option>
                            <option value=""Bulgaria"">Bulgaria</option>
                            <option value=""Burkina Faso"">Burkina Faso</option>
                            <option value=""Burundi"">Burundi</option>
                            <option value=""Cambodia"">Cambodia</option>
                            <option value=""Cameroon"">Cameroon</option>
                            <option value=""Canada"">Canada</option>
                            <option value=""Canary Islands"">Canary Islands</option>
                            <option value=""Cape Verde"">Cape Verde</option>
                            <option value=""Cayman Islands"">Cayman Islands</option>
                       ");
            WriteLiteral(@"     <option value=""Central African Republic"">Central African Republic</option>
                            <option value=""Chad"">Chad</option>
                            <option value=""Channel Islands"">Channel Islands</option>
                            <option value=""Chile"">Chile</option>
                            <option value=""China"">China</option>
                            <option value=""Christmas Island"">Christmas Island</option>
                            <option value=""Cocos Island"">Cocos Island</option>
                            <option value=""Colombia"">Colombia</option>
                            <option value=""Comoros"">Comoros</option>
                            <option value=""Congo"">Congo</option>
                            <option value=""Cook Islands"">Cook Islands</option>
                            <option value=""Costa Rica"">Costa Rica</option>
                            <option value=""Cote DIvoire"">Cote DIvoire</option>
                            <option value=""Croati");
            WriteLiteral(@"a"">Croatia</option>
                            <option value=""Cuba"">Cuba</option>
                            <option value=""Curaco"">Curacao</option>
                            <option value=""Cyprus"">Cyprus</option>
                            <option value=""Czech Republic"">Czech Republic</option>
                            <option value=""Denmark"">Denmark</option>
                            <option value=""Djibouti"">Djibouti</option>
                            <option value=""Dominica"">Dominica</option>
                            <option value=""Dominican Republic"">Dominican Republic</option>
                            <option value=""East Timor"">East Timor</option>
                            <option value=""Ecuador"">Ecuador</option>
                            <option value=""Egypt"">Egypt</option>
                            <option value=""El Salvador"">El Salvador</option>
                            <option value=""Equatorial Guinea"">Equatorial Guinea</option>
                            <opt");
            WriteLiteral(@"ion value=""Eritrea"">Eritrea</option>
                            <option value=""Estonia"">Estonia</option>
                            <option value=""Ethiopia"">Ethiopia</option>
                            <option value=""Falkland Islands"">Falkland Islands</option>
                            <option value=""Faroe Islands"">Faroe Islands</option>
                            <option value=""Fiji"">Fiji</option>
                            <option value=""Finland"">Finland</option>
                            <option value=""France"">France</option>
                            <option value=""French Guiana"">French Guiana</option>
                            <option value=""French Polynesia"">French Polynesia</option>
                            <option value=""French Southern Ter"">French Southern Ter</option>
                            <option value=""Gabon"">Gabon</option>
                            <option value=""Gambia"">Gambia</option>
                            <option value=""Georgia"">Georgia</option>
    ");
            WriteLiteral(@"                        <option value=""Germany"">Germany</option>
                            <option value=""Ghana"">Ghana</option>
                            <option value=""Gibraltar"">Gibraltar</option>
                            <option value=""Great Britain"">Great Britain</option>
                            <option value=""Greece"">Greece</option>
                            <option value=""Greenland"">Greenland</option>
                            <option value=""Grenada"">Grenada</option>
                            <option value=""Guadeloupe"">Guadeloupe</option>
                            <option value=""Guam"">Guam</option>
                            <option value=""Guatemala"">Guatemala</option>
                            <option value=""Guinea"">Guinea</option>
                            <option value=""Guyana"">Guyana</option>
                            <option value=""Haiti"">Haiti</option>
                            <option value=""Hawaii"">Hawaii</option>
                            <option valu");
            WriteLiteral(@"e=""Honduras"">Honduras</option>
                            <option value=""Hong Kong"">Hong Kong</option>
                            <option value=""Hungary"">Hungary</option>
                            <option value=""Iceland"">Iceland</option>
                            <option value=""Indonesia"">Indonesia</option>
                            <option value=""India"">India</option>
                            <option value=""Iran"">Iran</option>
                            <option value=""Iraq"">Iraq</option>
                            <option value=""Ireland"">Ireland</option>
                            <option value=""Isle of Man"">Isle of Man</option>
                            <option value=""Israel"">Israel</option>
                            <option value=""Italy"">Italy</option>
                            <option value=""Jamaica"">Jamaica</option>
                            <option value=""Japan"">Japan</option>
                            <option value=""Jordan"">Jordan</option>
                        ");
            WriteLiteral(@"    <option value=""Kazakhstan"">Kazakhstan</option>
                            <option value=""Kenya"">Kenya</option>
                            <option value=""Kiribati"">Kiribati</option>
                            <option value=""Korea North"">Korea North</option>
                            <option value=""Korea Sout"">Korea South</option>
                            <option value=""Kuwait"">Kuwait</option>
                            <option value=""Kyrgyzstan"">Kyrgyzstan</option>
                            <option value=""Laos"">Laos</option>
                            <option value=""Latvia"">Latvia</option>
                            <option value=""Lebanon"">Lebanon</option>
                            <option value=""Lesotho"">Lesotho</option>
                            <option value=""Liberia"">Liberia</option>
                            <option value=""Libya"">Libya</option>
                            <option value=""Liechtenstein"">Liechtenstein</option>
                            <option value=""Li");
            WriteLiteral(@"thuania"">Lithuania</option>
                            <option value=""Luxembourg"">Luxembourg</option>
                            <option value=""Macau"">Macau</option>
                            <option value=""Macedonia"">Macedonia</option>
                            <option value=""Madagascar"">Madagascar</option>
                            <option value=""Malaysia"">Malaysia</option>
                            <option value=""Malawi"">Malawi</option>
                            <option value=""Maldives"">Maldives</option>
                            <option value=""Mali"">Mali</option>
                            <option value=""Malta"">Malta</option>
                            <option value=""Marshall Islands"">Marshall Islands</option>
                            <option value=""Martinique"">Martinique</option>
                            <option value=""Mauritania"">Mauritania</option>
                            <option value=""Mauritius"">Mauritius</option>
                            <option value=""Mayo");
            WriteLiteral(@"tte"">Mayotte</option>
                            <option value=""Mexico"">Mexico</option>
                            <option value=""Midway Islands"">Midway Islands</option>
                            <option value=""Moldova"">Moldova</option>
                            <option value=""Monaco"">Monaco</option>
                            <option value=""Mongolia"">Mongolia</option>
                            <option value=""Montserrat"">Montserrat</option>
                            <option value=""Morocco"">Morocco</option>
                            <option value=""Mozambique"">Mozambique</option>
                            <option value=""Myanmar"">Myanmar</option>
                            <option value=""Nambia"">Nambia</option>
                            <option value=""Nauru"">Nauru</option>
                            <option value=""Nepal"">Nepal</option>
                            <option value=""Netherland Antilles"">Netherland Antilles</option>
                            <option value=""Netherland");
            WriteLiteral(@"s"">Netherlands (Holland, Europe)</option>
                            <option value=""Nevis"">Nevis</option>
                            <option value=""New Caledonia"">New Caledonia</option>
                            <option value=""New Zealand"">New Zealand</option>
                            <option value=""Nicaragua"">Nicaragua</option>
                            <option value=""Niger"">Niger</option>
                            <option value=""Nigeria"">Nigeria</option>
                            <option value=""Niue"">Niue</option>
                            <option value=""Norfolk Island"">Norfolk Island</option>
                            <option value=""Norway"">Norway</option>
                            <option value=""Oman"">Oman</option>
                            <option value=""Pakistan"">Pakistan</option>
                            <option value=""Palau Island"">Palau Island</option>
                            <option value=""Palestine"">Palestine</option>
                            <option val");
            WriteLiteral(@"ue=""Panama"">Panama</option>
                            <option value=""Papua New Guinea"">Papua New Guinea</option>
                            <option value=""Paraguay"">Paraguay</option>
                            <option value=""Peru"">Peru</option>
                            <option value=""Phillipines"">Philippines</option>
                            <option value=""Pitcairn Island"">Pitcairn Island</option>
                            <option value=""Poland"">Poland</option>
                            <option value=""Portugal"">Portugal</option>
                            <option value=""Puerto Rico"">Puerto Rico</option>
                            <option value=""Qatar"">Qatar</option>
                            <option value=""Republic of Montenegro"">Republic of Montenegro</option>
                            <option value=""Republic of Serbia"">Republic of Serbia</option>
                            <option value=""Reunion"">Reunion</option>
                            <option value=""Romania"">Romania</");
            WriteLiteral(@"option>
                            <option value=""Russia"">Russia</option>
                            <option value=""Rwanda"">Rwanda</option>
                            <option value=""St Barthelemy"">St Barthelemy</option>
                            <option value=""St Eustatius"">St Eustatius</option>
                            <option value=""St Helena"">St Helena</option>
                            <option value=""St Kitts-Nevis"">St Kitts-Nevis</option>
                            <option value=""St Lucia"">St Lucia</option>
                            <option value=""St Maarten"">St Maarten</option>
                            <option value=""St Pierre & Miquelon"">St Pierre & Miquelon</option>
                            <option value=""St Vincent & Grenadines"">St Vincent & Grenadines</option>
                            <option value=""Saipan"">Saipan</option>
                            <option value=""Samoa"">Samoa</option>
                            <option value=""Samoa American"">Samoa American</opti");
            WriteLiteral(@"on>
                            <option value=""San Marino"">San Marino</option>
                            <option value=""Sao Tome & Principe"">Sao Tome & Principe</option>
                            <option value=""Saudi Arabia"">Saudi Arabia</option>
                            <option value=""Senegal"">Senegal</option>
                            <option value=""Seychelles"">Seychelles</option>
                            <option value=""Sierra Leone"">Sierra Leone</option>
                            <option value=""Singapore"">Singapore</option>
                            <option value=""Slovakia"">Slovakia</option>
                            <option value=""Slovenia"">Slovenia</option>
                            <option value=""Solomon Islands"">Solomon Islands</option>
                            <option value=""Somalia"">Somalia</option>
                            <option value=""South Africa"">South Africa</option>
                            <option value=""Spain"">Spain</option>
                       ");
            WriteLiteral(@"     <option value=""Sri Lanka"">Sri Lanka</option>
                            <option value=""Sudan"">Sudan</option>
                            <option value=""Suriname"">Suriname</option>
                            <option value=""Swaziland"">Swaziland</option>
                            <option value=""Sweden"">Sweden</option>
                            <option value=""Switzerland"">Switzerland</option>
                            <option value=""Syria"">Syria</option>
                            <option value=""Tahiti"">Tahiti</option>
                            <option value=""Taiwan"">Taiwan</option>
                            <option value=""Tajikistan"">Tajikistan</option>
                            <option value=""Tanzania"">Tanzania</option>
                            <option value=""Thailand"">Thailand</option>
                            <option value=""Togo"">Togo</option>
                            <option value=""Tokelau"">Tokelau</option>
                            <option value=""Tonga"">Tonga</op");
            WriteLiteral(@"tion>
                            <option value=""Trinidad & Tobago"">Trinidad & Tobago</option>
                            <option value=""Tunisia"">Tunisia</option>
                            <option value=""Turkey"">Turkey</option>
                            <option value=""Turkmenistan"">Turkmenistan</option>
                            <option value=""Turks & Caicos Is"">Turks & Caicos Is</option>
                            <option value=""Tuvalu"">Tuvalu</option>
                            <option value=""Uganda"">Uganda</option>
                            <option value=""United Kingdom"">United Kingdom</option>
                            <option value=""Ukraine"">Ukraine</option>
                            <option value=""United Arab Erimates"">United Arab Emirates</option>
                            <option value=""United States of America"">United States of America</option>
                            <option value=""Uraguay"">Uruguay</option>
                            <option value=""Uzbekistan"">Uzbe");
            WriteLiteral(@"kistan</option>
                            <option value=""Vanuatu"">Vanuatu</option>
                            <option value=""Vatican City State"">Vatican City State</option>
                            <option value=""Venezuela"">Venezuela</option>
                            <option value=""Vietnam"">Vietnam</option>
                            <option value=""Virgin Islands (Brit)"">Virgin Islands (Brit)</option>
                            <option value=""Virgin Islands (USA)"">Virgin Islands (USA)</option>
                            <option value=""Wake Island"">Wake Island</option>
                            <option value=""Wallis & Futana Is"">Wallis & Futana Is</option>
                            <option value=""Yemen"">Yemen</option>
                            <option value=""Zaire"">Zaire</option>
                            <option value=""Zambia"">Zambia</option>
                            <option value=""Zimbabwe"">Zimbabwe</option>
                        </select>
                        ");
            EndContext();
            BeginContext(21188, 77, false);
#line 301 "D:\Study\Demo\Test-Triangle\Source\TestTriangle.HOA.MVCWebApp\TestTriangle.Web\Views\Customer\UpdateCustomer.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Country, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(21265, 328, true);
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Phone</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""Phone"" placeholder=""Phone""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 21593, "\"", 21613, 1);
#line 307 "D:\Study\Demo\Test-Triangle\Source\TestTriangle.HOA.MVCWebApp\TestTriangle.Web\Views\Customer\UpdateCustomer.cshtml"
WriteAttributeValue("", 21601, Model.Phone, 21601, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(21614, 109, true);
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <input type=\"hidden\" name=\"CustomerId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 21723, "\"", 21748, 1);
#line 310 "D:\Study\Demo\Test-Triangle\Source\TestTriangle.HOA.MVCWebApp\TestTriangle.Web\Views\Customer\UpdateCustomer.cshtml"
WriteAttributeValue("", 21731, Model.CustomerId, 21731, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(21749, 491, true);
            WriteLiteral(@" />
            </div>
            <!-- /.box-body -->
            <div class=""box-footer"">
                <a class=""btn btn-default"" href=""/Customer"">Cancel</a>
                <button type=""submit"" class=""btn btn-info pull-right"">Update</button>
            </div>
            <!-- /.box-footer -->
        </form>
    </div>
    <!-- /.box -->
</section>
<script type=""text/javascript"">
    window.onload = function () {
        document.getElementById(""country"").value = '");
            EndContext();
            BeginContext(22241, 13, false);
#line 324 "D:\Study\Demo\Test-Triangle\Source\TestTriangle.HOA.MVCWebApp\TestTriangle.Web\Views\Customer\UpdateCustomer.cshtml"
                                               Write(Model.Country);

#line default
#line hidden
            EndContext();
            BeginContext(22254, 20, true);
            WriteLiteral("\';\r\n    }\r\n</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestTriangleHOA.Web.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591