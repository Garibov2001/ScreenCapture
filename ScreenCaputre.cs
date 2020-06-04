using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenCapture
{
    public partial class ScreenCaputre : Form
    {
        private int Old_X { get; set; }
        private int Old_Y { get; set; }
        private int CaptureCounter { get; set; } = 0;
        public ScreenCaputre()
        {
            InitializeComponent();
            TrayMenuContext();
        }

        private void captureTimer_Tick(object sender, EventArgs e)
        {
            if (!timerCheckBox.Checked)
            {
                CreateDirectory();
                TakeScreenShot();
                CaptureCounter++;
                captureCounter.Text = CaptureCounter.ToString();
            }                        
        }

        private void CreateDirectory()
        {
            // Specify the directory you want to manipulate.
            string path = @"D:\\PragmatechImages";

            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {                    
                    return;
                }
                // Try to create the directory.
                DirectoryInfo myDirectory = Directory.CreateDirectory(path);
               
            }
            catch (Exception e)
            {
                programStatus.Text = e.Message;
            }
        }
        private void TakeScreenShot()
        {
            try
            {
                SendKeys.Send("{PRTSC}");
                Image myImage = Clipboard.GetImage();

                String fileName =
                    @"D:\\PragmatechImages\Date_" + DateTime.Now.ToString("dd.MM.yyyy_") +
                    "Time_" + DateTime.Now.ToString("HH.mm.ss") + ".jpg";
                myImage.Save(fileName);

            }
            catch (Exception e)
            {
                programStatus.Text = e.Message;
                
            }
            

        }

       

        private void timerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (timerCheckBox.Checked)
            {
                intervalSettings.Enabled = true;   
                captureCaunterLabel.Enabled = false;
                captureCounter.Enabled = false;
                cleanDirectoryButton.Enabled = true;
            }
            else
            {
                intervalSettings.Enabled = false;
                captureCaunterLabel.Enabled = true;
                captureCounter.Enabled = true;
                cleanDirectoryButton.Enabled = false;
            }
        }
        private void cleanDirectoryButton_Click(object sender, EventArgs e)
        {                        
            CaptureCounter = 0;
            captureCounter.Text = CaptureCounter.ToString();

            DirectoryInfo di = new DirectoryInfo(@"D:\PragmatechImages");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }


        }

        private void intervalSettings_ValueChanged(object sender, EventArgs e)
        {
            captureTimer.Interval = (int)intervalSettings.Value*1000;

        }

        private void captureNotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            // System trayde Iconun uzerine sol duyme ile basdiqda gelsin
            if (e.Button == MouseButtons.Left) 
            {
                this.Visible = true;

            }
        }
        private void TrayMenuContext()
        {
            this.captureNotifyIcon.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            this.captureNotifyIcon.ContextMenuStrip.Items.Add("Open", null, this.MenuOpen_Click);
            this.captureNotifyIcon.ContextMenuStrip.Items.Add("-");
            this.captureNotifyIcon.ContextMenuStrip.Items.Add("Exit", null, this.MenuExit_Click);
        }
        private void MenuOpen_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }
        private void MenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void minimuzePictureBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ScreenCaputre_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Old_X = e.X;
                Old_Y = e.Y;
            }
        }

        private void ScreenCaputre_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int X_difference = e.X - Old_X;
                int Y_difference = e.Y - Old_Y;
                this.Location =
                    new Point(Location.X + X_difference, Location.Y + Y_difference);
            }

        }
    }
}
