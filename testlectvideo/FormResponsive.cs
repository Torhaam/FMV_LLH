using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testlectvideo
{
    public partial class FormResponsive : Form
    {
        private Form activeForm=null;
        public static FormResponsive instance;
        public Label l1;
        public Label l2;
        public Label l3;
        public FormResponsive()
        {
            InitializeComponent();
            instance=this;
            Customize();
            
            l1 = lbl_chap1;
            l2 = lbl_chap2;
            l3 = lbl_chap3;
        }
        private void Customize()
        {
            Media_submenu_panel.Visible = false;
            //mettre tout les panel de sous menu à false ici
        }
        private void FrmExit(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void HideSubMenu()
        {
            if (Media_submenu_panel.Visible == true)
            {
                Media_submenu_panel.Visible = false;
            }
            //mettre la même méthode pour tout les panels
        }
        private void ShowSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;    
            }
            //mettre la même méthode pour tout les panels
        }

        private void Btn_openmedia_Click(object sender, EventArgs e)
        {
            ShowSubMenu(Media_submenu_panel);
        }

        private void Btn_Game_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmPlay());
            HideSubMenu();
        }
        private void OpenChildForm(Form ChildForm)
        {
            MainPanel.BackgroundImage = null;
            if(activeForm != null)
            {
                //ici
                activeForm.Close();
            }
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(ChildForm);  
            MainPanel.Tag = ChildForm;
            ChildForm.BringToFront();
            /*if(ChildForm is frmPlay)
            {
                //((frmPlay)ChildForm).Parent1 = this;
                ((frmPlay)ChildForm).MainVideo.EndReached += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerEndReachedEventArgs>(changeChapter);
            }*/
            ChildForm.Show();
        }
        public void Change_chapter(String message)
        {
            lbl_chap1.Text = message;
        }

        private void Startedtime_Tick(object sender, EventArgs e)
        {
            if (activeForm is FrmPlay) { 
                l1.Text = FrmPlay.chapter1;
                l2.Text = FrmPlay.chapter2;
                l3.Text = FrmPlay.chapter3;
            }
        }

        private void Btn_options_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormOptions());
            HideSubMenu();
        }
    }
}
