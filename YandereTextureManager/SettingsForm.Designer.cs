namespace YandereTextureManager
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
            this.ResetSettingsButton = new System.Windows.Forms.Button();
            this.RemoveCustomFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResetSettingsButton
            // 
            this.ResetSettingsButton.Location = new System.Drawing.Point(13, 13);
            this.ResetSettingsButton.Name = "ResetSettingsButton";
            this.ResetSettingsButton.Size = new System.Drawing.Size(361, 23);
            this.ResetSettingsButton.TabIndex = 0;
            this.ResetSettingsButton.Text = "Yandere-Pfad zurücksetzen...";
            this.ResetSettingsButton.UseVisualStyleBackColor = true;
            this.ResetSettingsButton.Click += new System.EventHandler(this.ResetSettingsButton_Click);
            // 
            // RemoveCustomFiles
            // 
            this.RemoveCustomFiles.Location = new System.Drawing.Point(13, 42);
            this.RemoveCustomFiles.Name = "RemoveCustomFiles";
            this.RemoveCustomFiles.Size = new System.Drawing.Size(361, 23);
            this.RemoveCustomFiles.TabIndex = 1;
            this.RemoveCustomFiles.Text = "Eigene Texturen entfernen...";
            this.RemoveCustomFiles.UseVisualStyleBackColor = true;
            this.RemoveCustomFiles.Click += new System.EventHandler(this.RemoveCustomFiles_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 78);
            this.Controls.Add(this.RemoveCustomFiles);
            this.Controls.Add(this.ResetSettingsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optionen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ResetSettingsButton;
        private System.Windows.Forms.Button RemoveCustomFiles;
    }
}