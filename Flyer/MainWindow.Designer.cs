namespace Flyer
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.pic_IconAkku = new System.Windows.Forms.PictureBox();
            this.lbl_IconAkku = new System.Windows.Forms.Label();
            this.pic_IconModell = new System.Windows.Forms.PictureBox();
            this.lbl_IconModell = new System.Windows.Forms.Label();
            this.pic_Background = new System.Windows.Forms.PictureBox();
            this.lblIconInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_IconAkku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_IconModell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Background)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_IconAkku
            // 
            this.pic_IconAkku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_IconAkku.Image = global::Flyer.Properties.Resources.handy_akku_1m;
            this.pic_IconAkku.Location = new System.Drawing.Point(64, 39);
            this.pic_IconAkku.Margin = new System.Windows.Forms.Padding(4);
            this.pic_IconAkku.Name = "pic_IconAkku";
            this.pic_IconAkku.Size = new System.Drawing.Size(67, 62);
            this.pic_IconAkku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_IconAkku.TabIndex = 0;
            this.pic_IconAkku.TabStop = false;
            this.pic_IconAkku.Click += new System.EventHandler(this.pic_IconAkku_Click);
            // 
            // lbl_IconAkku
            // 
            this.lbl_IconAkku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_IconAkku.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IconAkku.ForeColor = System.Drawing.Color.Navy;
            this.lbl_IconAkku.Location = new System.Drawing.Point(44, 106);
            this.lbl_IconAkku.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IconAkku.Name = "lbl_IconAkku";
            this.lbl_IconAkku.Size = new System.Drawing.Size(107, 49);
            this.lbl_IconAkku.TabIndex = 2;
            this.lbl_IconAkku.Text = "Akkudaten berechnen";
            this.lbl_IconAkku.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_IconAkku.Click += new System.EventHandler(this.lbl_IconAkku_Click);
            // 
            // pic_IconModell
            // 
            this.pic_IconModell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_IconModell.Image = global::Flyer.Properties.Resources.Anreise_Flugzeug_AUSTROFOMA;
            this.pic_IconModell.Location = new System.Drawing.Point(223, 39);
            this.pic_IconModell.Margin = new System.Windows.Forms.Padding(4);
            this.pic_IconModell.Name = "pic_IconModell";
            this.pic_IconModell.Size = new System.Drawing.Size(67, 62);
            this.pic_IconModell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_IconModell.TabIndex = 5;
            this.pic_IconModell.TabStop = false;
            this.pic_IconModell.Visible = false;
            // 
            // lbl_IconModell
            // 
            this.lbl_IconModell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_IconModell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IconModell.ForeColor = System.Drawing.Color.Navy;
            this.lbl_IconModell.Location = new System.Drawing.Point(203, 106);
            this.lbl_IconModell.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IconModell.Name = "lbl_IconModell";
            this.lbl_IconModell.Size = new System.Drawing.Size(107, 49);
            this.lbl_IconModell.TabIndex = 6;
            this.lbl_IconModell.Text = "Modellldaten berechnen";
            this.lbl_IconModell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_IconModell.Visible = false;
            // 
            // pic_Background
            // 
            this.pic_Background.Image = global::Flyer.Properties.Resources.papierflugzeug;
            this.pic_Background.Location = new System.Drawing.Point(614, 13);
            this.pic_Background.Margin = new System.Windows.Forms.Padding(4);
            this.pic_Background.Name = "pic_Background";
            this.pic_Background.Size = new System.Drawing.Size(355, 229);
            this.pic_Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Background.TabIndex = 11;
            this.pic_Background.TabStop = false;
            // 
            // lblIconInfo
            // 
            this.lblIconInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIconInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconInfo.ForeColor = System.Drawing.Color.Navy;
            this.lblIconInfo.Location = new System.Drawing.Point(862, 525);
            this.lblIconInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIconInfo.Name = "lblIconInfo";
            this.lblIconInfo.Size = new System.Drawing.Size(107, 39);
            this.lblIconInfo.TabIndex = 13;
            this.lblIconInfo.Text = "Info";
            this.lblIconInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblIconInfo.Click += new System.EventHandler(this.lbl_IconInfo_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 573);
            this.Controls.Add(this.lblIconInfo);
            this.Controls.Add(this.pic_Background);
            this.Controls.Add(this.pic_IconModell);
            this.Controls.Add(this.pic_IconAkku);
            this.Controls.Add(this.lbl_IconModell);
            this.Controls.Add(this.lbl_IconAkku);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flyer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_IconAkku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_IconModell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Background)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_IconAkku;
        private System.Windows.Forms.Label lbl_IconAkku;
        private System.Windows.Forms.PictureBox pic_IconModell;
        private System.Windows.Forms.Label lbl_IconModell;
        private System.Windows.Forms.PictureBox pic_Background;
        private System.Windows.Forms.Label lblIconInfo;


    }
}

