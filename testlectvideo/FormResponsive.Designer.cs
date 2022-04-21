namespace testlectvideo
{
    partial class FormResponsive
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startedtime = new System.Windows.Forms.Timer(this.components);
            this.SideMenu_Panel = new System.Windows.Forms.Panel();
            this.lbl_chap3 = new System.Windows.Forms.Label();
            this.Media_submenu_panel = new System.Windows.Forms.Panel();
            this.btn_Game = new System.Windows.Forms.Button();
            this.lbl_chap2 = new System.Windows.Forms.Label();
            this.btn_openmedia = new System.Windows.Forms.Button();
            this.lbl_chap1 = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btn_options = new System.Windows.Forms.Button();
            this.SideMenu_Panel.SuspendLayout();
            this.Media_submenu_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // startedtime
            // 
            this.startedtime.Enabled = true;
            this.startedtime.Tick += new System.EventHandler(this.Startedtime_Tick);
            // 
            // SideMenu_Panel
            // 
            this.SideMenu_Panel.BackColor = System.Drawing.Color.LavenderBlush;
            this.SideMenu_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SideMenu_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SideMenu_Panel.Controls.Add(this.lbl_chap3);
            this.SideMenu_Panel.Controls.Add(this.Media_submenu_panel);
            this.SideMenu_Panel.Controls.Add(this.lbl_chap2);
            this.SideMenu_Panel.Controls.Add(this.btn_openmedia);
            this.SideMenu_Panel.Controls.Add(this.lbl_chap1);
            this.SideMenu_Panel.Controls.Add(this.panelLogo);
            this.SideMenu_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu_Panel.Location = new System.Drawing.Point(0, 0);
            this.SideMenu_Panel.Name = "SideMenu_Panel";
            this.SideMenu_Panel.Size = new System.Drawing.Size(250, 587);
            this.SideMenu_Panel.TabIndex = 0;
            // 
            // lbl_chap3
            // 
            this.lbl_chap3.AutoSize = true;
            this.lbl_chap3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_chap3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_chap3.Location = new System.Drawing.Point(52, 471);
            this.lbl_chap3.Name = "lbl_chap3";
            this.lbl_chap3.Size = new System.Drawing.Size(2, 22);
            this.lbl_chap3.TabIndex = 2;
            // 
            // Media_submenu_panel
            // 
            this.Media_submenu_panel.BackColor = System.Drawing.Color.LavenderBlush;
            this.Media_submenu_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Media_submenu_panel.Controls.Add(this.btn_options);
            this.Media_submenu_panel.Controls.Add(this.btn_Game);
            this.Media_submenu_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Media_submenu_panel.Location = new System.Drawing.Point(0, 145);
            this.Media_submenu_panel.Name = "Media_submenu_panel";
            this.Media_submenu_panel.Size = new System.Drawing.Size(246, 134);
            this.Media_submenu_panel.TabIndex = 2;
            // 
            // btn_Game
            // 
            this.btn_Game.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Game.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Game.FlatAppearance.BorderSize = 0;
            this.btn_Game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Game.Location = new System.Drawing.Point(0, 0);
            this.btn_Game.Name = "btn_Game";
            this.btn_Game.Size = new System.Drawing.Size(246, 50);
            this.btn_Game.TabIndex = 0;
            this.btn_Game.Text = "Play";
            this.btn_Game.UseVisualStyleBackColor = false;
            this.btn_Game.Click += new System.EventHandler(this.Btn_Game_Click);
            // 
            // lbl_chap2
            // 
            this.lbl_chap2.AutoSize = true;
            this.lbl_chap2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_chap2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_chap2.Location = new System.Drawing.Point(52, 427);
            this.lbl_chap2.Name = "lbl_chap2";
            this.lbl_chap2.Size = new System.Drawing.Size(2, 22);
            this.lbl_chap2.TabIndex = 1;
            // 
            // btn_openmedia
            // 
            this.btn_openmedia.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btn_openmedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_openmedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_openmedia.FlatAppearance.BorderSize = 0;
            this.btn_openmedia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_openmedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_openmedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openmedia.Location = new System.Drawing.Point(0, 100);
            this.btn_openmedia.Name = "btn_openmedia";
            this.btn_openmedia.Size = new System.Drawing.Size(246, 45);
            this.btn_openmedia.TabIndex = 1;
            this.btn_openmedia.Text = "Media";
            this.btn_openmedia.UseVisualStyleBackColor = false;
            this.btn_openmedia.Click += new System.EventHandler(this.Btn_openmedia_Click);
            // 
            // lbl_chap1
            // 
            this.lbl_chap1.AutoSize = true;
            this.lbl_chap1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_chap1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_chap1.Location = new System.Drawing.Point(52, 382);
            this.lbl_chap1.Name = "lbl_chap1";
            this.lbl_chap1.Size = new System.Drawing.Size(2, 22);
            this.lbl_chap1.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.LavenderBlush;
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(246, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Salmon;
            this.MainPanel.BackgroundImage = global::testlectvideo.Properties.Resources._57_compressed1;
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(250, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(883, 587);
            this.MainPanel.TabIndex = 2;
            // 
            // btn_options
            // 
            this.btn_options.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btn_options.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_options.FlatAppearance.BorderSize = 0;
            this.btn_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_options.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_options.Location = new System.Drawing.Point(0, 50);
            this.btn_options.Name = "btn_options";
            this.btn_options.Size = new System.Drawing.Size(246, 51);
            this.btn_options.TabIndex = 1;
            this.btn_options.Text = "Options";
            this.btn_options.UseVisualStyleBackColor = false;
            this.btn_options.Click += new System.EventHandler(this.Btn_options_Click);
            // 
            // FormResponsive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 587);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SideMenu_Panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormResponsive";
            this.Text = "FMV";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmExit);
            this.SideMenu_Panel.ResumeLayout(false);
            this.SideMenu_Panel.PerformLayout();
            this.Media_submenu_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideMenu_Panel;
        private System.Windows.Forms.Panel Media_submenu_panel;
        private System.Windows.Forms.Button btn_Game;
        private System.Windows.Forms.Button btn_openmedia;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label lbl_chap2;
        private System.Windows.Forms.Label lbl_chap1;
        private System.Windows.Forms.Label lbl_chap3;
        private System.Windows.Forms.Timer startedtime;
        private System.Windows.Forms.Button btn_options;
    }
}