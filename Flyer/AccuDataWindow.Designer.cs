namespace Flyer
{
    partial class AccuDataWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccuDataWindow));
            this.grp_Ergebnisse = new System.Windows.Forms.GroupBox();
            this.lbl_Erg_Laden_Ladestrom = new System.Windows.Forms.Label();
            this.lbl_Erg_Laden_AkkuTyp = new System.Windows.Forms.Label();
            this.lbl_Erg_Laden_Kommentar3 = new System.Windows.Forms.Label();
            this.lbl_Erg_Laden_Kommentar2 = new System.Windows.Forms.Label();
            this.lbl_Erg_Laden_Kommentar = new System.Windows.Forms.Label();
            this.lbl_Erg_Laden_Headline = new System.Windows.Forms.Label();
            this.lbl_Erg_Belastbarkeit_A = new System.Windows.Forms.Label();
            this.lbl_Erg_Belastbarkeit_Headline = new System.Windows.Forms.Label();
            this.lbl_Erg_Spannung_Zellenzahl = new System.Windows.Forms.Label();
            this.lbl_Erg_V_Zellen_Headline = new System.Windows.Forms.Label();
            this.grp_Spannung = new System.Windows.Forms.GroupBox();
            this.lbl_V = new System.Windows.Forms.Label();
            this.ud_Spannung = new System.Windows.Forms.NumericUpDown();
            this.cmb_Zellen_S = new System.Windows.Forms.ComboBox();
            this.opt_Spannung = new System.Windows.Forms.RadioButton();
            this.opt_Anzahl_Zellen = new System.Windows.Forms.RadioButton();
            this.lbl_Akkuspannung = new System.Windows.Forms.Label();
            this.ud_Zellen_N = new System.Windows.Forms.NumericUpDown();
            this.grp_Typ = new System.Windows.Forms.GroupBox();
            this.opt_Typ_NiCd = new System.Windows.Forms.RadioButton();
            this.opt_Typ_NiMH = new System.Windows.Forms.RadioButton();
            this.opt_Typ_Lipo = new System.Windows.Forms.RadioButton();
            this.grp_Verschiedenes = new System.Windows.Forms.GroupBox();
            this.lbl_C = new System.Windows.Forms.Label();
            this.lbl_mAh = new System.Windows.Forms.Label();
            this.ud_Belastbarkeit_C = new System.Windows.Forms.NumericUpDown();
            this.ud_Kapazitaet = new System.Windows.Forms.NumericUpDown();
            this.lbl_Belastbarkeit = new System.Windows.Forms.Label();
            this.lbl_Kapazitaet = new System.Windows.Forms.Label();
            this.lbl_Pfeil = new System.Windows.Forms.Label();
            this.grp_Ergebnisse.SuspendLayout();
            this.grp_Spannung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_Spannung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_Zellen_N)).BeginInit();
            this.grp_Typ.SuspendLayout();
            this.grp_Verschiedenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_Belastbarkeit_C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_Kapazitaet)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_Ergebnisse
            // 
            this.grp_Ergebnisse.BackColor = System.Drawing.Color.White;
            this.grp_Ergebnisse.Controls.Add(this.lbl_Erg_Laden_Ladestrom);
            this.grp_Ergebnisse.Controls.Add(this.lbl_Erg_Laden_AkkuTyp);
            this.grp_Ergebnisse.Controls.Add(this.lbl_Erg_Laden_Kommentar3);
            this.grp_Ergebnisse.Controls.Add(this.lbl_Erg_Laden_Kommentar2);
            this.grp_Ergebnisse.Controls.Add(this.lbl_Erg_Laden_Kommentar);
            this.grp_Ergebnisse.Controls.Add(this.lbl_Erg_Laden_Headline);
            this.grp_Ergebnisse.Controls.Add(this.lbl_Erg_Belastbarkeit_A);
            this.grp_Ergebnisse.Controls.Add(this.lbl_Erg_Belastbarkeit_Headline);
            this.grp_Ergebnisse.Controls.Add(this.lbl_Erg_Spannung_Zellenzahl);
            this.grp_Ergebnisse.Controls.Add(this.lbl_Erg_V_Zellen_Headline);
            this.grp_Ergebnisse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Ergebnisse.ForeColor = System.Drawing.Color.Black;
            this.grp_Ergebnisse.Location = new System.Drawing.Point(616, 14);
            this.grp_Ergebnisse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_Ergebnisse.Name = "grp_Ergebnisse";
            this.grp_Ergebnisse.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_Ergebnisse.Size = new System.Drawing.Size(371, 482);
            this.grp_Ergebnisse.TabIndex = 1;
            this.grp_Ergebnisse.TabStop = false;
            this.grp_Ergebnisse.Text = "Ergebnisse";
            // 
            // lbl_Erg_Laden_Ladestrom
            // 
            this.lbl_Erg_Laden_Ladestrom.AutoSize = true;
            this.lbl_Erg_Laden_Ladestrom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Erg_Laden_Ladestrom.Location = new System.Drawing.Point(181, 398);
            this.lbl_Erg_Laden_Ladestrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Erg_Laden_Ladestrom.Name = "lbl_Erg_Laden_Ladestrom";
            this.lbl_Erg_Laden_Ladestrom.Size = new System.Drawing.Size(121, 15);
            this.lbl_Erg_Laden_Ladestrom.TabIndex = 9;
            this.lbl_Erg_Laden_Ladestrom.Text = "1C  =  1000mA  =  1 A";
            // 
            // lbl_Erg_Laden_AkkuTyp
            // 
            this.lbl_Erg_Laden_AkkuTyp.AutoSize = true;
            this.lbl_Erg_Laden_AkkuTyp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Erg_Laden_AkkuTyp.Location = new System.Drawing.Point(181, 360);
            this.lbl_Erg_Laden_AkkuTyp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Erg_Laden_AkkuTyp.Name = "lbl_Erg_Laden_AkkuTyp";
            this.lbl_Erg_Laden_AkkuTyp.Size = new System.Drawing.Size(30, 15);
            this.lbl_Erg_Laden_AkkuTyp.TabIndex = 8;
            this.lbl_Erg_Laden_AkkuTyp.Text = "LiPo";
            // 
            // lbl_Erg_Laden_Kommentar3
            // 
            this.lbl_Erg_Laden_Kommentar3.AutoSize = true;
            this.lbl_Erg_Laden_Kommentar3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Erg_Laden_Kommentar3.Location = new System.Drawing.Point(41, 398);
            this.lbl_Erg_Laden_Kommentar3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Erg_Laden_Kommentar3.Name = "lbl_Erg_Laden_Kommentar3";
            this.lbl_Erg_Laden_Kommentar3.Size = new System.Drawing.Size(74, 15);
            this.lbl_Erg_Laden_Kommentar3.TabIndex = 7;
            this.lbl_Erg_Laden_Kommentar3.Text = "- Ladestrom:";
            // 
            // lbl_Erg_Laden_Kommentar2
            // 
            this.lbl_Erg_Laden_Kommentar2.AutoSize = true;
            this.lbl_Erg_Laden_Kommentar2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Erg_Laden_Kommentar2.Location = new System.Drawing.Point(41, 360);
            this.lbl_Erg_Laden_Kommentar2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Erg_Laden_Kommentar2.Name = "lbl_Erg_Laden_Kommentar2";
            this.lbl_Erg_Laden_Kommentar2.Size = new System.Drawing.Size(68, 15);
            this.lbl_Erg_Laden_Kommentar2.TabIndex = 6;
            this.lbl_Erg_Laden_Kommentar2.Text = "- Akku-Typ:";
            // 
            // lbl_Erg_Laden_Kommentar
            // 
            this.lbl_Erg_Laden_Kommentar.AutoSize = true;
            this.lbl_Erg_Laden_Kommentar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Erg_Laden_Kommentar.Location = new System.Drawing.Point(41, 324);
            this.lbl_Erg_Laden_Kommentar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Erg_Laden_Kommentar.Name = "lbl_Erg_Laden_Kommentar";
            this.lbl_Erg_Laden_Kommentar.Size = new System.Drawing.Size(149, 15);
            this.lbl_Erg_Laden_Kommentar.TabIndex = 5;
            this.lbl_Erg_Laden_Kommentar.Text = "Am Ladegerät einzustellen:";
            // 
            // lbl_Erg_Laden_Headline
            // 
            this.lbl_Erg_Laden_Headline.AutoSize = true;
            this.lbl_Erg_Laden_Headline.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Erg_Laden_Headline.Location = new System.Drawing.Point(30, 290);
            this.lbl_Erg_Laden_Headline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Erg_Laden_Headline.Name = "lbl_Erg_Laden_Headline";
            this.lbl_Erg_Laden_Headline.Size = new System.Drawing.Size(39, 15);
            this.lbl_Erg_Laden_Headline.TabIndex = 4;
            this.lbl_Erg_Laden_Headline.Text = "Laden";
            // 
            // lbl_Erg_Belastbarkeit_A
            // 
            this.lbl_Erg_Belastbarkeit_A.AutoSize = true;
            this.lbl_Erg_Belastbarkeit_A.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Erg_Belastbarkeit_A.Location = new System.Drawing.Point(41, 194);
            this.lbl_Erg_Belastbarkeit_A.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Erg_Belastbarkeit_A.Name = "lbl_Erg_Belastbarkeit_A";
            this.lbl_Erg_Belastbarkeit_A.Size = new System.Drawing.Size(197, 15);
            this.lbl_Erg_Belastbarkeit_A.TabIndex = 3;
            this.lbl_Erg_Belastbarkeit_A.Text = "Der Akku ist belastbar mit max. 20A.";
            // 
            // lbl_Erg_Belastbarkeit_Headline
            // 
            this.lbl_Erg_Belastbarkeit_Headline.AutoSize = true;
            this.lbl_Erg_Belastbarkeit_Headline.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Erg_Belastbarkeit_Headline.Location = new System.Drawing.Point(30, 167);
            this.lbl_Erg_Belastbarkeit_Headline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Erg_Belastbarkeit_Headline.Name = "lbl_Erg_Belastbarkeit_Headline";
            this.lbl_Erg_Belastbarkeit_Headline.Size = new System.Drawing.Size(74, 15);
            this.lbl_Erg_Belastbarkeit_Headline.TabIndex = 2;
            this.lbl_Erg_Belastbarkeit_Headline.Text = "Belastbarkeit";
            // 
            // lbl_Erg_Spannung_Zellenzahl
            // 
            this.lbl_Erg_Spannung_Zellenzahl.AutoSize = true;
            this.lbl_Erg_Spannung_Zellenzahl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Erg_Spannung_Zellenzahl.Location = new System.Drawing.Point(41, 73);
            this.lbl_Erg_Spannung_Zellenzahl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Erg_Spannung_Zellenzahl.Name = "lbl_Erg_Spannung_Zellenzahl";
            this.lbl_Erg_Spannung_Zellenzahl.Size = new System.Drawing.Size(233, 15);
            this.lbl_Erg_Spannung_Zellenzahl.TabIndex = 1;
            this.lbl_Erg_Spannung_Zellenzahl.Text = "Der Akku hat eine Nennspannung von 3,7V";
            // 
            // lbl_Erg_V_Zellen_Headline
            // 
            this.lbl_Erg_V_Zellen_Headline.AutoSize = true;
            this.lbl_Erg_V_Zellen_Headline.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Erg_V_Zellen_Headline.Location = new System.Drawing.Point(30, 47);
            this.lbl_Erg_V_Zellen_Headline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Erg_V_Zellen_Headline.Name = "lbl_Erg_V_Zellen_Headline";
            this.lbl_Erg_V_Zellen_Headline.Size = new System.Drawing.Size(62, 15);
            this.lbl_Erg_V_Zellen_Headline.TabIndex = 0;
            this.lbl_Erg_V_Zellen_Headline.Text = "Spannung";
            // 
            // grp_Spannung
            // 
            this.grp_Spannung.Controls.Add(this.lbl_V);
            this.grp_Spannung.Controls.Add(this.ud_Spannung);
            this.grp_Spannung.Controls.Add(this.cmb_Zellen_S);
            this.grp_Spannung.Controls.Add(this.opt_Spannung);
            this.grp_Spannung.Controls.Add(this.opt_Anzahl_Zellen);
            this.grp_Spannung.Controls.Add(this.lbl_Akkuspannung);
            this.grp_Spannung.Controls.Add(this.ud_Zellen_N);
            this.grp_Spannung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Spannung.Location = new System.Drawing.Point(13, 168);
            this.grp_Spannung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_Spannung.Name = "grp_Spannung";
            this.grp_Spannung.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_Spannung.Size = new System.Drawing.Size(449, 183);
            this.grp_Spannung.TabIndex = 5;
            this.grp_Spannung.TabStop = false;
            this.grp_Spannung.Text = "Spannung";
            // 
            // lbl_V
            // 
            this.lbl_V.AutoSize = true;
            this.lbl_V.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_V.Location = new System.Drawing.Point(390, 131);
            this.lbl_V.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_V.Name = "lbl_V";
            this.lbl_V.Size = new System.Drawing.Size(14, 15);
            this.lbl_V.TabIndex = 6;
            this.lbl_V.Text = "V";
            this.lbl_V.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_V.Visible = false;
            // 
            // ud_Spannung
            // 
            this.ud_Spannung.BackColor = System.Drawing.Color.White;
            this.ud_Spannung.DecimalPlaces = 1;
            this.ud_Spannung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ud_Spannung.Increment = new decimal(new int[] {
            37,
            0,
            0,
            65536});
            this.ud_Spannung.Location = new System.Drawing.Point(297, 129);
            this.ud_Spannung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ud_Spannung.Name = "ud_Spannung";
            this.ud_Spannung.ReadOnly = true;
            this.ud_Spannung.Size = new System.Drawing.Size(86, 23);
            this.ud_Spannung.TabIndex = 5;
            this.ud_Spannung.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ud_Spannung.Value = new decimal(new int[] {
            37,
            0,
            0,
            65536});
            this.ud_Spannung.Visible = false;
            this.ud_Spannung.ValueChanged += new System.EventHandler(this.ud_Spannung_ValueChanged);
            // 
            // cmb_Zellen_S
            // 
            this.cmb_Zellen_S.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Zellen_S.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Zellen_S.FormattingEnabled = true;
            this.cmb_Zellen_S.Items.AddRange(new object[] {
            "1S",
            "2S",
            "3S",
            "4S",
            "5S",
            "6S",
            "7S",
            "8S"});
            this.cmb_Zellen_S.Location = new System.Drawing.Point(297, 83);
            this.cmb_Zellen_S.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_Zellen_S.Name = "cmb_Zellen_S";
            this.cmb_Zellen_S.Size = new System.Drawing.Size(47, 23);
            this.cmb_Zellen_S.TabIndex = 3;
            this.cmb_Zellen_S.SelectedIndexChanged += new System.EventHandler(this.cmb_Zellen_S_SelectedIndexChanged_1);
            // 
            // opt_Spannung
            // 
            this.opt_Spannung.AutoSize = true;
            this.opt_Spannung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_Spannung.Location = new System.Drawing.Point(30, 129);
            this.opt_Spannung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opt_Spannung.Name = "opt_Spannung";
            this.opt_Spannung.Size = new System.Drawing.Size(172, 19);
            this.opt_Spannung.TabIndex = 2;
            this.opt_Spannung.TabStop = true;
            this.opt_Spannung.Text = "... die Spannung angegeben";
            this.opt_Spannung.UseVisualStyleBackColor = true;
            this.opt_Spannung.CheckedChanged += new System.EventHandler(this.opt_Spannung_CheckedChanged_1);
            // 
            // opt_Anzahl_Zellen
            // 
            this.opt_Anzahl_Zellen.AutoSize = true;
            this.opt_Anzahl_Zellen.Checked = true;
            this.opt_Anzahl_Zellen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_Anzahl_Zellen.Location = new System.Drawing.Point(30, 83);
            this.opt_Anzahl_Zellen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opt_Anzahl_Zellen.Name = "opt_Anzahl_Zellen";
            this.opt_Anzahl_Zellen.Size = new System.Drawing.Size(209, 19);
            this.opt_Anzahl_Zellen.TabIndex = 1;
            this.opt_Anzahl_Zellen.TabStop = true;
            this.opt_Anzahl_Zellen.Text = "... die Anzahl der Zellen angegeben";
            this.opt_Anzahl_Zellen.UseVisualStyleBackColor = true;
            // 
            // lbl_Akkuspannung
            // 
            this.lbl_Akkuspannung.AutoSize = true;
            this.lbl_Akkuspannung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Akkuspannung.Location = new System.Drawing.Point(25, 42);
            this.lbl_Akkuspannung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Akkuspannung.Name = "lbl_Akkuspannung";
            this.lbl_Akkuspannung.Size = new System.Drawing.Size(107, 15);
            this.lbl_Akkuspannung.TabIndex = 0;
            this.lbl_Akkuspannung.Text = "Auf dem Akku ist...";
            // 
            // ud_Zellen_N
            // 
            this.ud_Zellen_N.BackColor = System.Drawing.Color.White;
            this.ud_Zellen_N.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ud_Zellen_N.Location = new System.Drawing.Point(297, 83);
            this.ud_Zellen_N.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ud_Zellen_N.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.ud_Zellen_N.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ud_Zellen_N.Name = "ud_Zellen_N";
            this.ud_Zellen_N.ReadOnly = true;
            this.ud_Zellen_N.Size = new System.Drawing.Size(86, 23);
            this.ud_Zellen_N.TabIndex = 7;
            this.ud_Zellen_N.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ud_Zellen_N.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.ud_Zellen_N.Visible = false;
            this.ud_Zellen_N.ValueChanged += new System.EventHandler(this.ud_Zellen_N_ValueChanged);
            // 
            // grp_Typ
            // 
            this.grp_Typ.Controls.Add(this.opt_Typ_NiCd);
            this.grp_Typ.Controls.Add(this.opt_Typ_NiMH);
            this.grp_Typ.Controls.Add(this.opt_Typ_Lipo);
            this.grp_Typ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Typ.Location = new System.Drawing.Point(13, 14);
            this.grp_Typ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_Typ.Name = "grp_Typ";
            this.grp_Typ.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_Typ.Size = new System.Drawing.Size(449, 144);
            this.grp_Typ.TabIndex = 4;
            this.grp_Typ.TabStop = false;
            this.grp_Typ.Text = "Typ";
            // 
            // opt_Typ_NiCd
            // 
            this.opt_Typ_NiCd.AutoSize = true;
            this.opt_Typ_NiCd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_Typ_NiCd.Location = new System.Drawing.Point(36, 102);
            this.opt_Typ_NiCd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opt_Typ_NiCd.Name = "opt_Typ_NiCd";
            this.opt_Typ_NiCd.Size = new System.Drawing.Size(154, 19);
            this.opt_Typ_NiCd.TabIndex = 2;
            this.opt_Typ_NiCd.TabStop = true;
            this.opt_Typ_NiCd.Text = "NiCd (Nickel-Cadmium)";
            this.opt_Typ_NiCd.UseVisualStyleBackColor = true;
            this.opt_Typ_NiCd.CheckedChanged += new System.EventHandler(this.opt_Typ_NiCd_CheckedChanged_1);
            // 
            // opt_Typ_NiMH
            // 
            this.opt_Typ_NiMH.AutoSize = true;
            this.opt_Typ_NiMH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_Typ_NiMH.Location = new System.Drawing.Point(36, 64);
            this.opt_Typ_NiMH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opt_Typ_NiMH.Name = "opt_Typ_NiMH";
            this.opt_Typ_NiMH.Size = new System.Drawing.Size(227, 19);
            this.opt_Typ_NiMH.TabIndex = 1;
            this.opt_Typ_NiMH.TabStop = true;
            this.opt_Typ_NiMH.Text = "NiMH / eneloop (Nickel-Metallhydrid)";
            this.opt_Typ_NiMH.UseVisualStyleBackColor = true;
            this.opt_Typ_NiMH.CheckedChanged += new System.EventHandler(this.opt_Typ_NiMH_CheckedChanged_1);
            // 
            // opt_Typ_Lipo
            // 
            this.opt_Typ_Lipo.AutoSize = true;
            this.opt_Typ_Lipo.Checked = true;
            this.opt_Typ_Lipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_Typ_Lipo.Location = new System.Drawing.Point(36, 26);
            this.opt_Typ_Lipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opt_Typ_Lipo.Name = "opt_Typ_Lipo";
            this.opt_Typ_Lipo.Size = new System.Drawing.Size(149, 19);
            this.opt_Typ_Lipo.TabIndex = 0;
            this.opt_Typ_Lipo.TabStop = true;
            this.opt_Typ_Lipo.Text = "LiPo (Lithium-Polymer)";
            this.opt_Typ_Lipo.UseVisualStyleBackColor = true;
            this.opt_Typ_Lipo.CheckedChanged += new System.EventHandler(this.opt_Typ_Lipo_CheckedChanged_1);
            // 
            // grp_Verschiedenes
            // 
            this.grp_Verschiedenes.Controls.Add(this.lbl_C);
            this.grp_Verschiedenes.Controls.Add(this.lbl_mAh);
            this.grp_Verschiedenes.Controls.Add(this.ud_Belastbarkeit_C);
            this.grp_Verschiedenes.Controls.Add(this.ud_Kapazitaet);
            this.grp_Verschiedenes.Controls.Add(this.lbl_Belastbarkeit);
            this.grp_Verschiedenes.Controls.Add(this.lbl_Kapazitaet);
            this.grp_Verschiedenes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Verschiedenes.Location = new System.Drawing.Point(13, 361);
            this.grp_Verschiedenes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_Verschiedenes.Name = "grp_Verschiedenes";
            this.grp_Verschiedenes.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_Verschiedenes.Size = new System.Drawing.Size(449, 135);
            this.grp_Verschiedenes.TabIndex = 8;
            this.grp_Verschiedenes.TabStop = false;
            // 
            // lbl_C
            // 
            this.lbl_C.AutoSize = true;
            this.lbl_C.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_C.Location = new System.Drawing.Point(390, 81);
            this.lbl_C.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_C.Name = "lbl_C";
            this.lbl_C.Size = new System.Drawing.Size(15, 15);
            this.lbl_C.TabIndex = 13;
            this.lbl_C.Text = "C";
            this.lbl_C.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_mAh
            // 
            this.lbl_mAh.AutoSize = true;
            this.lbl_mAh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mAh.Location = new System.Drawing.Point(390, 45);
            this.lbl_mAh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mAh.Name = "lbl_mAh";
            this.lbl_mAh.Size = new System.Drawing.Size(33, 15);
            this.lbl_mAh.TabIndex = 12;
            this.lbl_mAh.Text = "mAh";
            this.lbl_mAh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ud_Belastbarkeit_C
            // 
            this.ud_Belastbarkeit_C.BackColor = System.Drawing.Color.White;
            this.ud_Belastbarkeit_C.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ud_Belastbarkeit_C.Location = new System.Drawing.Point(297, 79);
            this.ud_Belastbarkeit_C.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ud_Belastbarkeit_C.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ud_Belastbarkeit_C.Name = "ud_Belastbarkeit_C";
            this.ud_Belastbarkeit_C.ReadOnly = true;
            this.ud_Belastbarkeit_C.Size = new System.Drawing.Size(86, 23);
            this.ud_Belastbarkeit_C.TabIndex = 11;
            this.ud_Belastbarkeit_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ud_Belastbarkeit_C.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.ud_Belastbarkeit_C.ValueChanged += new System.EventHandler(this.ud_Belastbarkeit_C_ValueChanged);
            // 
            // ud_Kapazitaet
            // 
            this.ud_Kapazitaet.BackColor = System.Drawing.Color.White;
            this.ud_Kapazitaet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ud_Kapazitaet.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ud_Kapazitaet.Location = new System.Drawing.Point(297, 41);
            this.ud_Kapazitaet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ud_Kapazitaet.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ud_Kapazitaet.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ud_Kapazitaet.Name = "ud_Kapazitaet";
            this.ud_Kapazitaet.ReadOnly = true;
            this.ud_Kapazitaet.Size = new System.Drawing.Size(86, 23);
            this.ud_Kapazitaet.TabIndex = 10;
            this.ud_Kapazitaet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ud_Kapazitaet.Value = new decimal(new int[] {
            1100,
            0,
            0,
            0});
            this.ud_Kapazitaet.ValueChanged += new System.EventHandler(this.ud_Kapazitaet_ValueChanged_1);
            // 
            // lbl_Belastbarkeit
            // 
            this.lbl_Belastbarkeit.AutoSize = true;
            this.lbl_Belastbarkeit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Belastbarkeit.Location = new System.Drawing.Point(25, 82);
            this.lbl_Belastbarkeit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Belastbarkeit.Name = "lbl_Belastbarkeit";
            this.lbl_Belastbarkeit.Size = new System.Drawing.Size(74, 15);
            this.lbl_Belastbarkeit.TabIndex = 9;
            this.lbl_Belastbarkeit.Text = "Belastbarkeit";
            // 
            // lbl_Kapazitaet
            // 
            this.lbl_Kapazitaet.AutoSize = true;
            this.lbl_Kapazitaet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Kapazitaet.Location = new System.Drawing.Point(25, 43);
            this.lbl_Kapazitaet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Kapazitaet.Name = "lbl_Kapazitaet";
            this.lbl_Kapazitaet.Size = new System.Drawing.Size(55, 15);
            this.lbl_Kapazitaet.TabIndex = 8;
            this.lbl_Kapazitaet.Text = "Kapazität";
            // 
            // lbl_Pfeil
            // 
            this.lbl_Pfeil.Font = new System.Drawing.Font("Wingdings", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbl_Pfeil.Location = new System.Drawing.Point(470, 14);
            this.lbl_Pfeil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Pfeil.Name = "lbl_Pfeil";
            this.lbl_Pfeil.Size = new System.Drawing.Size(138, 482);
            this.lbl_Pfeil.TabIndex = 9;
            this.lbl_Pfeil.Text = "ð";
            this.lbl_Pfeil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccuDataWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 505);
            this.Controls.Add(this.grp_Verschiedenes);
            this.Controls.Add(this.grp_Spannung);
            this.Controls.Add(this.grp_Typ);
            this.Controls.Add(this.grp_Ergebnisse);
            this.Controls.Add(this.lbl_Pfeil);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "AccuDataWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flyer - Akkudaten berechnen";
            this.Load += new System.EventHandler(this.formAkkudaten_Load);
            this.grp_Ergebnisse.ResumeLayout(false);
            this.grp_Ergebnisse.PerformLayout();
            this.grp_Spannung.ResumeLayout(false);
            this.grp_Spannung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_Spannung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_Zellen_N)).EndInit();
            this.grp_Typ.ResumeLayout(false);
            this.grp_Typ.PerformLayout();
            this.grp_Verschiedenes.ResumeLayout(false);
            this.grp_Verschiedenes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_Belastbarkeit_C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_Kapazitaet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Ergebnisse;
        private System.Windows.Forms.GroupBox grp_Spannung;
        private System.Windows.Forms.Label lbl_Akkuspannung;
        private System.Windows.Forms.GroupBox grp_Typ;
        private System.Windows.Forms.RadioButton opt_Typ_NiCd;
        private System.Windows.Forms.RadioButton opt_Typ_NiMH;
        private System.Windows.Forms.RadioButton opt_Typ_Lipo;
        private System.Windows.Forms.GroupBox grp_Verschiedenes;
        private System.Windows.Forms.Label lbl_Belastbarkeit;
        private System.Windows.Forms.Label lbl_Kapazitaet;
        private System.Windows.Forms.RadioButton opt_Anzahl_Zellen;
        private System.Windows.Forms.RadioButton opt_Spannung;
        public System.Windows.Forms.ComboBox cmb_Zellen_S;
        private System.Windows.Forms.NumericUpDown ud_Spannung;
        private System.Windows.Forms.NumericUpDown ud_Belastbarkeit_C;
        private System.Windows.Forms.NumericUpDown ud_Kapazitaet;
        private System.Windows.Forms.Label lbl_mAh;
        private System.Windows.Forms.Label lbl_C;
        private System.Windows.Forms.Label lbl_V;
        private System.Windows.Forms.Label lbl_Erg_V_Zellen_Headline;
        private System.Windows.Forms.Label lbl_Erg_Spannung_Zellenzahl;
        private System.Windows.Forms.Label lbl_Erg_Belastbarkeit_Headline;
        private System.Windows.Forms.Label lbl_Erg_Belastbarkeit_A;
        private System.Windows.Forms.Label lbl_Erg_Laden_Headline;
        private System.Windows.Forms.Label lbl_Erg_Laden_Kommentar3;
        private System.Windows.Forms.Label lbl_Erg_Laden_Kommentar2;
        private System.Windows.Forms.Label lbl_Erg_Laden_Ladestrom;
        private System.Windows.Forms.Label lbl_Erg_Laden_AkkuTyp;
        private System.Windows.Forms.NumericUpDown ud_Zellen_N;
        private System.Windows.Forms.Label lbl_Pfeil;
        private System.Windows.Forms.Label lbl_Erg_Laden_Kommentar;
    }
}