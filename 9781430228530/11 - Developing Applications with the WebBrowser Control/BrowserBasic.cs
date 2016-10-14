using System.Windows.Forms;
using AxSHDocVw;

namespace WebBrowserSample
{
    public partial class BrowserBasic : Form
    {

        public AxWebBrowser Browser;

        public BrowserBasic()
        {
            // Initialize the component (designer)
            InitializeComponent();

            // Initialize the web browser control
            InitializeWebBrowser();
        }

        #region HelperMethods

        public void InitializeWebBrowser()
        {
            // Create a new instance of the web browser control
            Browser = new AxWebBrowser();

            // Begin initializing the control
            Browser.BeginInit();

            // Add the control to the main form and dock it inside
            // of a panel
            this.Controls.Add(Browser);
            Browser.Parent = BrowserContainer;
            Browser.Dock = DockStyle.Fill;

            // Finish initializing the ActiveX
            Browser.EndInit();
        }

        #endregion HelperMethods

        #region BrowserForm Event Handlers

        private void BrowserForm_Load(object sender, System.EventArgs e)
        {
            // Go to the user's homepage on load
            Browser.GoHome();
        }

        private void BackButton_Click(object sender, System.EventArgs e)
        {
            // Go back in the travel log
            Browser.GoBack();
        }

        private void ForwardButton_Click(object sender, System.EventArgs e)
        {
            // Go forwared in the travel log
            Browser.GoForward();
        }

        private void HomeButton_Click(object sender, System.EventArgs e)
        {
            // Go to the user's homepage
            Browser.GoHome();
        }

        private void StopButton_Click(object sender, System.EventArgs e)
        {
            // Stop the current navigation
            Browser.Stop();
        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            // Launch the default search engine
            Browser.GoSearch();
        }

        #endregion BrowserForm Event Handlers

        private void GoButton_Click(object sender, System.EventArgs e)
        {
            // Navigate to the address found in the address textbox
            Browser.Navigate(AddressBox.Text);
        }

        private void AddressBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If enter was pressed, tread as if the "go" button was hit
            if (e.KeyChar == 0xD)
                Browser.Navigate(AddressBox.Text);
        }

        private void AddressBox_Click(object sender, System.EventArgs e)
        {
            // Select all text for editing
            AddressBox.SelectAll();
        }

    }

}