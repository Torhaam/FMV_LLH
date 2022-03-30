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
            this.label3 = new System.Windows.Forms.Label();
            this.Media_submenu_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_openmedia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SideMenu_Panel.SuspendLayout();
            this.Media_submenu_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // startedtime
            // 
            this.startedtime.Enabled = true;
            this.startedtime.Tick += new System.EventHandler(this.startedtime_Tick);
            // 
            // SideMenu_Panel
            // 
            this.SideMenu_Panel.BackColor = System.Drawing.Color.LavenderBlush;
            this.SideMenu_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SideMenu_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SideMenu_Panel.Controls.Add(this.label3);
            this.SideMenu_Panel.Controls.Add(this.Media_submenu_panel);
            this.SideMenu_Panel.Controls.Add(this.label2);
            this.SideMenu_Panel.Controls.Add(this.btn_openmedia);
            this.SideMenu_Panel.Controls.Add(this.label1);
            this.SideMenu_Panel.Controls.Add(this.panelLogo);
            this.SideMenu_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu_Panel.Location = new System.Drawing.Point(0, 0);
            this.SideMenu_Panel.Name = "SideMenu_Panel";
            this.SideMenu_Panel.Size = new System.Drawing.Size(250, 587);
            this.SideMenu_Panel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(52, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom chapitre 3";
            // 
            // Media_submenu_panel
            // 
            this.Media_submenu_panel.BackColor = System.Drawing.Color.LavenderBlush;
            this.Media_submenu_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Media_submenu_panel.Controls.Add(this.button1);
            this.Media_submenu_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Media_submenu_panel.Location = new System.Drawing.Point(0, 145);
            this.Media_submenu_panel.Name = "Media_submenu_panel";
            this.Media_submenu_panel.Size = new System.Drawing.Size(246, 41);
            this.Media_submenu_panel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(52, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom chapitre 2";
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
            this.btn_openmedia.Click += new System.EventHandler(this.btn_openmedia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(52, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom chapitre 1";
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
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmExit);
            this.SideMenu_Panel.ResumeLayout(false);
            this.SideMenu_Panel.PerformLayout();
            this.Media_submenu_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideMenu_Panel;
        private System.Windows.Forms.Panel Media_submenu_panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_openmedia;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer startedtime;
    }
}