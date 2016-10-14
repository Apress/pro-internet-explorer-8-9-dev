using System;
using System.Diagnostics;
using System.Windows.Forms;
using AxSHDocVw;
using MSHTML;

namespace WebBrowserSample
{
    public class BrowserModelAccess : BrowserEventHandling
    {
        //TextBox PageReport;

        public BrowserModelAccess()
            : base()
        {
            // Turn off script errors
            Browser.Silent = true;
            // Register for the NavigateComplete event for both the
            // link report and the script error handling
            Browser.NavigateComplete2 += Browser_NavigateComplete2;
        }

        void Browser_NavigateComplete2(object sender, DWebBrowserEvents2_NavigateComplete2Event e)
        {
            // Pass the valid document and window objects and build
            // a link report on the document
            BuildLinkReport();

            // Sink script errors for this window instance
            SinkScriptErrorEvents();
        }

        void SinkScriptErrorEvents()
        {
            // Grab the document object off of the Web Browser control
            IHTMLDocument2 document = (IHTMLDocument2)Browser.Document;
            if (document == null) return;

            // Grab the window object off of the document object
            HTMLWindow2 window = (HTMLWindow2)document.parentWindow;
            if (window == null) return;

            // Cast the window object to the window events interface
            HTMLWindowEvents2_Event windowEvents = (HTMLWindowEvents2_Event)window;
            if (windowEvents == null) return;

            // Attach to the error event on the window object; this
            // will be sent a notification when a script error occurs
            windowEvents.onerror += Browser_HTMLWindowEvents2_OnError;
        }

        void BuildLinkReport()
        {
            // Grab the document object off of the Web Browser control
            IHTMLDocument2 document = (IHTMLDocument2)Browser.Document;
            if (document == null) return;

            // Write the title and indicate the url
            Debug.WriteLine("\n\nLINK REPORT for " + document.url);

            // Report the page URL, filesize, and total number of links
            Debug.WriteLine("URL: " + document.url);
            Debug.WriteLine("Filesize: " + document.fileSize.ToString());
            Debug.WriteLine("Total Links: " + document.links.length.ToString());

            // Display all the links on the current page.
            foreach (IHTMLAnchorElement link in document.links)
                Debug.WriteLine("  >> href=" + link.href);
        }

        void Browser_HTMLWindowEvents2_OnError(string description, string url, int line)
        {
            // Show a custom message box that displays the javascript
            // error to the user
            MessageBox.Show(String.Format(
                "Description: {0}\n\nLine: {1}",
                description,
                line.ToString()),
                "JavaScript Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
        }

        /*void BuildPageReportInterface()
        {
            // Create a new "Page Report" box, used to store logging
            // information about the current page
            PageReport = new TextBox()
            {
                Dock = DockStyle.Right,
                Multiline = true,
                Font = new Font("Consolas", (float)10, FontStyle.Bold),
                Width = 250,
                BackColor = Color.Black,
                ForeColor = Color.White,
                ScrollBars = ScrollBars.Both,
                WordWrap = false
            };
            Controls.Add(PageReport);
        }

        void PageReportWriteLine(string line)
        {
            //  Write a new line to the report text box
            PageReport.Text += "\r\n" + line;
        }*/

    }
}