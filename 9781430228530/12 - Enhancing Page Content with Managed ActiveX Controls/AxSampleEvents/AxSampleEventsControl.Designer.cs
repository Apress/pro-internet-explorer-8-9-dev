namespace ProIeDev
{
    partial class AxSampleEventsControl
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
            this.FireEventButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(81, 36);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(193, 22);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Events Test Control";
            // 
            // FireEventButton
            // 
            this.FireEventButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FireEventButton.Location = new System.Drawing.Point(74, 83);
            this.FireEventButton.Name = "FireEventButton";
            this.FireEventButton.Size = new System.Drawing.Size(209, 33);
            this.FireEventButton.TabIndex = 4;
            this.FireEventButton.Text = "Click me to fire an event!";
            this.FireEventButton.UseVisualStyleBackColor = true;
            this.FireEventButton.Click += new System.EventHandler(this.FireEventButton_Click);
            // 
            // AxSampleEventsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.FireEventButton);
            this.Controls.Add(this.TitleLabel);
            this.Name = "AxSampleEventsControl";
            this.Size = new System.Drawing.Size(343, 173);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion Component Designer generated code

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button FireEventButton;
    }
}