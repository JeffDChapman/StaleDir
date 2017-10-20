using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace LatestFile
{
    public partial class LatestFileForm : Form
    {
        string chkDir;
        string chkExt;
        TimeSpan newestFile;
        Color savedColor;

        public LatestFileForm()
        {
            InitializeComponent();
        }

        private void LatestFileForm_Load(object sender, EventArgs e)
        {
            this.dialogGetFile.ShowDialog();
            string getFile = this.dialogGetFile.FileName;
            if (getFile == "")
                { this.Close();
                return;
                }
            chkExt = Path.GetExtension(getFile);
            chkDir = Path.GetDirectoryName(getFile);
            string[] dirs = chkDir.Split(new [] {'\\'});
            string displayDir = dirs[dirs.Length - 1] + "\\*" + chkExt;
            this.lblFullPath.Text = chkDir;
            this.Text = displayDir;
            savedColor = this.BackColor;

            // for testing
            // this.tmrCheckFreq.Interval = 10000;
        }

        private void tmrCheckFreq_Tick(object sender, EventArgs e)
        {
            newestFile = TimeSpan.MaxValue;
            try
            {
                var txtFiles = Directory.EnumerateFiles(chkDir, "*" + chkExt);
                foreach (string currentFile in txtFiles)
                {
                    string chkFile = Path.Combine(chkDir, currentFile);
                    DateTime lastWritten = File.GetLastWriteTime(chkFile);
                    TimeSpan ageOfFile = DateTime.Now - lastWritten;
                    if (ageOfFile < newestFile)
                        { newestFile = ageOfFile; }
                }
            }
            catch {}

            if (newestFile > TimeSpan.FromHours(Convert.ToDouble(this.hrsAlert.Value)))
                { this.tmrAlertSound.Enabled = true;
                string titleSave = this.Text;
                this.Text = "** " + titleSave;
                this.BackColor = Color.Red;
            }
                else { this.tmrAlertSound.Enabled = false;
                this.BackColor = savedColor;
                }
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (this.btnToggle.Text == "on")
            {
                this.btnToggle.Text = "off";
                this.tmrCheckFreq.Enabled = false;
                this.tmrAlertSound.Enabled = false;
            }
            else
            {
                this.btnToggle.Text = "on";
                this.tmrCheckFreq.Enabled = true;
            }
        }

        private void tmrAlertSound_Tick(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\jchapman\Documents\Visual Studio 2013\Projects\LatestFile\LatestFile\baby_cry.wav");
            simpleSound.Play();  
        }

        private void lblFullPath_Click(object sender, EventArgs e)
        {
            Process.Start("Explorer.exe", chkDir);
        }
    }
}
