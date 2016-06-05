namespace YandereTextureManager
{
    partial class TextureApplyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ActionList = new System.Windows.Forms.ComboBox();
            this.SetTexture = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Als was möchtest du die Textur verwenden ?";
            // 
            // ActionList
            // 
            this.ActionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActionList.FormattingEnabled = true;
            this.ActionList.Items.AddRange(new object[] {
            "CustomUniform",
            "CustomLong",
            "CustomSweater",
            "CustomBlazer",
            "CustomArms",
            "CustomFace",
            "CustomSwimsuit",
            "CustomGym",
            "CustomNude",
            "CustomHair"});
            this.ActionList.Location = new System.Drawing.Point(16, 30);
            this.ActionList.Name = "ActionList";
            this.ActionList.Size = new System.Drawing.Size(216, 21);
            this.ActionList.TabIndex = 1;
            // 
            // SetTexture
            // 
            this.SetTexture.Location = new System.Drawing.Point(16, 73);
            this.SetTexture.Name = "SetTexture";
            this.SetTexture.Size = new System.Drawing.Size(216, 23);
            this.SetTexture.TabIndex = 2;
            this.SetTexture.Text = "Textur verwenden";
            this.SetTexture.UseVisualStyleBackColor = true;
            this.SetTexture.Click += new System.EventHandler(this.SetTexture_Click);
            // 
            // TextureApplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 101);
            this.Controls.Add(this.SetTexture);
            this.Controls.Add(this.ActionList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TextureApplyForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ActionList;
        private System.Windows.Forms.Button SetTexture;
    }
}