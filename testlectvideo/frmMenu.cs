using System;
using System.Windows.Forms;

namespace testlectvideo
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void startplay_btn_Click(object sender, EventArgs e)
        {
            frmPlay frmplay = new frmPlay();
            this.Dispose();
            frmplay.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            frmPlay frmPlay = new frmPlay();    
            frmPlay.Close();    
        }
        private void frmExit(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_ToResponsive_Click(object sender, EventArgs e)
        {
            FormResponsive frmplay = new FormResponsive();
            this.Dispose();
            frmplay.Show();
        }
    }
}
