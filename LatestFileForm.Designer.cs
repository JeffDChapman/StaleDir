namespace LatestFile
{
    partial class LatestFileForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LatestFileForm));
            this.dialogGetFile = new System.Windows.Forms.OpenFileDialog();
            this.tmrCheckFreq = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hrsAlert = new System.Windows.Forms.NumericUpDown();
            this.btnToggle = new System.Windows.Forms.Button();
            this.tmrAlertSound = new System.Windows.Forms.Timer(this.components);
            this.lblFullPath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hrsAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // dialogGetFile
            // 
            this.dialogGetFile.InitialDirectory = "c:\\";
            this.dialogGetFile.Title = "Select a File";
            // 
            // tmrCheckFreq
            // 
            this.tmrCheckFreq.Enabled = true;
            this.tmrCheckFreq.Interval = 1200000;
            this.tmrCheckFreq.Tick += new System.EventHandler(this.tmrCheckFreq_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alert After";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hours";
            // 
            // hrsAlert
            // 
            this.hrsAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrsAlert.Location = new System.Drawing.Point(99, 9);
            this.hrsAlert.Name = "hrsAlert";
            this.hrsAlert.Size = new System.Drawing.Size(57, 23);
            this.hrsAlert.TabIndex = 2;
            this.hrsAlert.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnToggle
            // 
            this.btnToggle.Location = new System.Drawing.Point(16, 42);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(46, 22);
            this.btnToggle.TabIndex = 3;
            this.btnToggle.Text = "on";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // tmrAlertSound
            // 
            this.tmrAlertSound.Interval = 30000;
            this.tmrAlertSound.Tick += new System.EventHandler(this.tmrAlertSound_Tick);
            // 
            // lblFullPath
            // 
            this.lblFullPath.AutoSize = true;
            this.lblFullPath.Font = new System.Drawing.Font("SatBarNarrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullPath.Location = new System.Drawing.Point(16, 77);
            this.lblFullPath.Name = "lblFullPath";
            this.lblFullPath.Size = new System.Drawing.Size(65, 10);
            this.lblFullPath.TabIndex = 4;
            this.lblFullPath.Text = "Full Path Here";
            this.lblFullPath.Click += new System.EventHandler(this.lblFullPath_Click);
            // 
            // LatestFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 79);
            this.Controls.Add(this.lblFullPath);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.hrsAlert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LatestFileForm";
            this.ShowInTaskbar = false;
            this.Text = "Directory\\FileType";
            this.Load += new System.EventHandler(this.LatestFileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hrsAlert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dialogGetFile;
        private System.Windows.Forms.Timer tmrCheckFreq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown hrsAlert;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Timer tmrAlertSound;
        private System.Windows.Forms.Label lblFullPath;
    }
}

