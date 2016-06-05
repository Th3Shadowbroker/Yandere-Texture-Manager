namespace YandereTextureManager
{
    partial class UrlDownloadForm
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
            this.TextureURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RunDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextureURL
            // 
            this.TextureURL.Location = new System.Drawing.Point(116, 16);
            this.TextureURL.Name = "TextureURL";
            this.TextureURL.Size = new System.Drawing.Size(301, 20);
            this.TextureURL.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Textur beziehen von:";
            // 
            // RunDownload
            // 
            this.RunDownload.Location = new System.Drawing.Point(6, 49);
            this.RunDownload.Name = "RunDownload";
            this.RunDownload.Size = new System.Drawing.Size(411, 23);
            this.RunDownload.TabIndex = 2;
            this.RunDownload.Text = "Textur herunterladen und hinzufügen...";
            this.RunDownload.UseVisualStyleBackColor = true;
            this.RunDownload.Click += new System.EventHandler(this.RunDownload_Click);
            // 
            // UrlDownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 91);
            this.Controls.Add(this.RunDownload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextureURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UrlDownloadForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Textur von URL hinzufügen...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextureURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RunDownload;
    }
}