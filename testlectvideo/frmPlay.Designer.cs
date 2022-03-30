namespace testlectvideo
{
    partial class frmPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlay));
            this.MainVideo = new Vlc.DotNet.Forms.VlcControl();
            this.Skip_btn = new System.Windows.Forms.Button();
            this.replay_btn = new System.Windows.Forms.Button();
            this.Accelerate_btn = new System.Windows.Forms.Button();
            this.settings_btn = new System.Windows.Forms.Button();
            this.pauseplay_btn = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.toprint = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_choice3 = new System.Windows.Forms.Button();
            this.btn_choice2 = new System.Windows.Forms.Button();
            this.btn_choice1 = new System.Windows.Forms.Button();
            this.Stop_btn = new System.Windows.Forms.Button();
            this.btn_isfinish = new System.Windows.Forms.Button();
            this.get_btn = new System.Windows.Forms.Button();
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
            this.MainVideo.Location = new System.Drawing.Point(125, 0);
            this.MainVideo.Name = "MainVideo";
            this.MainVideo.Size = new System.Drawing.Size(782, 355);
            this.MainVideo.Spu = -1;
            this.MainVideo.TabIndex = 0;
            this.MainVideo.Text = "vlcControl1";
            this.MainVideo.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("MainVideo.VlcLibDirectory")));
            this.MainVideo.VlcMediaplayerOptions = null;
            this.MainVideo.EndReached += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerEndReachedEventArgs>(this.MainVideo_EndReached);
            // 
            // Skip_btn
            // 
            this.Skip_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Skip_btn.BackColor = System.Drawing.Color.Plum;
            this.Skip_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Skip_btn.Location = new System.Drawing.Point(912, 6);
            this.Skip_btn.Name = "Skip_btn";
            this.Skip_btn.Size = new System.Drawing.Size(106, 32);
            this.Skip_btn.TabIndex = 6;
            this.Skip_btn.Text = "Skip";
            this.Skip_btn.UseVisualStyleBackColor = false;
            // 
            // replay_btn
            // 
            this.replay_btn.BackColor = System.Drawing.Color.Plum;
            this.replay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.replay_btn.Location = new System.Drawing.Point(12, 6);
            this.replay_btn.Name = "replay_btn";
            this.replay_btn.Size = new System.Drawing.Size(88, 28);
            this.replay_btn.TabIndex = 7;
            this.replay_btn.Text = "Replay";
            this.replay_btn.UseVisualStyleBackColor = false;
            this.replay_btn.Click += new System.EventHandler(this.replay_btn_Click);
            // 
            // Accelerate_btn
            // 
            this.Accelerate_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Accelerate_btn.BackColor = System.Drawing.Color.Plum;
            this.Accelerate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Accelerate_btn.Location = new System.Drawing.Point(812, 6);
            this.Accelerate_btn.Name = "Accelerate_btn";
            this.Accelerate_btn.Size = new System.Drawing.Size(94, 32);
            this.Accelerate_btn.TabIndex = 8;
            this.Accelerate_btn.Text = "Accélérer ";
            this.Accelerate_btn.UseVisualStyleBackColor = false;
            // 
            // settings_btn
            // 
            this.settings_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settings_btn.BackColor = System.Drawing.Color.Plum;
            this.settings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.settings_btn.Location = new System.Drawing.Point(12, 170);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(88, 41);
            this.settings_btn.TabIndex = 9;
            this.settings_btn.Text = "Paramètres";
            this.settings_btn.UseVisualStyleBackColor = false;
            // 
            // pauseplay_btn
            // 
            this.pauseplay_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pauseplay_btn.BackColor = System.Drawing.Color.Plum;
            this.pauseplay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pauseplay_btn.Location = new System.Drawing.Point(734, 6);
            this.pauseplay_btn.Name = "pauseplay_btn";
            this.pauseplay_btn.Size = new System.Drawing.Size(72, 32);
            this.pauseplay_btn.TabIndex = 10;
            this.pauseplay_btn.Text = "Pause";
            this.pauseplay_btn.UseVisualStyleBackColor = false;
            this.pauseplay_btn.Click += new System.EventHandler(this.pauseplay_btn_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_menu.BackColor = System.Drawing.Color.Plum;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_menu.Location = new System.Drawing.Point(484, 77);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(75, 41);
            this.btn_menu.TabIndex = 11;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // toprint
            // 
            this.toprint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toprint.AutoSize = true;
            this.toprint.Location = new System.Drawing.Point(12, 151);
            this.toprint.Name = "toprint";
            this.toprint.Size = new System.Drawing.Size(44, 16);
            this.toprint.TabIndex = 12;
            this.toprint.Text = "label1";
            this.toprint.Click += new System.EventHandler(this.toprint_Click);
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
            this.panel1.Size = new System.Drawing.Size(1032, 361);
            this.panel1.TabIndex = 13;
            // 
            // btn_choice3
            // 
            this.btn_choice3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_choice3.BackColor = System.Drawing.Color.LightCyan;
            this.btn_choice3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_choice3.Location = new System.Drawing.Point(15, 310);
            this.btn_choice3.Name = "btn_choice3";
            this.btn_choice3.Size = new System.Drawing.Size(1003, 23);
            this.btn_choice3.TabIndex = 3;
            this.btn_choice3.Text = "3";
            this.btn_choice3.UseVisualStyleBackColor = false;
            this.btn_choice3.Click += new System.EventHandler(this.btn_choice3_Click);
            // 
            // btn_choice2
            // 
            this.btn_choice2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_choice2.BackColor = System.Drawing.Color.LightCyan;
            this.btn_choice2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_choice2.Location = new System.Drawing.Point(15, 264);
            this.btn_choice2.Name = "btn_choice2";
            this.btn_choice2.Size = new System.Drawing.Size(1003, 23);
            this.btn_choice2.TabIndex = 2;
            this.btn_choice2.Text = "2";
            this.btn_choice2.UseVisualStyleBackColor = false;
            this.btn_choice2.Click += new System.EventHandler(this.btn_choice2_Click);
            // 
            // btn_choice1
            // 
            this.btn_choice1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_choice1.BackColor = System.Drawing.Color.LightCyan;
            this.btn_choice1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_choice1.Location = new System.Drawing.Point(15, 220);
            this.btn_choice1.Name = "btn_choice1";
            this.btn_choice1.Size = new System.Drawing.Size(1003, 23);
            this.btn_choice1.TabIndex = 1;
            this.btn_choice1.Text = "1";
            this.btn_choice1.UseVisualStyleBackColor = false;
            this.btn_choice1.Click += new System.EventHandler(this.btn_choice1_Click);
            // 
            // Stop_btn
            // 
            this.Stop_btn.BackColor = System.Drawing.Color.Plum;
            this.Stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Stop_btn.Location = new System.Drawing.Point(246, 11);
            this.Stop_btn.Name = "Stop_btn";
            this.Stop_btn.Size = new System.Drawing.Size(84, 23);
            this.Stop_btn.TabIndex = 3;
            this.Stop_btn.Text = "STOP";
            this.Stop_btn.UseVisualStyleBackColor = false;
            this.Stop_btn.Click += new System.EventHandler(this.Stop_btn_Click);
            // 
            // btn_isfinish
            // 
            this.btn_isfinish.BackColor = System.Drawing.Color.Plum;
            this.btn_isfinish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_isfinish.Location = new System.Drawing.Point(12, 48);
            this.btn_isfinish.Name = "btn_isfinish";
            this.btn_isfinish.Size = new System.Drawing.Size(63, 23);
            this.btn_isfinish.TabIndex = 2;
            this.btn_isfinish.Text = "isfinish";
            this.btn_isfinish.UseVisualStyleBackColor = false;
            this.btn_isfinish.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // get_btn
            // 
            this.get_btn.BackColor = System.Drawing.Color.Plum;
            this.get_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.get_btn.Location = new System.Drawing.Point(125, 11);
            this.get_btn.Name = "get_btn";
            this.get_btn.Size = new System.Drawing.Size(115, 23);
            this.get_btn.TabIndex = 1;
            this.get_btn.Text = "GET";
            this.get_btn.UseVisualStyleBackColor = false;
            this.get_btn.Click += new System.EventHandler(this.get_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_isfinish);
            this.panel2.Controls.Add(this.Stop_btn);
            this.panel2.Controls.Add(this.toprint);
            this.panel2.Controls.Add(this.btn_menu);
            this.panel2.Controls.Add(this.get_btn);
            this.panel2.Controls.Add(this.pauseplay_btn);
            this.panel2.Controls.Add(this.settings_btn);
            this.panel2.Controls.Add(this.Accelerate_btn);
            this.panel2.Controls.Add(this.replay_btn);
            this.panel2.Controls.Add(this.Skip_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1032, 226);
            this.panel2.TabIndex = 14;
            // 
            // frmPlay
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
            this.Name = "frmPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VLC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmExit);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainVideo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Vlc.DotNet.Forms.VlcControl MainVideo;
        private System.Windows.Forms.Button Skip_btn;
        private System.Windows.Forms.Button replay_btn;
        private System.Windows.Forms.Button Accelerate_btn;
        private System.Windows.Forms.Button settings_btn;
        private System.Windows.Forms.Button pauseplay_btn;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Label toprint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Stop_btn;
        private System.Windows.Forms.Button btn_isfinish;
        private System.Windows.Forms.Button get_btn;
        private System.Windows.Forms.Button btn_choice3;
        private System.Windows.Forms.Button btn_choice2;
        private System.Windows.Forms.Button btn_choice1;
    }
}

