using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using ProIeDev.BandObjectDemo.BandObject;

namespace ProIeDev.BandObjectDemo.Toolbar
{
    [ComVisible(true)]
    public class Toolbar : BandObject.BandObject
    {

        public Toolbar()
        {
            InitializeComponent();
        }

        public override void DefineMetadata()
        {

            ClassId = "{0A7D6D96-7822-4389-B07E-494E5E25A83A}";
            ProgId = "ProIeDev.BandObjectDemo.Toolbar";
            ObjectName = "TodoBar";
            ObjectTitle = "TodoBar";

            InitialSize = new System.Drawing.Size(500, 30);
            IntegralSize = new System.Drawing.Size(0, 0);
            MinSize = new System.Drawing.Size(500, 30);
            MaxSize = new System.Drawing.Size(500, 500);

            HelpText = "Example Toolbar for IE.";
            Style = BandObjectTypes.Toolbar;

        }

        #region Form Designer

        private System.Windows.Forms.Label TodoLabel;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.TextBox TodoTextBox;

        private void InitializeComponent()
        {
            this.TodoLabel = new System.Windows.Forms.Label();
            this.TodoTextBox = new System.Windows.Forms.TextBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TodoLabel
            // 
            this.TodoLabel.AutoSize = true;
            this.TodoLabel.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodoLabel.ForeColor = System.Drawing.Color.White;
            this.TodoLabel.Location = new System.Drawing.Point(6, 7);
            this.TodoLabel.Name = "TodoLabel";
            this.TodoLabel.Size = new System.Drawing.Size(202, 16);
            this.TodoLabel.TabIndex = 0;
            this.TodoLabel.Text = "What do you want to do today?";
            // 
            // TodoTextBox
            // 
            this.TodoTextBox.Location = new System.Drawing.Point(213, 5);
            this.TodoTextBox.Name = "TodoTextBox";
            this.TodoTextBox.Size = new System.Drawing.Size(179, 20);
            this.TodoTextBox.TabIndex = 1;
            // 
            // GoButton
            // 
            this.GoButton.BackColor = System.Drawing.Color.Yellow;
            this.GoButton.Location = new System.Drawing.Point(398, 4);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 2;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = false;
            // 
            // Toolbar
            // 
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.TodoTextBox);
            this.Controls.Add(this.TodoLabel);
            this.MaximumSize = new System.Drawing.Size(500, 30);
            this.MinimumSize = new System.Drawing.Size(500, 30);
            this.Name = "Toolbar";
            this.Size = new System.Drawing.Size(500, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion Form Designer

    }

}