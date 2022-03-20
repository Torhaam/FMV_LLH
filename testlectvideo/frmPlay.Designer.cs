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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.replay_btn = new System.Windows.Forms.Button();
            this.Accelerate_btn = new System.Windows.Forms.Button();
            this.settings_btn = new System.Windows.Forms.Button();
            this.pauseplay_btn = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.toprint = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Stop_btn = new System.Windows.Forms.Button();
            this.btn_firstchoice = new System.Windows.Forms.Button();
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
            this.MainVideo.Location = new System.Drawing.Point(0, 0);
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
            this.Skip_btn.Location = new System.Drawing.Point(662, 6);
            this.Skip_btn.Name = "Skip_btn";
            this.Skip_btn.Size = new System.Drawing.Size(106, 32);
            this.Skip_btn.TabIndex = 6;
            this.Skip_btn.Text = "Skip";
            this.Skip_btn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(267, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 22);
            this.textBox1.TabIndex = 4;
            // 
            // replay_btn
            // 
            this.replay_btn.Location = new System.Drawing.Point(12, 6);
            this.replay_btn.Name = "replay_btn";
            this.replay_btn.Size = new System.Drawing.Size(88, 28);
            this.replay_btn.TabIndex = 7;
            this.replay_btn.Text = "Replay";
            this.replay_btn.UseVisualStyleBackColor = true;
            this.replay_btn.Click += new System.EventHandler(this.replay_btn_Click);
            // 
            // Accelerate_btn
            // 
            this.Accelerate_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Accelerate_btn.Location = new System.Drawing.Point(562, 6);
            this.Accelerate_btn.Name = "Accelerate_btn";
            this.Accelerate_btn.Size = new System.Drawing.Size(94, 32);
            this.Accelerate_btn.TabIndex = 8;
            this.Accelerate_btn.Text = "Accélérer ";
            this.Accelerate_btn.UseVisualStyleBackColor = true;
            // 
            // settings_btn
            // 
            this.settings_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settings_btn.Location = new System.Drawing.Point(12, 114);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(88, 41);
            this.settings_btn.TabIndex = 9;
            this.settings_btn.Text = "Paramètres";
            this.settings_btn.UseVisualStyleBackColor = true;
            // 
            // pauseplay_btn
            // 
            this.pauseplay_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pauseplay_btn.Location = new System.Drawing.Point(484, 6);
            this.pauseplay_btn.Name = "pauseplay_btn";
            this.pauseplay_btn.Size = new System.Drawing.Size(72, 32);
            this.pauseplay_btn.TabIndex = 10;
            this.pauseplay_btn.Text = "Pause";
            this.pauseplay_btn.UseVisualStyleBackColor = true;
            this.pauseplay_btn.Click += new System.EventHandler(this.pauseplay_btn_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_menu.Location = new System.Drawing.Point(359, 49);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(75, 41);
            this.btn_menu.TabIndex = 11;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // toprint
            // 
            this.toprint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toprint.AutoSize = true;
            this.toprint.Location = new System.Drawing.Point(12, 95);
            this.toprint.Name = "toprint";
            this.toprint.Size = new System.Drawing.Size(44, 16);
            this.toprint.TabIndex = 12;
            this.toprint.Text = "label1";
            this.toprint.Click += new System.EventHandler(this.toprint_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Stop_btn);
            this.panel1.Controls.Add(this.btn_firstchoice);
            this.panel1.Controls.Add(this.get_btn);
            this.panel1.Controls.Add(this.MainVideo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 361);
            this.panel1.TabIndex = 13;
            // 
            // Stop_btn
            // 
            this.Stop_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Stop_btn.Location = new System.Drawing.Point(78, 313);
            this.Stop_btn.Name = "Stop_btn";
            this.Stop_btn.Size = new System.Drawing.Size(625, 23);
            this.Stop_btn.TabIndex = 3;
            this.Stop_btn.Text = "STOP";
            this.Stop_btn.UseVisualStyleBackColor = true;
            this.Stop_btn.Click += new System.EventHandler(this.Stop_btn_Click);
            // 
            // btn_firstchoice
            // 
            this.btn_firstchoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_firstchoice.Location = new System.Drawing.Point(78, 284);
            this.btn_firstchoice.Name = "btn_firstchoice";
            this.btn_firstchoice.Size = new System.Drawing.Size(625, 23);
            this.btn_firstchoice.TabIndex = 2;
            this.btn_firstchoice.Text = "1";
            this.btn_firstchoice.UseVisualStyleBackColor = true;
            this.btn_firstchoice.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // get_btn
            // 
            this.get_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.get_btn.Location = new System.Drawing.Point(78, 255);
            this.get_btn.Name = "get_btn";
            this.get_btn.Size = new System.Drawing.Size(625, 23);
            this.get_btn.TabIndex = 1;
            this.get_btn.Text = "GET";
            this.get_btn.UseVisualStyleBackColor = true;
            this.get_btn.Click += new System.EventHandler(this.get_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toprint);
            this.panel2.Controls.Add(this.btn_menu);
            this.panel2.Controls.Add(this.pauseplay_btn);
            this.panel2.Controls.Add(this.settings_btn);
            this.panel2.Controls.Add(this.Accelerate_btn);
            this.panel2.Controls.Add(this.replay_btn);
            this.panel2.Controls.Add(this.Skip_btn);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 170);
            this.panel2.TabIndex = 14;
            // 
            // frmPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 531);
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

        private Vlc.DotNet.Forms.VlcControl MainVideo;
        private System.Windows.Forms.Button Skip_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button replay_btn;
        private System.Windows.Forms.Button Accelerate_btn;
        private System.Windows.Forms.Button settings_btn;
        private System.Windows.Forms.Button pauseplay_btn;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Label toprint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Stop_btn;
        private System.Windows.Forms.Button btn_firstchoice;
        private System.Windows.Forms.Button get_btn;
    }
}

