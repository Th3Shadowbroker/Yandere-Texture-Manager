using System.Windows.Forms;
using System.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace YandereTextureManager
{
    public partial class MainForm : Form
    {

        #region Variables

            private List<string> PathList = new List<string>();
            private String storageDir = Application.StartupPath + "/storage";
            private String settingsFile = Application.StartupPath + "/storage/settings.inf";
            private String yandereDir;
            private static MainForm instance;
        
        #endregion

        #region Load-up process
        public MainForm()
        {

            InitializeComponent();

            instance = this;

            //Create galery directory
            if (!Directory.Exists(storageDir))
            {
                Directory.CreateDirectory(storageDir);
            }

            //Settings file creation
            if (!File.Exists(settingsFile))
            {

                MessageBox.Show("Wähle im folgenden Fenster den StreamingAssets Ordner deiner Yandere-Installation aus.", "Erststart-Hinweis");

                FolderBrowserDialog req = new FolderBrowserDialog();

                if (req.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(settingsFile, req.SelectedPath);
                }

            }

            this.yandereDir = File.ReadAllText(settingsFile);

            //Add all files to list
            DirectoryInfo textureDir = new DirectoryInfo(storageDir);

            foreach (FileInfo file in textureDir.GetFiles())
            {
                if (file.Name.Contains(".png"))
                {
                    TextureList.Items.Add(file.Name);
                    PathList.Add(file.FullName);
                }
            }

            //Set default selection
            if (TextureList.Items.Count != 0)
            {
                TextureList.SelectedIndex = 0;
            }

        }
        #endregion

        #region Events
        //Event: Selected Item changed
        private void TextureList_SelectedIndexChanged(object sender, EventArgs e)
            {

                try
                {
                    TexturePreview.ImageLocation = storageDir + "/" + TextureList.SelectedItem;
                    ImageInfo.Text = TextureList.SelectedItem + "\n"
                                    + PathList[TextureList.SelectedIndex];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler");
                }

            }
        #endregion

        #region Menu-Bar

            //Open authors website
            private void yTMWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
            {

                Process.Start("http://crafter629.de");

            }

            //About message
            private void überDenYTMToolStripMenuItem_Click(object sender, EventArgs e)
            {
                MessageBox.Show("YTM wurde erstellt von Jens F.\n"
                               + "Alle Rechte vorbehalten.\n"
                               + "Icon erstellt von Itzik Gur\n http://www.iconarchive.com/show/my-seven-icons-by-itzikgur/Graphics-Painting-icon.html \n"
                               + "\n http://YouTube.com/c/m4taiori \n"
                               + "\nDIESE SOFTWARE STEHT IN KEINEM ZUSAMMENHANG MIT DEM YANDERE SIMMULATOR UND ES WIRD NICHT FÜR SCHÄDEN GEHAFTET"
                               , "Über den Yandere Texture-Manager");
            }

            //Open up the yandere texture-dir
            private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Process.Start( yandereDir );
            }

            //Open up the storage-dir
            private void storageVerzeichnisÖffnenToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Process.Start(storageDir);
            }

            //Remove texture from storage
            private void texturEntfernenToolStripMenuItem_Click(object sender, EventArgs e)
            {
               try
                {
                    File.Delete(storageDir + "/" + TextureList.SelectedItem);
                    this.reloadContent();
                }
                catch   ( Exception ex )
                {
                    MessageBox.Show(ex.Message, "Fehler");
                }
            }

            //Refresh texture list
            private void optionenToolStripMenuItem_Click(object sender, EventArgs e)
            {
                this.reloadContent();
            }

            //Load texture from file
            //Browse for new resources on loal computer
            private void vonDateiLadenToolStripMenuItem_Click(object sender, EventArgs e)
            {

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Neue Textur hinzufügen...";
                ofd.Filter = "Yandere-Textur|*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    FileInfo FileToCopy = new FileInfo(ofd.FileName);

                    File.Copy(FileToCopy.FullName, storageDir + "/" + FileToCopy.Name, true);

                    this.reloadContent();

                }

            }

            //Open up options
            private void optionenToolStripMenuItem1_Click(object sender, EventArgs e)
            {

                SettingsForm sf = new SettingsForm(storageDir, yandereDir);

            }

            //Open up URL download form
            private void vonURLLadenToolStripMenuItem_Click(object sender, EventArgs e)
            {

                UrlDownloadForm urlDoFm = new UrlDownloadForm(storageDir);

            }

        #endregion

        #region Functions
        //Reload the texture lists content
        public void reloadContent()
            {
                try
                {

                    TextureList.Items.Clear();
                    PathList.Clear();

                    DirectoryInfo textureDir = new DirectoryInfo(storageDir);

                    foreach (FileInfo file in textureDir.GetFiles())
                    {
                        if (file.Name.Contains(".png"))
                        {
                            TextureList.Items.Add(file.Name);
                            PathList.Add(file.FullName);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler");
                }
            }
        #endregion

        #region Buttons

        //Set a new teture
        private void ChangeTexture_Click(object sender, EventArgs e)
        {
            TextureApplyForm taf = new TextureApplyForm( "Textur festlegen...", storageDir + "/" + TextureList.SelectedItem, yandereDir );
        }



        #endregion

        #region Instance

            public static MainForm getInstance()
            {
                return instance;
            }



        #endregion

       
    }
}
