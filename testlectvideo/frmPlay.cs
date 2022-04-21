using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;



namespace testlectvideo
{
    public partial class FrmPlay : Form
    {
        public static FrmPlay instance;
        private FormResponsive parent = null;
        private bool pause = false;
        private int current_chapter = 1;
        private Boolean buttonsvisible;

        public static string chapter1;
        public static string chapter2;
        public static string chapter3;

        private readonly Button choice1;
        private readonly Button choice2;
        private readonly Button choice3;
        private readonly Button enablerestart;

        private Video startVideo;
        private Video currentVideo;

        private Video Videofirstchoice1;
        private Video Videofirstchoice2;
        private Video Videofirstchoice3;

        private Video VideoChoice1_1;
        private Video VideoChoice1_2;
        private Video VideoChoice1_3;

        private Video VideoChoice2_1;
        private Video VideoChoice2_2;
        private Video VideoChoice2_3;

        private Video VideoChoice3_1;
        private Video VideoChoice3_2;
        private Video VideoChoice3_3;
        
        public FormResponsive Parent1 { get => parent; set => parent = value; }
        public FrmPlay()
        {
            InitializeComponent();
            instance = this;
            choice1 = btn_choice1;
            choice2 = btn_choice2;
            choice3 = btn_choice3;
            enablerestart = restart_btn;
            choice1.Visible = false;
            choice2.Visible = false;
            choice3.Visible = false;
            Loadvid();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Restart();
            enablerestart.Visible = false;
        }
        private void FrmExit(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //METHODES
        private void LaunchVideo()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var iconPath = Path.Combine(outPutDirectory, "../Ressources\\");
            string icon_path = new Uri(iconPath).LocalPath + currentVideo.Url;

            MainVideo.Play(new Uri(icon_path));
        }
        private void Showorhide_choices()
        {

            if (choice1.Visible == false && choice2.Visible == false && choice3.Visible == false)
            {
                choice1.Invoke(new MethodInvoker(delegate { choice1.Visible = true; }));
                choice2.Invoke(new MethodInvoker(delegate { choice2.Visible = true; }));
                choice3.Invoke(new MethodInvoker(delegate { choice3.Visible = true; }));
                buttonsvisible = true;
            }
            else
            {
                choice1.Invoke(new MethodInvoker(delegate { choice1.Visible = false; }));
                choice2.Invoke(new MethodInvoker(delegate { choice2.Visible = false; }));
                choice3.Invoke(new MethodInvoker(delegate { choice3.Visible = false; }));
                buttonsvisible = false;
            }

        }
        private void Restart()
        {
            MainVideo.Stop();
            current_chapter = 1;
            chapter1 = "";
            chapter2 = "";
            chapter3 = "";
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var iconPath = Path.Combine(outPutDirectory, "../Ressources\\");
            string icon_path = new Uri(iconPath).LocalPath + startVideo.Url;
            MainVideo.Play(new Uri(icon_path));
        }
        private void Loadvid()
        {
            startVideo = new Video("firstvideoigot.mp4", "Beginning", "La première vidéo", 1);

            Videofirstchoice1 = new Video("zoup.mp4", "Allez, letsgong", "Choix 1 de Beginning", 1);
            Videofirstchoice2 = new Video("wow.mov", "drip", "Choix 2 de Beginning", 2);
            Videofirstchoice3 = new Video("miam.mp4", "potitchien", "Choix 3 de Beginning", 3);

            VideoChoice1_3 = new Video("oiseau.mp4", "ce être un oiseau", "Choix 3 de Allez letsgong", 1);
            VideoChoice2_3 = new Video("metro.mp4", "le metro", "Choix 3 de drip", 2);
            VideoChoice3_3 = new Video("canne.mp4", "la canne", "Choix 3 de potitchien", 3);

            VideoChoice1_2 = new Video("oiseau.mp4", "ce être un oiseau", "Choix 2 de Allez letsgong", 1);
            VideoChoice2_2 = new Video("metro.mp4", "le metro", "Choix 2 de drip", 2);
            VideoChoice3_2 = new Video("canne.mp4", "la canne", "Choix 2 de potitchien", 3);

            VideoChoice1_1 = new Video("oiseau.mp4", "ce être un oiseau", "Choix 3 de Allez letsgong", 1);
            VideoChoice2_1 = new Video("metro.mp4", "le metro", "Choix 3 de drip", 2);
            VideoChoice3_1 = new Video("canne.mp4", "la canne", "Choix 3 de potitchien", 3);
        }

        //EVENEMENTS

        private void MainVideo_EndReached(object sender, Vlc.DotNet.Core.VlcMediaPlayerEndReachedEventArgs e)
        {
            switch (current_chapter)
            {
                case 1:
                    chapter1 = startVideo.Title;
                    Showorhide_choices();
                    
                    break;
               
                case 2:
                    chapter2 = currentVideo.Title;
                    Showorhide_choices();
                    
                    break;

                case 3:
                    chapter3 = currentVideo.Title;
                    enablerestart.Invoke(new MethodInvoker(delegate { enablerestart.Visible = true; }));
                    break;

            }
        }

        private void Replay_btn_Click(object sender, EventArgs e)
        {
            if (current_chapter == 1)
            {
                Restart();
            }else 
            {  
                LaunchVideo();
            }
            
            if (buttonsvisible == true)
            {
                Showorhide_choices();
            }
        }
        private void Get_btn_Click(object sender, EventArgs e)
        {
            Restart();
        }


        private void Pauseplay_btn_Click(object sender, EventArgs e)
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


        private void Btn_choice1_Click(object sender, EventArgs e)
        {
            Showorhide_choices();
            current_chapter++;
            if(current_chapter == 2)
            {
                currentVideo = Videofirstchoice1;
                LaunchVideo();
            }
            else if (current_chapter == 3)
            {
                switch (currentVideo.Choice)
                {
                    case 1:
                        currentVideo = VideoChoice1_1;
                        LaunchVideo();
                        break;
                    case 2:
                        currentVideo = VideoChoice2_1;
                        LaunchVideo();
                        break;
                    case 3:
                        currentVideo = VideoChoice3_1;
                        LaunchVideo();
                        break;
                }
            }
        }

        private void Btn_choice2_Click(object sender, EventArgs e)
        {
            Showorhide_choices();
            current_chapter++;
            if (current_chapter == 2)
            {
                currentVideo = Videofirstchoice2;
                LaunchVideo();
            }
            else if (current_chapter == 3)
            {
                switch (currentVideo.Choice)
                {
                    case 1:
                        currentVideo = VideoChoice1_2;
                        LaunchVideo();
                        break;
                    case 2:
                        currentVideo = VideoChoice2_2;
                        LaunchVideo();
                        break;
                    case 3:
                        currentVideo = VideoChoice3_2;
                        LaunchVideo();
                        break;
                }
            }
        }

        private void Btn_choice3_Click(object sender, EventArgs e)
        {
            Showorhide_choices();
            current_chapter++;
            if (current_chapter == 2)
            {
                currentVideo = Videofirstchoice3;
                LaunchVideo();
            }
            else if(current_chapter == 3)
            {
                switch (currentVideo.Choice)
                {
                    case 1:
                        currentVideo = VideoChoice1_3;
                        LaunchVideo();
                        break;
                    case 2:
                        currentVideo = VideoChoice2_3;
                        LaunchVideo();
                        break;
                    case 3:
                        currentVideo = VideoChoice3_3;
                        LaunchVideo();
                        break;
                }
            }
        }
        
        
    }
          
    }
