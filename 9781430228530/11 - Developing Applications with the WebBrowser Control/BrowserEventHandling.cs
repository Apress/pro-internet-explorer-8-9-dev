using System.Diagnostics;
using AxSHDocVw;

namespace WebBrowserSample
{
    public class BrowserEventHandling : BrowserBasic
    {
        public BrowserEventHandling()
            : base()
        {
            // Latch onto the DWebBrowserEvents2 events omitted by the
            // web browser control
            HandleBasicEvents();
        }

        private void HandleBasicEvents()
        {
            // Add handlers to some of the basic web browser events
            Browser.BeforeNavigate2 += Browser_BeforeNavigate2;
            Browser.DocumentComplete += Browser_DocumentComplete;
            Browser.FileDownload += Browser_FileDownload;
            Browser.NavigateComplete2 += Browser_NavigateComplete2;
            Browser.NavigateError += Browser_NavigateError;
            Browser.NewProcess += Browser_NewProcess;
            Browser.NewWindow2 += Browser_NewWindow2;
            Browser.ThirdPartyUrlBlocked += Browser_ThirdPartyUrlBlocked;
        }

        #region DWebBrowserEvents2 Event Handlers

        void Browser_ThirdPartyUrlBlocked(object sender, DWebBrowserEvents2_ThirdPartyUrlBlockedEvent e)
        {
            Debug.WriteLine("Event: DWebBrowserEvents2 ThirdPartyUrlBlocked");
        }

        void Browser_NewWindow2(object sender, DWebBrowserEvents2_NewWindow2Event e)
        {
            Debug.WriteLine("Event: DWebBrowserEvents2 NewWindow2");
        }

        void Browser_NewProcess(object sender, DWebBrowserEvents2_NewProcessEvent e)
        {
            Debug.WriteLine("Event: DWebBrowserEvents2 NewProcess");
        }

        void Browser_NavigateError(object sender, AxSHDocVw.DWebBrowserEvents2_NavigateErrorEvent e)
        {
            Debug.WriteLine("Event: DWebBrowserEvents2 NavigateError");
        }

        void Browser_NavigateComplete2(object sender, AxSHDocVw.DWebBrowserEvents2_NavigateComplete2Event e)
        {
            Debug.WriteLine("Event: DWebBrowserEvents2 NavigateComplete2(");
        }

        void Browser_FileDownload(object sender, AxSHDocVw.DWebBrowserEvents2_FileDownloadEvent e)
        {
            Debug.WriteLine("Event: DWebBrowserEvents2 FileDownload");
        }

        void Browser_DocumentComplete(object sender, AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEvent e)
        {
            Debug.WriteLine("Event: DWebBrowserEvents2 DocumentComplete");
        }

        void Browser_BeforeNavigate2(object sender, AxSHDocVw.DWebBrowserEvents2_BeforeNavigate2Event e)
        {
            Debug.WriteLine("Event: DWebBrowserEvents2 BeforeNavigate2");
        }

        #endregion DWebBrowserEvents2 Event Handlers
    }
}