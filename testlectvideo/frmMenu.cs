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

        private void Startplay_btn_Click(object sender, EventArgs e)
        {
            FrmPlay frmplay = new FrmPlay();
            this.Dispose();
            frmplay.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            FrmPlay frmPlay = new FrmPlay();    
            frmPlay.Close();    
        }
        private void FrmExit(object sender, FormClosedEventArgs e)
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
