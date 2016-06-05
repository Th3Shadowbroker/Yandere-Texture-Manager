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
    public partial class SettingsForm : Form
    {

        private String StorageDir;
        private String YandereDir;

        public SettingsForm( String StorageDir, String YandereDir )
        {

            InitializeComponent();

            this.StorageDir = StorageDir;

            this.YandereDir = YandereDir;

            this.Show();

        }

        //Reset settings by deleting settings file
        private void ResetSettingsButton_Click(object sender, EventArgs e)
        {

            if ( File.Exists( StorageDir + "/settings.inf" ) )
            {
                File.Delete( StorageDir + "/settings.inf" );
            }

            MessageBox.Show( "Die Anwendung wir nun neugestartet.", "Neustart..." );

            Application.Restart();

        }

        //Remove all Custom textures
        private void RemoveCustomFiles_Click(object sender, EventArgs e)
        {

            foreach ( FileInfo file in new DirectoryInfo( YandereDir ).GetFiles() )
            {
                if ( file.Name.ToLower().Contains( "custom" ) && !file.Name.ToLower().Contains( "example" ) )
                {
                    File.Delete( file.FullName );
                }
            }

            MessageBox.Show( "Alle nicht zugehörigen Texturen wurden gelöscht." );

        }

    }
}
