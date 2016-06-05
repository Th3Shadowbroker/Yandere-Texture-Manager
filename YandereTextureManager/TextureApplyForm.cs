using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace YandereTextureManager
{
    public partial class TextureApplyForm : Form
    {

        private String texture;
        private String yandereDir;

        //Construction
        public TextureApplyForm( String title, String texture , String yandereDir )
        {
            InitializeComponent();
            this.Text = title;
            this.texture = texture;
            this.yandereDir = yandereDir;

            this.ActionList.SelectedIndex = ActionList.Items.Count - 1;

            this.Show();

        }

        //Set new texture as selected texture
        private void SetTexture_Click(object sender, EventArgs e)
        {

            try
            {
                if (File.Exists(yandereDir + "/" + ActionList.SelectedItem + ".png"))
                {
                    File.Delete(yandereDir + "/" + ActionList.SelectedItem + ".png");
                }

                File.Copy(this.texture, yandereDir + "/" + ActionList.SelectedItem + ".png");

                MessageBox.Show( "Textur wurde erfolgreich als " + ActionList.SelectedItem + " gesetzt.", "Erfolgreich..." );

                this.Close();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Fehler" );
            }

        }

    }
}
