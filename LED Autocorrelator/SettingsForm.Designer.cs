namespace LED_Autocorrelator
{
    partial class SettingsForm
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
            this.keepFullLogCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveSettingsAndCloseButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // keepFullLogCheckbox
            // 
            this.keepFullLogCheckbox.AutoSize = true;
            this.keepFullLogCheckbox.Location = new System.Drawing.Point(6, 19);
            this.keepFullLogCheckbox.Name = "keepFullLogCheckbox";
            this.keepFullLogCheckbox.Size = new System.Drawing.Size(91, 17);
            this.keepFullLogCheckbox.TabIndex = 0;
            this.keepFullLogCheckbox.Text = "Keep Full Log";
            this.keepFullLogCheckbox.UseVisualStyleBackColor = true;
            this.keepFullLogCheckbox.CheckedChanged += new System.EventHandler(this.keepFullLogCheckbox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.keepFullLogCheckbox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // saveSettingsAndCloseButton
            // 
            this.saveSettingsAndCloseButton.Location = new System.Drawing.Point(69, 158);
            this.saveSettingsAndCloseButton.Name = "saveSettingsAndCloseButton";
            this.saveSettingsAndCloseButton.Size = new System.Drawing.Size(99, 23);
            this.saveSettingsAndCloseButton.TabIndex = 2;
            this.saveSettingsAndCloseButton.Text = "Save and  Close";
            this.saveSettingsAndCloseButton.UseVisualStyleBackColor = true;
            this.saveSettingsAndCloseButton.Click += new System.EventHandler(this.saveSettingsAndCloseButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 189);
            this.Controls.Add(this.saveSettingsAndCloseButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox keepFullLogCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveSettingsAndCloseButton;
    }
}