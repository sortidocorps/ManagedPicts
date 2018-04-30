using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagedPict.tools;
using Microsoft.VisualBasic.PowerPacks;

namespace ManagedPict
{
    public partial class MangedPics : Form
    {

        private string _folderPath;
        private string _nasPath;
        private string _noExifPath;

        private string BatNameSup = "removeExif.bat";
        private string BatNameAdd = "addExif.bat";

        private const string NoExifsFolder = "sansExifs";

        public MangedPics()
        {
            InitializeComponent();
        }


        private void MangedPics_Load(object sender, EventArgs e)
        {

            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);


            // Mettre le path du traiter 
            //RootFolder  
            folderBrowserDialog1.SelectedPath = @"C:\_NICO\perso\winform\traiter";//System.Environment.SpecialFolder.MyComputer;
            this.BackgroundImage = (Image) (new Bitmap(ManagedPict.Properties.Resources.Capture, new Size(1182, 699)));

            pictureBoxFolder.Image = (Image)(new Bitmap(ManagedPict.Properties.Resources.if_folder_open_1608888, new Size(32, 32)));
            pictureBoxNas.Image = (Image)(new Bitmap(ManagedPict.Properties.Resources.if_Streamline_08_185027, new Size(32, 32)));


            btnCreate.FlatStyle = FlatStyle.Popup;
            btnCreate.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreate.TextImageRelation = TextImageRelation.ImageBeforeText;


            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;

            

            backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.WorkerReportsProgress = true;


        }

     

        private void btnCreate_Click(object sender, EventArgs e)
        {

            backgroundWorker1.RunWorkerAsync();

          


        }

        private void deleteFilesTmp()
        {
            if (File.Exists(_noExifPath + @"\" + "exiftool.exe"))
            {
                File.Delete(_noExifPath + @"\" + "exiftool.exe");
            }

            if (File.Exists(_noExifPath + @"\" + BatNameSup))
            {
                File.Delete(_noExifPath + @"\" + BatNameSup);
            }

            if (File.Exists(_noExifPath + @"\" + BatNameAdd))
            {
                File.Delete(_noExifPath + @"\" + BatNameAdd);
            }
        }

        private string MakeBatFile(string command, string batName)
        {
            var batNamePath = @"\" + batName;
            var pathString = _noExifPath + batNamePath;
            var fs = File.Create(pathString);
            fs.Close();
            var removeBat = _noExifPath + batNamePath;
            File.WriteAllText(_noExifPath + batNamePath, command);
            return removeBat;
        }

        private void Copy()
        {
            var destFile = _noExifPath + @"\";

            string[] files = Directory.GetFiles(_folderPath);
            foreach (var item in files)
            {
                File.Copy(item, destFile + Path.GetFileName(item));
            }
        }

        private void CopyExec()
        {
            var fileName = "exiftool.exe";
            var sourcePath = @"C:\_NICO\perso\winform";
            var targetPath = _noExifPath;

            // Use Path class to manipulate file and directory paths.
            var sourceFile = Path.Combine(sourcePath, fileName);
            var destFile = Path.Combine(targetPath, fileName);
            File.Copy(sourceFile, destFile, true);
        }

        private void pictureBoxFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // the code here will be executed if the user presses Open in
                // the dialog.
                _folderPath = folderBrowserDialog1.SelectedPath;
                lblFolder.Text = _folderPath;
                /* foreach (string f in Directory.GetFiles(foldername))
                     this.listBox1.Items.Add(f);*/
            }
        }

        private void pictureBoxNas_Click(object sender, EventArgs e)
        {
            // this.folderBrowserDialog1.RootFolder = "nas path";
            folderBrowserDialog1.SelectedPath = @"C:\_NICO\perso\winform\NAS";

            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // the code here will be executed if the user presses Open in
                // the dialog.
                _nasPath = folderBrowserDialog1.SelectedPath;
                lblNas.Text = _nasPath;
                /* foreach (string f in Directory.GetFiles(foldername))
                     this.listBox1.Items.Add(f);*/
            }

            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
        }

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           
            _noExifPath = _folderPath + @"\" + NoExifsFolder + DateTime.Now.ToString("_yyyy-MM-dd_hhmmss");
            // Create file sansexif.
            var di = Directory.CreateDirectory(_noExifPath);

            backgroundWorker1.ReportProgress(10);

            // Côpy pict in folder.
            Copy();

            backgroundWorker1.ReportProgress(20);

            // Copy the exif exec.
            CopyExec();// File.Copy(@"C:\_NICO\perso\winform\exiftool.exe", _noExifPath);

            backgroundWorker1.ReportProgress(30);

            var command = "exiftool.exe -all= *.jpg";
            var removeBatPath = MakeBatFile(command, BatNameSup);

            backgroundWorker1.ReportProgress(40);

            System.Diagnostics.Process.Start(removeBatPath);

            backgroundWorker1.ReportProgress(50);
            
            var artist = string.IsNullOrEmpty(textBoxArtist.Text) ? @"Sortido Pict" : textBoxArtist.Text;
            var copyrights = string.IsNullOrEmpty(textBoxCopyrights.Text) ? @"sortidopict" : textBoxCopyrights.Text;
            
            command = "exiftool -artist=\""+ artist + "\" -copyright=\""+ copyrights + "\" *.jpg";

            var addBatPath = MakeBatFile(command, BatNameAdd);

            backgroundWorker1.ReportProgress(60);

            System.Diagnostics.Process.Start(addBatPath);

            backgroundWorker1.ReportProgress(70);

            // After delete all the tmp files.
            deleteFilesTmp();

            backgroundWorker1.ReportProgress(80);

            if (!string.IsNullOrEmpty(_nasPath))
            {

                var sourceDirectory = _noExifPath;
                var targetDirectory = _nasPath + @"\" + DateTime.Now.ToString("yyyy-MM-dd_hhmmss");

                CopyDir.Copy(sourceDirectory, targetDirectory);

            }

            backgroundWorker1.ReportProgress(90);
            backgroundWorker1.ReportProgress(100);


        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(this, @"Done", @"Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
