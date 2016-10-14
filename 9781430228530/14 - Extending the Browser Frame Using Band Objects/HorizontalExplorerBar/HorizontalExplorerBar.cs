using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using ProIeDev.BandObjectDemo.BandObject;

namespace ProIeDev.BandObjectDemo.HorizontalExplorerBar
{
    [ComVisible(true)]
    public class HorizontalExplorerBar : BandObject.BandObject
    {

        public HorizontalExplorerBar()
        {
            InitializeComponent();
        }

        public override void DefineMetadata() 
        {

            ClassId = "{B028EA5C-B226-4E4B-88C6-8842A152BC5B}";
            ProgId = "ProIeDev.BandObjectDemo.HorizontalExplorerBar";
            ObjectName = "TodoBar Horizontal";
            ObjectTitle = "TodoBar Horizontal";
            HelpText = "TodoBar Horizontal";
            Style = BandObjectTypes.HorizontalExplorerBar;

        }

        #region Form Designer

        private System.Windows.Forms.Label TodoLabel;
        private System.Windows.Forms.TextBox TodoTextbox;
        private System.Windows.Forms.Button GoButton;

        private void InitializeComponent()
        {
            this.GoButton = new System.Windows.Forms.Button();
            this.TodoLabel = new System.Windows.Forms.Label();
            this.TodoTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GoButton
            // 
            this.GoButton.BackColor = System.Drawing.Color.Yellow;
            this.GoButton.Location = new System.Drawing.Point(24, 116);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(77, 43);
            this.GoButton.TabIndex = 0;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = false;
            // 
            // TodoLabel
            // 
            this.TodoLabel.AutoSize = true;
            this.TodoLabel.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodoLabel.ForeColor = System.Drawing.Color.White;
            this.TodoLabel.Location = new System.Drawing.Point(21, 21);
            this.TodoLabel.Name = "TodoLabel";
            this.TodoLabel.Size = new System.Drawing.Size(202, 16);
            this.TodoLabel.TabIndex = 1;
            this.TodoLabel.Text = "What do you want to do today?";
            // 
            // TodoTextbox
            // 
            this.TodoTextbox.Location = new System.Drawing.Point(24, 51);
            this.TodoTextbox.Multiline = true;
            this.TodoTextbox.Name = "TodoTextbox";
            this.TodoTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TodoTextbox.Size = new System.Drawing.Size(409, 53);
            this.TodoTextbox.TabIndex = 2;
            // 
            // HorizontalExplorerBar
            // 
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.Controls.Add(this.TodoTextbox);
            this.Controls.Add(this.TodoLabel);
            this.Controls.Add(this.GoButton);
            this.Name = "HorizontalExplorerBar";
            this.Size = new System.Drawing.Size(456, 177);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion Form Designer

    }
}
