using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using ProIeDev.BandObjectDemo.BandObject;

namespace ProIeDev.BandObjectDemo.VerticalExplorerBar
{
    [ComVisible(true)]
    public class VerticalExplorerBar : BandObject.BandObject
    {

        public VerticalExplorerBar()
        {
            InitializeComponent();
        }

        public override void DefineMetadata() 
        {

            ClassId = "{FBAC3BF8-5210-4B61-879D-715396839846}";
            ProgId = "ProIeDev.BandObjectDemo.VerticalExplorerBar";
            ObjectName = "TodoBar Vertical";
            ObjectTitle = "TodoBar Vertical";
            HelpText = "TodoBar Vertical";
            Style = BandObjectTypes.VerticalExplorerBar;

        }

        #region Form Designer

        private System.Windows.Forms.TextBox TodoTextbox;
        private System.Windows.Forms.Label TodoLabel;
        private System.Windows.Forms.Button GoButton;

        private void InitializeComponent()
        {
            this.TodoTextbox = new System.Windows.Forms.TextBox();
            this.TodoLabel = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TodoTextbox
            // 
            this.TodoTextbox.Location = new System.Drawing.Point(18, 50);
            this.TodoTextbox.Multiline = true;
            this.TodoTextbox.Name = "TodoTextbox";
            this.TodoTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TodoTextbox.Size = new System.Drawing.Size(199, 53);
            this.TodoTextbox.TabIndex = 5;
            // 
            // TodoLabel
            // 
            this.TodoLabel.AutoSize = true;
            this.TodoLabel.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodoLabel.ForeColor = System.Drawing.Color.White;
            this.TodoLabel.Location = new System.Drawing.Point(15, 20);
            this.TodoLabel.Name = "TodoLabel";
            this.TodoLabel.Size = new System.Drawing.Size(202, 16);
            this.TodoLabel.TabIndex = 4;
            this.TodoLabel.Text = "What do you want to do today?";
            // 
            // GoButton
            // 
            this.GoButton.BackColor = System.Drawing.Color.Yellow;
            this.GoButton.Location = new System.Drawing.Point(140, 117);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(77, 43);
            this.GoButton.TabIndex = 3;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = false;
            // 
            // VerticalExplorerBar
            // 
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.Controls.Add(this.TodoTextbox);
            this.Controls.Add(this.TodoLabel);
            this.Controls.Add(this.GoButton);
            this.Name = "VerticalExplorerBar";
            this.Size = new System.Drawing.Size(238, 250);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion Form Designer


    }
}
