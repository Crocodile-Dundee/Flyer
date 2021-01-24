namespace Flyer
{
    partial class InfoWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
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
            this.tbl_LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.log_PictureBox = new System.Windows.Forms.PictureBox();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.lbl_Copyright = new System.Windows.Forms.Label();
            this.lbl_CompanyName = new System.Windows.Forms.Label();
            this.txt_BoxDescription = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.tbl_LayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.log_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_LayoutPanel
            // 
            this.tbl_LayoutPanel.ColumnCount = 2;
            this.tbl_LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tbl_LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tbl_LayoutPanel.Controls.Add(this.log_PictureBox, 0, 0);
            this.tbl_LayoutPanel.Controls.Add(this.lbl_ProductName, 1, 0);
            this.tbl_LayoutPanel.Controls.Add(this.lbl_Version, 1, 1);
            this.tbl_LayoutPanel.Controls.Add(this.lbl_Copyright, 1, 2);
            this.tbl_LayoutPanel.Controls.Add(this.lbl_CompanyName, 1, 3);
            this.tbl_LayoutPanel.Controls.Add(this.txt_BoxDescription, 1, 4);
            this.tbl_LayoutPanel.Controls.Add(this.btn_OK, 1, 5);
            this.tbl_LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_LayoutPanel.Location = new System.Drawing.Point(12, 11);
            this.tbl_LayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbl_LayoutPanel.Name = "tbl_LayoutPanel";
            this.tbl_LayoutPanel.RowCount = 6;
            this.tbl_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbl_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbl_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbl_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbl_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbl_LayoutPanel.Size = new System.Drawing.Size(556, 326);
            this.tbl_LayoutPanel.TabIndex = 0;
            // 
            // log_PictureBox
            // 
            this.log_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log_PictureBox.Image = global::Flyer.Properties.Resources.papierflugzeug;
            this.log_PictureBox.Location = new System.Drawing.Point(4, 4);
            this.log_PictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.log_PictureBox.Name = "log_PictureBox";
            this.tbl_LayoutPanel.SetRowSpan(this.log_PictureBox, 6);
            this.log_PictureBox.Size = new System.Drawing.Size(175, 318);
            this.log_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.log_PictureBox.TabIndex = 12;
            this.log_PictureBox.TabStop = false;
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductName.Location = new System.Drawing.Point(191, 0);
            this.lbl_ProductName.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.lbl_ProductName.MaximumSize = new System.Drawing.Size(0, 21);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(361, 21);
            this.lbl_ProductName.TabIndex = 19;
            this.lbl_ProductName.Text = "Produktname";
            this.lbl_ProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Version
            // 
            this.lbl_Version.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Version.Location = new System.Drawing.Point(191, 32);
            this.lbl_Version.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.lbl_Version.MaximumSize = new System.Drawing.Size(0, 21);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(361, 21);
            this.lbl_Version.TabIndex = 0;
            this.lbl_Version.Text = "Version";
            this.lbl_Version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Copyright
            // 
            this.lbl_Copyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Copyright.Location = new System.Drawing.Point(191, 64);
            this.lbl_Copyright.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.lbl_Copyright.MaximumSize = new System.Drawing.Size(0, 21);
            this.lbl_Copyright.Name = "lbl_Copyright";
            this.lbl_Copyright.Size = new System.Drawing.Size(361, 21);
            this.lbl_Copyright.TabIndex = 21;
            this.lbl_Copyright.Text = "Copyright";
            this.lbl_Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_CompanyName
            // 
            this.lbl_CompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompanyName.Location = new System.Drawing.Point(191, 96);
            this.lbl_CompanyName.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.lbl_CompanyName.MaximumSize = new System.Drawing.Size(0, 21);
            this.lbl_CompanyName.Name = "lbl_CompanyName";
            this.lbl_CompanyName.Size = new System.Drawing.Size(361, 21);
            this.lbl_CompanyName.TabIndex = 22;
            this.lbl_CompanyName.Text = "Firmenname";
            this.lbl_CompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_BoxDescription
            // 
            this.txt_BoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_BoxDescription.Location = new System.Drawing.Point(191, 132);
            this.txt_BoxDescription.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.txt_BoxDescription.Multiline = true;
            this.txt_BoxDescription.Name = "txt_BoxDescription";
            this.txt_BoxDescription.ReadOnly = true;
            this.txt_BoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_BoxDescription.Size = new System.Drawing.Size(361, 155);
            this.txt_BoxDescription.TabIndex = 23;
            this.txt_BoxDescription.TabStop = false;
            this.txt_BoxDescription.Text = "Beschreibung";
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_OK.Location = new System.Drawing.Point(452, 295);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(100, 27);
            this.btn_OK.TabIndex = 24;
            this.btn_OK.Text = "&OK";
            // 
            // formInfo
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 348);
            this.Controls.Add(this.tbl_LayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formInfo";
            this.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Info";
            this.tbl_LayoutPanel.ResumeLayout(false);
            this.tbl_LayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.log_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbl_LayoutPanel;
        private System.Windows.Forms.PictureBox log_PictureBox;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label lbl_Version;
        private System.Windows.Forms.Label lbl_Copyright;
        private System.Windows.Forms.Label lbl_CompanyName;
        private System.Windows.Forms.TextBox txt_BoxDescription;
        private System.Windows.Forms.Button btn_OK;
    }
}
