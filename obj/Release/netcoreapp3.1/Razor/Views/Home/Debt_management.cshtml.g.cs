#pragma checksum "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Debt_management.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14f33a390227bbcbf81fdd16e864f50bec6ea6db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Debt_management), @"mvc.1.0.view", @"/Views/Home/Debt_management.cshtml")]
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
#line 1 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\_ViewImports.cshtml"
using SHOP_DECOMPILED;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\_ViewImports.cshtml"
using SHOP_DECOMPILED.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14f33a390227bbcbf81fdd16e864f50bec6ea6db", @"/Views/Home/Debt_management.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff92a7f7e8cb6131c6c835eb6e87017751546d98", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Debt_management : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div style=""text-align:center"">
    <h1>Print ESP/POS commands from Javascript</h1>
    <hr />
    <label class=""checkbox"">
        <input type=""checkbox"" id=""useDefaultPrinter"" /> <strong>Print to Default printer</strong>
    </label>
    <p>or...</p>
    <div id=""installedPrinters"">
        <label for=""installedPrinterName"">Select an installed Printer:</label>
        <select name=""installedPrinterName"" id=""installedPrinterName""></select>
    </div>
    <br /><br />
    <button type=""button"" onclick=""print();"">Print Now...</button>
</div>
");
            DefineSection("increment", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">

        //WebSocket settings
        JSPM.JSPrintManager.auto_reconnect = true;
        JSPM.JSPrintManager.start();
        JSPM.JSPrintManager.WS.onStatusChanged = function () {
            if (jspmWSStatus()) {
                //get client installed printers
                JSPM.JSPrintManager.getPrinters().then(function (myPrinters) {
                    var options = '';
                    for (var i = 0; i < myPrinters.length; i++) {
                        options += '<option>' + myPrinters[i] + '</option>';
                    }
                    $('#installedPrinterName').html(options);
                });
            }
        };

        //Check JSPM WebSocket status
        function jspmWSStatus() {
            if (JSPM.JSPrintManager.websocket_status == JSPM.WSStatus.Open)
                return true;
            else if (JSPM.JSPrintManager.websocket_status == JSPM.WSStatus.Closed) {
                alert('JSPrintManager (JSPM) is not installed or not run");
                WriteLiteral(@"ning! Download JSPM Client App from https://neodynamic.com/downloads/jspm');
                return false;
            }
            else if (JSPM.JSPrintManager.websocket_status == JSPM.WSStatus.Blocked) {
                alert('JSPM has blocked this website!');
                return false;
            }
        }

        //Do printing...
        function print(o) {
            if (jspmWSStatus()) {
                //Create a ClientPrintJob
                var cpj = new JSPM.ClientPrintJob();
                //Set Printer type (Refer to the help, there many of them!)
                if ($('#useDefaultPrinter').prop('checked')) {
                    cpj.clientPrinter = new JSPM.DefaultPrinter();
                } else {
                    cpj.clientPrinter = new JSPM.InstalledPrinter($('#installedPrinterName').val());
                }
                //Set content to print...
                //Create ESP/POS commands for sample label
                var esc = '\x1B'; //ESC byte in hex notation
           ");
                WriteLiteral("     var newLine = \'\\x0A\'; //LF byte in hex notation\n\n                var cmds = esc + \"");
                WriteLiteral("@\"; //Initializes the printer (ESC ");
                WriteLiteral(@"@)
                cmds += esc + '!' + '\x38'; //Emphasized + Double-height + Double-width mode selected (ESC ! (8 + 16 + 32)) 56 dec => 38 hex
                cmds += 'DESTINY BAR';
                cmds += newLine + newLine;
                cmds += esc + '!' + '\x00';
                cmds += 'COOKIES                   5.00';
                cmds += newLine;
                cmds += 'MILK 65 Fl oz             3.78';
                cmds += newLine + newLine;
                cmds += 'SUBTOTAL                  8.78';
                cmds += newLine;
                cmds += 'TAX 5%                    0.44';
                cmds += newLine;
                cmds += 'TOTAL                     9.22';
                cmds += newLine;
                cmds += 'CASH TEND                10.00';
                cmds += newLine;
                cmds += 'CASH DUE                  0.78';
                cmds += newLine + newLine;
                cmds += esc + '!' + '\x18'; //Emphasized + Double-height mode selected (ESC ! (16");
                WriteLiteral(@" + 8)) 24 dec => 18 hex
                cmds += '# ITEMS SOLD 2';
                cmds += esc + '!' + '\x00'; //Character font A selected (ESC ! 0)
                cmds += newLine + newLine;
                cmds += '11/03/13  19:53:17';
                cmds += newLine;
                cmds += newLine;
                cmds += newLine;

                cmds += newLine;
                cmds += newLine;
                cmds += newLine;
                cmds += newLine;
                cmds += newLine;
                cmds += newLine;
                cmds += newLine;
                cmds += newLine;
                cmds += newLine;
                cmds += newLine;
                cmds += newLine;
                cmds += newLine;
                cmds += newLine;


                cmds += '");
                WriteLiteral("@\';\n                cmds += \'V\';\n                //             string GS = Convert.ToString((char)29);\n                // string ESC = Convert.ToString((char)27);\n                // string COMMAND = \"\";\n                // COMMAND = ESC + \"");
                WriteLiteral("@\";\n                // COMMAND += GS + \"V\" + (char)48;\n\n                cpj.printerCommands = cmds;\n                //Send print job to printer!\n                cpj.sendToClient();\n            }\n        };\n    </script>\n");
            }
            );
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
