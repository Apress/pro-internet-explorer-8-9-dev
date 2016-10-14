using System;
using System.Drawing;
using System.Windows.Forms;
using AxSHDocVw;

namespace WebBrowserSample
{
    public class BrowserIntegration : BrowserModelAccess
    {
        public BrowserIntegration()
            : base()
        {
            // Add menu and command features
            BuildMenuAndCommands();
            // Integrate UI with IE notifications
            BuildInterfaceIntegration();
            // Integrate with the NewWindow event
            BuildWindowIntegration();
        }

        public MenuStrip Menu;
        public ToolStripMenuItem MenuFile;
        public ToolStripMenuItem MenuEdit;
        public ToolStripMenuItem MenuView;
        public ToolStripMenuItem MenuTools;
        public ToolStripMenuItem MenuHelp;
        public ToolStripMenuItem MenuFileSaveAs;
        public ToolStripItem PrintButton;

        private void BuildMenuAndCommands()
        {

            // Create the File > Save As menu item
            MenuFileSaveAs = new ToolStripMenuItem("Save As...");
            MenuFileSaveAs.Click += MenuFileSaveAs_Click;

            // Create the file menu and add children
            MenuFile = new ToolStripMenuItem("&File");
            MenuFile.Click += MenuFile_Click;
            MenuFile.DropDownItems.Add(MenuFileSaveAs);

            // Create placeholder top-level menus
            MenuEdit = new ToolStripMenuItem("&Edit");
            MenuView = new ToolStripMenuItem("&View");
            MenuTools = new ToolStripMenuItem("&Tools");
            MenuHelp = new ToolStripMenuItem("&Help");

            // Create a new main menu strip and add all the items to it
            Menu = new MenuStrip();
            Menu.Items.AddRange(new ToolStripItemCollection(
                Menu, new ToolStripItem[] { MenuFile, MenuEdit,
                    MenuView, MenuTools, MenuHelp }));
            Menu.Dock = DockStyle.Top;
            Controls.Add(Menu);

            // Add a "Print" button to the toolbar
            PrintButton = CommandBar.Items.Add("Print");
            PrintButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            PrintButton.ImageTransparentColor = Color.Magenta;
            PrintButton.Name = "PrintButton";
            PrintButton.Text = "Print";
            PrintButton.Click += new System.EventHandler(PrintButton_Click);

            // Refresh the command bar layout
            CommandBar.ResumeLayout(false);
            CommandBar.PerformLayout();

        }

        private void BuildWindowIntegration()
        {
            // Register as a target browser
            Browser.RegisterAsBrowser = true;

            // Sink the NewWindow2 event
            Browser.NewWindow2 += Browser_NewWindow2;
        }

        private void BuildInterfaceIntegration()
        {
            // Place an initial title on the window
            Text = "New Window - Custom Web Browser";

            // Sink the navigation event
            Browser.NavigateComplete2 += Browser_NavigateComplete2;
            Browser.TitleChange += Browser_TitleChange;
            Browser.StatusTextChange += Browser_StatusTextChange;
        }

        void Browser_StatusTextChange(object sender,
            DWebBrowserEvents2_StatusTextChangeEvent e)
        {
            // Change the status text to the text emitted by IE
            BrowserStatusText.Text = e.text;
        }

        void Browser_TitleChange(object sender,
            DWebBrowserEvents2_TitleChangeEvent e)
        {
            // Set window title to the page title
            this.Text = e.text + " - Custom Web Browser";
        }

        void Browser_NavigateComplete2(object sender,
            DWebBrowserEvents2_NavigateComplete2Event e)
        {
            // Set the address box text to the current URL
            AddressBox.Text = Browser.LocationURL;
        }

        void Browser_NewWindow2(object sender,
            DWebBrowserEvents2_NewWindow2Event e)
        {

            // Create a new instance of this form
            BrowserIntegration browserRegistrationForm;
            browserRegistrationForm = new BrowserIntegration();

            //browserRegistrationForm.Browser.RegisterAsBrowser = true;
            e.ppDisp = browserRegistrationForm.Browser.Application;
            browserRegistrationForm.Visible = true;

        }

        void MenuFile_Click(object sender, EventArgs e)
        {

            // Query the status of the Save As command
            SHDocVw.OLECMDF saveAsQuery =
                Browser.QueryStatusWB(SHDocVw.OLECMDID.OLECMDID_SAVEAS);

            // If the command is currently allowed (enabled), enable
            // the menu item; if not, disable it
            MenuFileSaveAs.Enabled =
                ((saveAsQuery & SHDocVw.OLECMDF.OLECMDF_ENABLED) != 0) ?
                    true : false;

        }

        void MenuFileSaveAs_Click(object sender, EventArgs e)
        {

            // Execute the Save As action and prompt the user
            // with a Save As dialog
            Browser.ExecWB(
                    SHDocVw.OLECMDID.OLECMDID_SAVEAS,
                    SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_PROMPTUSER
                    );

        }

        void PrintButton_Click(object sender, EventArgs e)
        {

            // Query the status of the print command
            SHDocVw.OLECMDF printQuery =
                Browser.QueryStatusWB(SHDocVw.OLECMDID.OLECMDID_PRINT);

            // If the command is enabled, display the print dialog
            if ((printQuery & SHDocVw.OLECMDF.OLECMDF_ENABLED) != 0)
                Browser.ExecWB(
                    SHDocVw.OLECMDID.OLECMDID_PRINT,
                    SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_PROMPTUSER
                    );

        }

    }

}