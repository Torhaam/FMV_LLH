namespace testlectvideo
{
    partial class FrmPlay
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlay));
            this.MainVideo = new Vlc.DotNet.Forms.VlcControl();
            this.replay_btn = new System.Windows.Forms.Button();
            this.pauseplay_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_choice3 = new System.Windows.Forms.Button();
            this.btn_choice2 = new System.Windows.Forms.Button();
            this.btn_choice1 = new System.Windows.Forms.Button();
            this.restart_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.MainVideo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainVideo
            // 
            this.MainVideo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainVideo.BackColor = System.Drawing.Color.Black;
            this.MainVideo.Location = new System.Drawing.Point(-11, 3);
            this.MainVideo.Name = "MainVideo";
            this.MainVideo.Size = new System.Drawing.Size(1043, 409);
            this.MainVideo.Spu = -1;
            this.MainVideo.TabIndex = 0;
            this.MainVideo.Text = "vlcControl1";
            this.MainVideo.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("MainVideo.VlcLibDirectory")));
            this.MainVideo.VlcMediaplayerOptions = null;
            this.MainVideo.EndReached += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerEndReachedEventArgs>(this.MainVideo_EndReached);
            // 
            // replay_btn
            // 
            this.replay_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.replay_btn.BackColor = System.Drawing.Color.Plum;
            this.replay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.replay_btn.Location = new System.Drawing.Point(205, 108);
            this.replay_btn.Name = "replay_btn";
            this.replay_btn.Size = new System.Drawing.Size(88, 28);
            this.replay_btn.TabIndex = 7;
            this.replay_btn.Text = "Replay";
            this.replay_btn.UseVisualStyleBackColor = false;
            this.replay_btn.Click += new System.EventHandler(this.Replay_btn_Click);
            // 
            // pauseplay_btn
            // 
            this.pauseplay_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pauseplay_btn.BackColor = System.Drawing.Color.Plum;
            this.pauseplay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pauseplay_btn.Location = new System.Drawing.Point(477, 19);
            this.pauseplay_btn.Name = "pauseplay_btn";
            this.pauseplay_btn.Size = new System.Drawing.Size(72, 28);
            this.pauseplay_btn.TabIndex = 10;
            this.pauseplay_btn.Text = "Pause";
            this.pauseplay_btn.UseVisualStyleBackColor = false;
            this.pauseplay_btn.Click += new System.EventHandler(this.Pauseplay_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_choice3);
            this.panel1.Controls.Add(this.btn_choice2);
            this.panel1.Controls.Add(this.btn_choice1);
            this.panel1.Controls.Add(this.MainVideo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 412);
            this.panel1.TabIndex = 13;
            // 
            // btn_choice3
            // 
            this.btn_choice3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_choice3.BackColor = System.Drawing.Color.LightCyan;
            this.btn_choice3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_choice3.Location = new System.Drawing.Point(3, 361);
            this.btn_choice3.Name = "btn_choice3";
            this.btn_choice3.Size = new System.Drawing.Size(1026, 23);
            this.btn_choice3.TabIndex = 3;
            this.btn_choice3.Text = "3";
            this.btn_choice3.UseVisualStyleBackColor = false;
            this.btn_choice3.Click += new System.EventHandler(this.Btn_choice3_Click);
            // 
            // btn_choice2
            // 
            this.btn_choice2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_choice2.BackColor = System.Drawing.Color.LightCyan;
            this.btn_choice2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_choice2.Location = new System.Drawing.Point(3, 315);
            this.btn_choice2.Name = "btn_choice2";
            this.btn_choice2.Size = new System.Drawing.Size(1026, 23);
            this.btn_choice2.TabIndex = 2;
            this.btn_choice2.Text = "2";
            this.btn_choice2.UseVisualStyleBackColor = false;
            this.btn_choice2.Click += new System.EventHandler(this.Btn_choice2_Click);
            // 
            // btn_choice1
            // 
            this.btn_choice1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_choice1.BackColor = System.Drawing.Color.LightCyan;
            this.btn_choice1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_choice1.Location = new System.Drawing.Point(3, 271);
            this.btn_choice1.Name = "btn_choice1";
            this.btn_choice1.Size = new System.Drawing.Size(1026, 23);
            this.btn_choice1.TabIndex = 1;
            this.btn_choice1.Text = "1";
            this.btn_choice1.UseVisualStyleBackColor = false;
            this.btn_choice1.Click += new System.EventHandler(this.Btn_choice1_Click);
            // 
            // restart_btn
            // 
            this.restart_btn.BackColor = System.Drawing.Color.Plum;
            this.restart_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restart_btn.Location = new System.Drawing.Point(205, 19);
            this.restart_btn.Name = "restart_btn";
            this.restart_btn.Size = new System.Drawing.Size(144, 28);
            this.restart_btn.TabIndex = 1;
            this.restart_btn.Text = "Revenir au début";
            this.restart_btn.UseVisualStyleBackColor = false;
            this.restart_btn.Click += new System.EventHandler(this.Get_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.restart_btn);
            this.panel2.Controls.Add(this.pauseplay_btn);
            this.panel2.Controls.Add(this.replay_btn);
            this.panel2.Location = new System.Drawing.Point(0, 412);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1032, 175);
            this.panel2.TabIndex = 14;
            // 
            // FrmPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 587);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VLC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmExit);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainVideo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Vlc.DotNet.Forms.VlcControl MainVideo;
        private System.Windows.Forms.Button replay_btn;
        private System.Windows.Forms.Button pauseplay_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button restart_btn;
        private System.Windows.Forms.Button btn_choice3;
        private System.Windows.Forms.Button btn_choice2;
        private System.Windows.Forms.Button btn_choice1;
    }
}

