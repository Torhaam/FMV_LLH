using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;


namespace testlectvideo
{
    public partial class frmPlay : Form
    {
        public static frmPlay instance;
        private bool pause = false;
        private bool isfinish = false;
        private FormResponsive parent = null;
        public static string chapter1;
        private Button choice1;
        private Button choice2;
        private Button choice3;
        public FormResponsive Parent1 { get => parent; set => parent = value; }
        public frmPlay()
        {
            InitializeComponent();
            instance = this;
            choice1 = btn_choice1;
            choice2 = btn_choice2;
            choice3 = btn_choice3;
            choice1.Visible = false;
            choice2.Visible = false;
            choice3.Visible = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void get_btn_Click(object sender, EventArgs e)
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var iconPath = Path.Combine(outPutDirectory, "../Ressources\\");
            string icon_path = new Uri(iconPath).LocalPath + "firstvideoigot.mp4";
            toprint.Text = iconPath;
            MainVideo.Play(new Uri(icon_path));
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

            if (pause == true)
            {
                MainVideo.Play();
                pauseplay_btn.Text = "PAUSE";
                pause = false;
            }
            else if (pause == false)
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
        private void showorhide_choices()
        {

            if (choice1.Visible == false && choice2.Visible == false && choice3.Visible == false)
            {
                choice1.Invoke(new MethodInvoker(delegate { choice1.Visible = true; }));
                choice2.Invoke(new MethodInvoker(delegate { choice2.Visible = true; }));
                choice3.Invoke(new MethodInvoker(delegate { choice3.Visible = true; }));
            }
            else
            {
                choice1.Invoke(new MethodInvoker(delegate { choice1.Visible = false; }));
                choice2.Invoke(new MethodInvoker(delegate { choice2.Visible = false; }));
                choice3.Invoke(new MethodInvoker(delegate { choice3.Visible = false; }));
            }

        }
    
           
        
            private void MainVideo_EndReached(object sender, Vlc.DotNet.Core.VlcMediaPlayerEndReachedEventArgs e)
            {
                isfinish = true;
                chapter1 = "ENFIN";
                var threadParameters = new System.Threading.ThreadStart(delegate { showorhide_choices(); });
                var thread2 = new System.Threading.Thread(threadParameters);
                thread2.Start();
                showorhide_choices();
                //demander pourquoi je peux pas mettre le toprint ici
            }

            private void replay_btn_Click(object sender, EventArgs e)
            {

            }

            private void toprint_Click(object sender, EventArgs e)
            {

            }

        private void btn_choice1_Click(object sender, EventArgs e)
        {
            showorhide_choices();
        }

        private void btn_choice2_Click(object sender, EventArgs e)
        {
            showorhide_choices();
        }

        private void btn_choice3_Click(object sender, EventArgs e)
        {
            showorhide_choices();
        }
    }
    } 
