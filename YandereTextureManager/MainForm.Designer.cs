namespace YandereTextureManager
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.yTMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neueTexturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vonDateiLadenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vonURLLadenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.texturEntfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.überYTMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storageVerzeichnisÖffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextureList = new System.Windows.Forms.ListBox();
            this.TexturePreview = new System.Windows.Forms.PictureBox();
            this.ImageInfo = new System.Windows.Forms.Label();
            this.ChangeTexture = new System.Windows.Forms.Button();
            this.überDenYTMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yTMWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TexturePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yTMToolStripMenuItem,
            this.überYTMToolStripMenuItem,
            this.überDenYTMToolStripMenuItem,
            this.yTMWebsiteToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(545, 24);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "MenuBar";
            // 
            // yTMToolStripMenuItem
            // 
            this.yTMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neueTexturToolStripMenuItem,
            this.texturEntfernenToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.optionenToolStripMenuItem1});
            this.yTMToolStripMenuItem.Name = "yTMToolStripMenuItem";
            this.yTMToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.yTMToolStripMenuItem.Text = "YTM";
            // 
            // neueTexturToolStripMenuItem
            // 
            this.neueTexturToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vonDateiLadenToolStripMenuItem,
            this.vonURLLadenToolStripMenuItem});
            this.neueTexturToolStripMenuItem.Name = "neueTexturToolStripMenuItem";
            this.neueTexturToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.neueTexturToolStripMenuItem.Text = "Neue Textur";
            // 
            // vonDateiLadenToolStripMenuItem
            // 
            this.vonDateiLadenToolStripMenuItem.Name = "vonDateiLadenToolStripMenuItem";
            this.vonDateiLadenToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.vonDateiLadenToolStripMenuItem.Text = "Von Datei laden...";
            this.vonDateiLadenToolStripMenuItem.Click += new System.EventHandler(this.vonDateiLadenToolStripMenuItem_Click);
            // 
            // vonURLLadenToolStripMenuItem
            // 
            this.vonURLLadenToolStripMenuItem.Name = "vonURLLadenToolStripMenuItem";
            this.vonURLLadenToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.vonURLLadenToolStripMenuItem.Text = "Von URL laden...";
            this.vonURLLadenToolStripMenuItem.Click += new System.EventHandler(this.vonURLLadenToolStripMenuItem_Click);
            // 
            // texturEntfernenToolStripMenuItem
            // 
            this.texturEntfernenToolStripMenuItem.Name = "texturEntfernenToolStripMenuItem";
            this.texturEntfernenToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.texturEntfernenToolStripMenuItem.Text = "Textur entfernen";
            this.texturEntfernenToolStripMenuItem.Click += new System.EventHandler(this.texturEntfernenToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.refreshToolStripMenuItem.Text = "Aktualisieren";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.optionenToolStripMenuItem_Click);
            // 
            // optionenToolStripMenuItem1
            // 
            this.optionenToolStripMenuItem1.Name = "optionenToolStripMenuItem1";
            this.optionenToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.optionenToolStripMenuItem1.Text = "Optionen";
            this.optionenToolStripMenuItem1.Click += new System.EventHandler(this.optionenToolStripMenuItem1_Click);
            // 
            // überYTMToolStripMenuItem
            // 
            this.überYTMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öffnenToolStripMenuItem,
            this.storageVerzeichnisÖffnenToolStripMenuItem});
            this.überYTMToolStripMenuItem.Name = "überYTMToolStripMenuItem";
            this.überYTMToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.überYTMToolStripMenuItem.Text = "Verzeichnisse";
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.öffnenToolStripMenuItem.Text = "Yandere-Verzeichnis öffnen...";
            this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click);
            // 
            // storageVerzeichnisÖffnenToolStripMenuItem
            // 
            this.storageVerzeichnisÖffnenToolStripMenuItem.Name = "storageVerzeichnisÖffnenToolStripMenuItem";
            this.storageVerzeichnisÖffnenToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.storageVerzeichnisÖffnenToolStripMenuItem.Text = "Storage-Verzeichnis öffnen...";
            this.storageVerzeichnisÖffnenToolStripMenuItem.Click += new System.EventHandler(this.storageVerzeichnisÖffnenToolStripMenuItem_Click);
            // 
            // TextureList
            // 
            this.TextureList.FormattingEnabled = true;
            this.TextureList.Location = new System.Drawing.Point(13, 28);
            this.TextureList.Name = "TextureList";
            this.TextureList.Size = new System.Drawing.Size(189, 329);
            this.TextureList.TabIndex = 1;
            this.TextureList.SelectedIndexChanged += new System.EventHandler(this.TextureList_SelectedIndexChanged);
            // 
            // TexturePreview
            // 
            this.TexturePreview.Location = new System.Drawing.Point(236, 28);
            this.TexturePreview.Name = "TexturePreview";
            this.TexturePreview.Size = new System.Drawing.Size(275, 260);
            this.TexturePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TexturePreview.TabIndex = 2;
            this.TexturePreview.TabStop = false;
            // 
            // ImageInfo
            // 
            this.ImageInfo.AutoSize = true;
            this.ImageInfo.Location = new System.Drawing.Point(236, 295);
            this.ImageInfo.Name = "ImageInfo";
            this.ImageInfo.Size = new System.Drawing.Size(0, 13);
            this.ImageInfo.TabIndex = 3;
            // 
            // ChangeTexture
            // 
            this.ChangeTexture.Location = new System.Drawing.Point(236, 330);
            this.ChangeTexture.Name = "ChangeTexture";
            this.ChangeTexture.Size = new System.Drawing.Size(275, 23);
            this.ChangeTexture.TabIndex = 4;
            this.ChangeTexture.Text = "Textur verwenden";
            this.ChangeTexture.UseVisualStyleBackColor = true;
            this.ChangeTexture.Click += new System.EventHandler(this.ChangeTexture_Click);
            // 
            // überDenYTMToolStripMenuItem
            // 
            this.überDenYTMToolStripMenuItem.Name = "überDenYTMToolStripMenuItem";
            this.überDenYTMToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.überDenYTMToolStripMenuItem.Text = "Über den YTM";
            this.überDenYTMToolStripMenuItem.Click += new System.EventHandler(this.überDenYTMToolStripMenuItem_Click);
            // 
            // yTMWebsiteToolStripMenuItem
            // 
            this.yTMWebsiteToolStripMenuItem.Name = "yTMWebsiteToolStripMenuItem";
            this.yTMWebsiteToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.yTMWebsiteToolStripMenuItem.Text = "YTM Website";
            this.yTMWebsiteToolStripMenuItem.Click += new System.EventHandler(this.yTMWebsiteToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 365);
            this.Controls.Add(this.ChangeTexture);
            this.Controls.Add(this.ImageInfo);
            this.Controls.Add(this.TexturePreview);
            this.Controls.Add(this.TextureList);
            this.Controls.Add(this.MenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuBar;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yandere Texture-Manager";
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TexturePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem yTMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neueTexturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vonDateiLadenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vonURLLadenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem texturEntfernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überYTMToolStripMenuItem;
        private System.Windows.Forms.ListBox TextureList;
        private System.Windows.Forms.PictureBox TexturePreview;
        private System.Windows.Forms.Label ImageInfo;
        private System.Windows.Forms.Button ChangeTexture;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem storageVerzeichnisÖffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überDenYTMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yTMWebsiteToolStripMenuItem;
    }
}

