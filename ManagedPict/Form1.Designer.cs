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
            this.btnUploadPrev = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPrev = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnNas = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.textBoxNas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUploadPrev
            // 
            this.btnUploadPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUploadPrev.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUploadPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadPrev.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUploadPrev.Location = new System.Drawing.Point(679, 70);
            this.btnUploadPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnUploadPrev.Name = "btnUploadPrev";
            this.btnUploadPrev.Size = new System.Drawing.Size(195, 52);
            this.btnUploadPrev.TabIndex = 49;
            this.btnUploadPrev.Text = "Choose folder";
            this.btnUploadPrev.UseVisualStyleBackColor = false;
            this.btnUploadPrev.Click += new System.EventHandler(this.btnUploadPrev_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(13, 470);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(195, 52);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPrev
            // 
            this.lblPrev.Location = new System.Drawing.Point(115, 85);
            this.lblPrev.Margin = new System.Windows.Forms.Padding(4);
            this.lblPrev.Name = "lblPrev";
            this.lblPrev.ReadOnly = true;
            this.lblPrev.Size = new System.Drawing.Size(215, 22);
            this.lblPrev.TabIndex = 60;
            // 
            // btnNas
            // 
            this.btnNas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNas.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNas.Location = new System.Drawing.Point(679, 168);
            this.btnNas.Margin = new System.Windows.Forms.Padding(4);
            this.btnNas.Name = "btnNas";
            this.btnNas.Size = new System.Drawing.Size(195, 52);
            this.btnNas.TabIndex = 61;
            this.btnNas.Text = "Choose NAS folder";
            this.btnNas.UseVisualStyleBackColor = false;
            this.btnNas.Click += new System.EventHandler(this.btnNas_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.Tomato;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreate.Location = new System.Drawing.Point(394, 246);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(195, 52);
            this.btnCreate.TabIndex = 62;
            this.btnCreate.Text = "Run";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // textBoxNas
            // 
            this.textBoxNas.Location = new System.Drawing.Point(115, 131);
            this.textBoxNas.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNas.Name = "textBoxNas";
            this.textBoxNas.ReadOnly = true;
            this.textBoxNas.Size = new System.Drawing.Size(215, 22);
            this.textBoxNas.TabIndex = 63;
            // 
            // MangedPics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 544);
            this.Controls.Add(this.textBoxNas);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnNas);
            this.Controls.Add(this.lblPrev);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUploadPrev);
            this.Name = "MangedPics";
            this.Text = "ManagedPict";
            this.Load += new System.EventHandler(this.MangedPics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUploadPrev;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox lblPrev;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnNas;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox textBoxNas;
    }
}

