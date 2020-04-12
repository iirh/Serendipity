using Serendipityx.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Serendipityx.Main;

namespace Serendipityx
{
    public partial class MainF : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        
        public MainF()
        {
            InitializeComponent();
            if (RunStartup())
            {
                OffsetUpdater.UpdateOffsets();
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    CheckMenu();
                }).Start();

                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    Tools.InitializeGlobals();
                }).Start();
            }
        }

        public void CheckMenu()
        {
            while (true)
            {
                S.GlowEnemyColor = Color.Maroon;
                S.VisualsEnabled = true;
                S.GlowEnabled = true;
                Thread.Sleep(2);
            }
        }

            private async void FadeIn(Form o, int interval = 80)
        {
            //Fade it in
            while (o.Opacity < 1.0)
            {
                await Task.Delay(interval);
                o.Opacity += 0.3;
            }
            o.Opacity = 1; //make fully visible       
        }

        private async void FadeOut(Form o, int interval = 80)
        {
            //Fade it out
            while (o.Opacity > 0.0)
            {
                await Task.Delay(interval);
                o.Opacity -= 0.3;
            }
            o.Opacity = 0; //make fully invisible     
            Application.ExitThread();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            label_status.Text += "Welcome!\nSerendipity made by Github.com / iirh" + Environment.NewLine;
            label_status.Text += "Discord: root#1418";
            FadeIn(this, 100);
        }

        private void panel_exit_MouseHover(object sender, EventArgs e)
        {
            label_exit.Font = new Font("Arial", label_exit.Font.Size, FontStyle.Bold);
        }

        private void panel_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.Font = new Font("Arial", label_exit.Font.Size, FontStyle.Regular);
        }

        private void panel_mini_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_mini_MouseHover(object sender, EventArgs e)
        {
            label_mini.Font = new Font("Arial", label_mini.Font.Size, FontStyle.Bold);
        }

        private void panel_mini_MouseLeave(object sender, EventArgs e)
        {
            label_mini.Font = new Font("Arial", label_mini.Font.Size, FontStyle.Regular);
        }

        private void panel_task_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // move tool
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel_exit_Click(object sender, EventArgs e)
        {
            FadeOut(this, 100); //close call
        }

        private void panel_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //minimize tool
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                Visuals.Start();
            }).Start();
            button_options.Enabled = true;
            button_load.Enabled = false;
            label_status.Text += Environment.NewLine;
            label_status.Text += "Cheat successfully injected!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("csgo"); //get csgo
            if (pname.Length == 0)
            {
                label_status.Text += Environment.NewLine;
                label_status.Text += "Counter-Strike: Global Offensive not found!";
            }
            else
            {
                label_status.Text += Environment.NewLine;
                label_status.Text += "Counter-Strike: Global Offensive Attached!";
                checker.Start();
                button_load.Enabled = true;
                button_check.Enabled = false;
            }
        }

        private void button_options_Click(object sender, EventArgs e)
        {
            label_status.Text += Environment.NewLine;
            label_status.Text += "Cheat closes with the game!";
            DateTime Tthen = DateTime.Now;
            do
            {
                Application.DoEvents();
            } while (Tthen.AddSeconds(5) > DateTime.Now); // count to 5, then minimize
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;

        }

        private void checker_Tick(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("csgo"); //get csgo
            if (pname.Length == 0)
            {
                label_status.Text += Environment.NewLine;
                label_status.Text += "Counter-Strike: Global Offensive closed, unload";
                FadeOut(this, 100);
            }
        }
    }
}
