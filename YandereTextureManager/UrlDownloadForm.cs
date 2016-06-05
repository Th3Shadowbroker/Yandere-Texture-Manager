using System;
using System.Net;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace YandereTextureManager
{
    public partial class UrlDownloadForm : Form
    {

        private WebClient client = new WebClient();
        private String StorageDir;

        //Construction
        public UrlDownloadForm( String StorageDir )
        {

            InitializeComponent();

            this.StorageDir = StorageDir;

            this.Show();

        }

        //Start download
        private void RunDownload_Click(object sender, EventArgs e)
        {
            if ( TextureURL.Text != "" )
            {
                try
                {
                    String[] urlSplitted = TextureURL.Text.Split( '/' );
                    Uri downloadURL = new Uri( TextureURL.Text );

                    client.DownloadFile(downloadURL, StorageDir + "/" + urlSplitted[ urlSplitted.Length - 1 ]);
                    MessageBox.Show("Textur hinzugefügt.", "Erfolgreich...");
                    MainForm.getInstance().reloadContent();
                    this.Close();

                }
                catch ( Exception ex)
                {
                    MessageBox.Show( ex.Message, "Fehler" );
                }
            }
            else
            {
                MessageBox.Show( "Bitte gebe eine URL ein...", "Fehler" );
            }


        }



    }
}
