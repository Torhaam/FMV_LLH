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
        public FormResponsive()
        {
            InitializeComponent();
            customize();
        }
        private void customize()
        {
            Media_submenu_panel.Visible = false;
            //mettre tout les panel de sous menu à false ici
        }
        private void frmExit(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void hideSubMenu()
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
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;    
            }
            //mettre la même méthode pour tout les panels
        }

        private void btn_openmedia_Click(object sender, EventArgs e)
        {
            ShowSubMenu(Media_submenu_panel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPlay());
           
            hideSubMenu();
        }
        private void openChildForm(Form ChildForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(ChildForm);  
            MainPanel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
    }
}
