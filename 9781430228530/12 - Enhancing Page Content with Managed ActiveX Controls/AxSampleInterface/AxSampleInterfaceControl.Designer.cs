namespace ProIeDev
{
    partial class AxSampleInterfaceControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.MessageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(111, 36);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(124, 22);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Test Control";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageTextBox.Location = new System.Drawing.Point(25, 77);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(291, 22);
            this.MessageTextBox.TabIndex = 3;
            // 
            // MessageButton
            // 
            this.MessageButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageButton.Location = new System.Drawing.Point(71, 111);
            this.MessageButton.Name = "MessageButton";
            this.MessageButton.Size = new System.Drawing.Size(209, 33);
            this.MessageButton.TabIndex = 4;
            this.MessageButton.Text = "Show Message Box";
            this.MessageButton.UseVisualStyleBackColor = true;
            this.MessageButton.Click += new System.EventHandler(this.ShowMessageButton_Click);
            // 
            // AxSampleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.MessageButton);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "AxSampleControl";
            this.Size = new System.Drawing.Size(343, 173);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion Component Designer generated code

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Button MessageButton;
    }
}