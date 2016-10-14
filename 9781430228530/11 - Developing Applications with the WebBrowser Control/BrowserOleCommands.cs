using System;
using System.Windows.Forms;

namespace WebBrowserSample
{
    public class BrowserOleCommands : BrowserModelAccess
    {

        public ToolStripItem PrintButton;

        public MenuStrip Menu;
        public ToolStripMenuItem MenuFile;
        public ToolStripMenuItem MenuEdit;
        public ToolStripMenuItem MenuView;
        public ToolStripMenuItem MenuTools;
        public ToolStripMenuItem MenuHelp;

        public ToolStripMenuItem MenuFileSaveAs;

        public BrowserOleCommands()
        {

            //
            MenuFileSaveAs = new ToolStripMenuItem("Save As...");
            MenuFileSaveAs.Click += MenuFileSaveAs_Click;

            //
            MenuFile = new ToolStripMenuItem("&File");
            MenuFile.Click += MenuFile_Click;
            MenuFile.DropDownItems.Add(MenuFileSaveAs);

            //
            MenuEdit = new ToolStripMenuItem("&Edit");
            MenuView = new ToolStripMenuItem("&View");
            MenuTools = new ToolStripMenuItem("&Tools");
            MenuHelp = new ToolStripMenuItem("&Help");

            //
            Menu = new MenuStrip();
            Menu.Items.AddRange(new ToolStripItemCollection(Menu, new ToolStripItem[] { MenuFile, MenuEdit, MenuView, MenuTools, MenuHelp }));
            Menu.Dock = DockStyle.Top;
            Controls.Add(Menu);

            // Add a "Print" button to the toolbar
            PrintButton = CommandBar.Items.Add("Print");
            PrintButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            PrintButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            PrintButton.Name = "PrintButton";
            PrintButton.Text = "Print";
            PrintButton.Click += new System.EventHandler(PrintButton_Click);

            // Refresh the command bar layout
            CommandBar.ResumeLayout(false);
            CommandBar.PerformLayout();

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