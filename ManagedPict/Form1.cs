﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagedPict.tools;

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

        

        private void btnUploadPrev_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // the code here will be executed if the user presses Open in
                // the dialog.
                _folderPath = folderBrowserDialog1.SelectedPath;
                lblPrev.Text = _folderPath;
                /* foreach (string f in Directory.GetFiles(foldername))
                     this.listBox1.Items.Add(f);*/
            }
        }

        private void MangedPics_Load(object sender, EventArgs e)
        {
            // Mettre le path du traiter 
            //RootFolder  
            folderBrowserDialog1.SelectedPath = @"C:\_NICO\perso\winform\traiter";//System.Environment.SpecialFolder.MyComputer;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNas_Click(object sender, EventArgs e)
        {
            // this.folderBrowserDialog1.RootFolder = "nas path";
            folderBrowserDialog1.SelectedPath = @"C:\_NICO\perso\winform\NAS";

            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // the code here will be executed if the user presses Open in
                // the dialog.
                _nasPath = folderBrowserDialog1.SelectedPath;
                textBoxNas.Text = _nasPath;
                /* foreach (string f in Directory.GetFiles(foldername))
                     this.listBox1.Items.Add(f);*/
            }

            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            _noExifPath = _folderPath + @"\" + "sansExifs";
            // Create file sansexif.
            var di = Directory.CreateDirectory(_noExifPath);
            
            // Côpy pict in folder.
            Copy();

            // Copy the exif exec.
            CopyExec();// File.Copy(@"C:\_NICO\perso\winform\exiftool.exe", _noExifPath);

            var command = "exiftool.exe -all= *.jpg";
            var removeBatPath = MakeBatFile(command, BatNameSup);
            
            System.Diagnostics.Process.Start(removeBatPath);

            command = "exiftool -artist=\"Sortido Pict\" -copyright=\"sortidopict\" *.jpg";
            
            var addBatPath = MakeBatFile(command, BatNameAdd);

            System.Diagnostics.Process.Start(addBatPath);

            // After delete all the tmp files.
            deleteFilesTmp();

            if (!string.IsNullOrEmpty(_nasPath))
            {
                
                var sourceDirectory = _noExifPath;
                var targetDirectory = _nasPath + @"\" + "aujourdhui";

                CopyDir.Copy(sourceDirectory, targetDirectory);

            }
            
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
    }
}