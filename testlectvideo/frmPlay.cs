using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;


namespace testlectvideo
{
    public partial class frmPlay : Form
    {
        private bool pause = false;
        private bool isfinish = false;
        
        public frmPlay()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "https://www.learningcontainer.com/wp-content/uploads/2020/05/sample-mp4-file.mp4";
        }

        private void get_btn_Click(object sender, EventArgs e)
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var iconPath = Path.Combine(outPutDirectory, "../Ressources\\");
            string icon_path = new Uri(iconPath).LocalPath+ "firstvideoigot.mp4";
            toprint.Text = iconPath;
            MainVideo.Play(new Uri (icon_path));
        }
        
        private void start_btn_Click(object sender, EventArgs e)
        {
            if (isfinish == true)
            {
                toprint.Text = "LAAA";
            }
        }

        private void Stop_btn_Click(object sender, EventArgs e)
        {
            MainVideo.Stop();
        }

       

        private void btn_menu_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            this.Dispose();
            frmMenu.Show();
        }
       
        private void pauseplay_btn_Click(object sender, EventArgs e)
        {

            if (pause==true)
            {
                MainVideo.Play();
                pauseplay_btn.Text = "PAUSE";
                pause = false;
            }
            else if (pause==false)
            {
                MainVideo.Pause();
                pauseplay_btn.Text = "PLAY";
                pause = true;
            }
        }
        private void frmExit(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainVideo_EndReached(object sender, Vlc.DotNet.Core.VlcMediaPlayerEndReachedEventArgs e)
        {
            isfinish = true;
            //demander pourquoi je peux pas mettre le toprint ici
        }

        private void replay_btn_Click(object sender, EventArgs e)
        {

        }

        private void toprint_Click(object sender, EventArgs e)
        {

        }
    }
}
