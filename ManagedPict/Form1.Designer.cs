namespace ManagedPict
{
    partial class MangedPics
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblFolder = new System.Windows.Forms.Label();
            this.lblNas = new System.Windows.Forms.Label();
            this.pictureBoxFolder = new System.Windows.Forms.PictureBox();
            this.pictureBoxNas = new System.Windows.Forms.PictureBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxArtist = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCopyrights = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.BackColor = System.Drawing.Color.Transparent;
            this.lblFolder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFolder.Location = new System.Drawing.Point(175, 84);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(24, 17);
            this.lblFolder.TabIndex = 63;
            this.lblFolder.Text = "....";
            // 
            // lblNas
            // 
            this.lblNas.AutoSize = true;
            this.lblNas.BackColor = System.Drawing.Color.Transparent;
            this.lblNas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNas.Location = new System.Drawing.Point(175, 172);
            this.lblNas.Name = "lblNas";
            this.lblNas.Size = new System.Drawing.Size(24, 17);
            this.lblNas.TabIndex = 64;
            this.lblNas.Text = "....";
            // 
            // pictureBoxFolder
            // 
            this.pictureBoxFolder.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFolder.Location = new System.Drawing.Point(47, 64);
            this.pictureBoxFolder.Name = "pictureBoxFolder";
            this.pictureBoxFolder.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxFolder.TabIndex = 65;
            this.pictureBoxFolder.TabStop = false;
            this.pictureBoxFolder.Click += new System.EventHandler(this.pictureBoxFolder_Click);
            // 
            // pictureBoxNas
            // 
            this.pictureBoxNas.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxNas.Location = new System.Drawing.Point(47, 155);
            this.pictureBoxNas.Name = "pictureBoxNas";
            this.pictureBoxNas.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxNas.TabIndex = 66;
            this.pictureBoxNas.TabStop = false;
            this.pictureBoxNas.Click += new System.EventHandler(this.pictureBoxNas_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreate.Location = new System.Drawing.Point(0, 497);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(1183, 125);
            this.btnCreate.TabIndex = 62;
            this.btnCreate.Text = "Run";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(932, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(237, 125);
            this.btnClose.TabIndex = 68;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.Location = new System.Drawing.Point(0, 664);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1183, 23);
            this.progressBar1.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 17);
            this.label1.TabIndex = 70;
            this.label1.Text = "Choose the image folder and the copy folder (NAS) and sup exifs to write yours co" +
    "pyrights";
            // 
            // textBoxArtist
            // 
            this.textBoxArtist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxArtist.ForeColor = System.Drawing.Color.White;
            this.textBoxArtist.Location = new System.Drawing.Point(137, 408);
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(293, 22);
            this.textBoxArtist.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(25, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 72;
            this.label2.Text = "Artist exif :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(25, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 74;
            this.label3.Text = "Copyrights exif :";
            // 
            // textBoxCopyrights
            // 
            this.textBoxCopyrights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxCopyrights.ForeColor = System.Drawing.Color.White;
            this.textBoxCopyrights.Location = new System.Drawing.Point(137, 448);
            this.textBoxCopyrights.Name = "textBoxCopyrights";
            this.textBoxCopyrights.Size = new System.Drawing.Size(293, 22);
            this.textBoxCopyrights.TabIndex = 73;
            // 
            // MangedPics
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1182, 699);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCopyrights);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxArtist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBoxNas);
            this.Controls.Add(this.pictureBoxFolder);
            this.Controls.Add(this.lblNas);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.btnCreate);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MangedPics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagedPict";
            this.Load += new System.EventHandler(this.MangedPics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Label lblNas;
        private System.Windows.Forms.PictureBox pictureBoxFolder;
        private System.Windows.Forms.PictureBox pictureBoxNas;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClose;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxArtist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCopyrights;
    }
}

