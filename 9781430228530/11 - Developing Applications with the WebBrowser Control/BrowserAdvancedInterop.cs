using System.Drawing;
using System.Windows.Forms;

namespace WebBrowserSample
{
    public class BrowserAdvancedInterop : BrowserModelAccess
    {

        Label TrueDomain;

        public BrowserAdvancedInterop()
            : base()
        {

            TrueDomain = new Label()
            {
                Text = "Current Domain: (none)",
                BackColor = Color.CadetBlue,
                ForeColor = Color.White,
                Font = new Font("Consolas", (float)16, FontStyle.Bold)
            };
            Controls.Add(TrueDomain);

            TrueDomain.Parent = BrowserContainer;
            TrueDomain.Dock = DockStyle.Top;

            Browser.DocumentComplete += Browser_DocumentComplete;

        }

        void Browser_DocumentComplete(object sender, AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEvent e)
        {
            CalculateCurrentDomain();
        }

        void CalculateCurrentDomain()
        {

            // Use IUri to parse the current domain into parts
            IUri uri = ParseUri.Create(Browser.LocationURL);
            string domain;
            string host;

            // Get the current domain and host values
            uri.GetDomain(out domain);
            uri.GetHost(out host);
            int domainPosition = host.LastIndexOf(domain);
            int hostPosition = Browser.LocationURL.IndexOf(host);

            if (domainPosition != -1 && domainPosition != -1)
            {
                AddressBox.Select(hostPosition + domainPosition, domain.Length);
                TrueDomain.Text = "Current Domain: " + domain;
            }
            else
            {
                TrueDomain.Text = "Current Domain: (error)";
            }
        }

    }
}