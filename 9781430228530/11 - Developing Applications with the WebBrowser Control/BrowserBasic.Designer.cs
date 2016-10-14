namespace WebBrowserSample
{
    partial class BrowserBasic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserBasic));
            this.CommandBar = new System.Windows.Forms.ToolStrip();
            this.AddressBox = new System.Windows.Forms.ToolStripTextBox();
            this.GoButton = new System.Windows.Forms.ToolStripButton();
            this.BackButton = new System.Windows.Forms.ToolStripButton();
            this.ForwardButton = new System.Windows.Forms.ToolStripButton();
            this.HomeButton = new System.Windows.Forms.ToolStripButton();
            this.StopButton = new System.Windows.Forms.ToolStripButton();
            this.SearchButton = new System.Windows.Forms.ToolStripButton();
            this.BrowserContainer = new System.Windows.Forms.Panel();
            this.BrowserStatusBar = new System.Windows.Forms.StatusStrip();
            this.BrowserStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.CommandBar.SuspendLayout();
            this.BrowserContainer.SuspendLayout();
            this.BrowserStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // CommandBar
            // 
            this.CommandBar.AllowItemReorder = true;
            this.CommandBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddressBox,
            this.GoButton,
            this.BackButton,
            this.ForwardButton,
            this.HomeButton,
            this.StopButton,
            this.SearchButton});
            this.CommandBar.Location = new System.Drawing.Point(0, 0);
            this.CommandBar.Name = "CommandBar";
            this.CommandBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.CommandBar.Size = new System.Drawing.Size(782, 29);
            this.CommandBar.Stretch = true;
            this.CommandBar.TabIndex = 0;
            // 
            // AddressBox
            // 
            this.AddressBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.AddressBox.Size = new System.Drawing.Size(400, 29);
            this.AddressBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddressBox_KeyPress);
            this.AddressBox.Click += new System.EventHandler(this.AddressBox_Click);
            // 
            // GoButton
            // 
            this.GoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.GoButton.Image = ((System.Drawing.Image)(resources.GetObject("GoButton.Image")));
            this.GoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(26, 26);
            this.GoButton.Text = "Go";
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(36, 26);
            this.BackButton.Text = "Back";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ForwardButton.Image = ((System.Drawing.Image)(resources.GetObject("ForwardButton.Image")));
            this.ForwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(54, 26);
            this.ForwardButton.Text = "Forward";
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(44, 26);
            this.HomeButton.Text = "Home";
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StopButton.Image = ((System.Drawing.Image)(resources.GetObject("StopButton.Image")));
            this.StopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(35, 26);
            this.StopButton.Text = "Stop";
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(46, 26);
            this.SearchButton.Text = "Search";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // BrowserContainer
            // 
            this.BrowserContainer.Controls.Add(this.BrowserStatusBar);
            this.BrowserContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowserContainer.Location = new System.Drawing.Point(0, 29);
            this.BrowserContainer.Name = "BrowserContainer";
            this.BrowserContainer.Size = new System.Drawing.Size(782, 419);
            this.BrowserContainer.TabIndex = 1;
            // 
            // BrowserStatusBar
            // 
            this.BrowserStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BrowserStatusText,
            this.toolStripStatusLabel1});
            this.BrowserStatusBar.Location = new System.Drawing.Point(0, 397);
            this.BrowserStatusBar.Name = "BrowserStatusBar";
            this.BrowserStatusBar.Size = new System.Drawing.Size(782, 22);
            this.BrowserStatusBar.TabIndex = 0;
            this.BrowserStatusBar.Text = "statusStrip1";
            // 
            // BrowserStatusText
            // 
            this.BrowserStatusText.Name = "BrowserStatusText";
            this.BrowserStatusText.Size = new System.Drawing.Size(10, 17);
            this.BrowserStatusText.Text = " ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = " ";
            // 
            // BrowserBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 448);
            this.Controls.Add(this.BrowserContainer);
            this.Controls.Add(this.CommandBar);
            this.Name = "BrowserBasic";
            this.Text = "Basic Browser";
            this.Load += new System.EventHandler(this.BrowserForm_Load);
            this.CommandBar.ResumeLayout(false);
            this.CommandBar.PerformLayout();
            this.BrowserContainer.ResumeLayout(false);
            this.BrowserContainer.PerformLayout();
            this.BrowserStatusBar.ResumeLayout(false);
            this.BrowserStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion Windows Form Designer generated code

        public System.Windows.Forms.ToolStrip CommandBar;
        public System.Windows.Forms.ToolStripTextBox AddressBox;
        public System.Windows.Forms.ToolStripButton GoButton;
        public System.Windows.Forms.ToolStripButton BackButton;
        public System.Windows.Forms.ToolStripButton ForwardButton;
        public System.Windows.Forms.ToolStripButton HomeButton;
        public System.Windows.Forms.ToolStripButton StopButton;
        public System.Windows.Forms.ToolStripButton SearchButton;
        public System.Windows.Forms.StatusStrip BrowserStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel BrowserStatusText;
        public System.Windows.Forms.Panel BrowserContainer;

    }
}