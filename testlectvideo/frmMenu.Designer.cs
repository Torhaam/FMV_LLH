namespace testlectvideo
{
    partial class frmMenu
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
            this.startplay_btn = new System.Windows.Forms.Button();
            this.Btn_ToResponsive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startplay_btn
            // 
            this.startplay_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startplay_btn.Location = new System.Drawing.Point(299, 161);
            this.startplay_btn.Name = "startplay_btn";
            this.startplay_btn.Size = new System.Drawing.Size(181, 66);
            this.startplay_btn.TabIndex = 0;
            this.startplay_btn.Text = "Start";
            this.startplay_btn.UseVisualStyleBackColor = true;
            this.startplay_btn.Click += new System.EventHandler(this.Startplay_btn_Click);
            // 
            // Btn_ToResponsive
            // 
            this.Btn_ToResponsive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ToResponsive.Location = new System.Drawing.Point(299, 252);
            this.Btn_ToResponsive.Name = "Btn_ToResponsive";
            this.Btn_ToResponsive.Size = new System.Drawing.Size(181, 64);
            this.Btn_ToResponsive.TabIndex = 1;
            this.Btn_ToResponsive.Text = "To Responsive";
            this.Btn_ToResponsive.UseVisualStyleBackColor = true;
            this.Btn_ToResponsive.Click += new System.EventHandler(this.Btn_ToResponsive_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_ToResponsive);
            this.Controls.Add(this.startplay_btn);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmExit);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startplay_btn;
        private System.Windows.Forms.Button Btn_ToResponsive;
    }
}