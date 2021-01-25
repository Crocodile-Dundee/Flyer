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
            this.grp_Results = new System.Windows.Forms.GroupBox();
            this.lbl_Res_ChargeCurrent = new System.Windows.Forms.Label();
            this.lbl_Res_AccuType = new System.Windows.Forms.Label();
            this.lbl_Res_Charg_Comment3 = new System.Windows.Forms.Label();
            this.lbl_Res_Charg_Comment2 = new System.Windows.Forms.Label();
            this.lbl_Res_Charg_Comment = new System.Windows.Forms.Label();
            this.lbl_ResHeadline_Charging = new System.Windows.Forms.Label();
            this.lbl_Res_LoadCapacity = new System.Windows.Forms.Label();
            this.lbl_ResHeadline_LoadCapacity = new System.Windows.Forms.Label();
            this.lbl_Res_Voltage_CellCount = new System.Windows.Forms.Label();
            this.lbl_ResHeadline_Voltage = new System.Windows.Forms.Label();
            this.grp_Voltage = new System.Windows.Forms.GroupBox();
            this.lbl_V = new System.Windows.Forms.Label();
            this.nud_Voltage = new System.Windows.Forms.NumericUpDown();
            this.cmb_CelCount_S = new System.Windows.Forms.ComboBox();
            this.opt_Voltage = new System.Windows.Forms.RadioButton();
            this.opt_CellCount = new System.Windows.Forms.RadioButton();
            this.lbl_Voltage = new System.Windows.Forms.Label();
            this.nud_CellCount = new System.Windows.Forms.NumericUpDown();
            this.grp_Type = new System.Windows.Forms.GroupBox();
            this.opt_Type_eneloop = new System.Windows.Forms.RadioButton();
            this.opt_Type_NiCd = new System.Windows.Forms.RadioButton();
            this.opt_Type_NiMH = new System.Windows.Forms.RadioButton();
            this.opt_Type_Lipo = new System.Windows.Forms.RadioButton();
            this.grp_Misc = new System.Windows.Forms.GroupBox();
            this.lbl_C = new System.Windows.Forms.Label();
            this.lbl_mAh = new System.Windows.Forms.Label();
            this.nud_LoadCapacity_C = new System.Windows.Forms.NumericUpDown();
            this.nud_Capacity = new System.Windows.Forms.NumericUpDown();
            this.lbl_LoadCapacity = new System.Windows.Forms.Label();
            this.lbl_Capacity = new System.Windows.Forms.Label();
            this.lbl_Arrow = new System.Windows.Forms.Label();
            this.grp_Results.SuspendLayout();
            this.grp_Voltage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Voltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CellCount)).BeginInit();
            this.grp_Type.SuspendLayout();
            this.grp_Misc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_LoadCapacity_C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Capacity)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_Results
            // 
            this.grp_Results.BackColor = System.Drawing.Color.White;
            this.grp_Results.Controls.Add(this.lbl_Res_ChargeCurrent);
            this.grp_Results.Controls.Add(this.lbl_Res_AccuType);
            this.grp_Results.Controls.Add(this.lbl_Res_Charg_Comment3);
            this.grp_Results.Controls.Add(this.lbl_Res_Charg_Comment2);
            this.grp_Results.Controls.Add(this.lbl_Res_Charg_Comment);
            this.grp_Results.Controls.Add(this.lbl_ResHeadline_Charging);
            this.grp_Results.Controls.Add(this.lbl_Res_LoadCapacity);
            this.grp_Results.Controls.Add(this.lbl_ResHeadline_LoadCapacity);
            this.grp_Results.Controls.Add(this.lbl_Res_Voltage_CellCount);
            this.grp_Results.Controls.Add(this.lbl_ResHeadline_Voltage);
            this.grp_Results.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Results.ForeColor = System.Drawing.Color.Black;
            this.grp_Results.Location = new System.Drawing.Point(616, 14);
            this.grp_Results.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_Results.Name = "grp_Results";
            this.grp_Results.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_Results.Size = new System.Drawing.Size(371, 530);
            this.grp_Results.TabIndex = 1;
            this.grp_Results.TabStop = false;
            this.grp_Results.Text = "Ergebnisse";
            // 
            // lbl_Res_ChargeCurrent
            // 
            this.lbl_Res_ChargeCurrent.AutoSize = true;
            this.lbl_Res_ChargeCurrent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Res_ChargeCurrent.Location = new System.Drawing.Point(181, 398);
            this.lbl_Res_ChargeCurrent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Res_ChargeCurrent.Name = "lbl_Res_ChargeCurrent";
            this.lbl_Res_ChargeCurrent.Size = new System.Drawing.Size(155, 20);
            this.lbl_Res_ChargeCurrent.TabIndex = 9;
            this.lbl_Res_ChargeCurrent.Text = "1C  =  1000mA  =  1 A";
            // 
            // lbl_Res_AccuType
            // 
            this.lbl_Res_AccuType.AutoSize = true;
            this.lbl_Res_AccuType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Res_AccuType.Location = new System.Drawing.Point(181, 360);
            this.lbl_Res_AccuType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Res_AccuType.Name = "lbl_Res_AccuType";
            this.lbl_Res_AccuType.Size = new System.Drawing.Size(36, 20);
            this.lbl_Res_AccuType.TabIndex = 8;
            this.lbl_Res_AccuType.Text = "LiPo";
            // 
            // lbl_Res_Charg_Comment3
            // 
            this.lbl_Res_Charg_Comment3.AutoSize = true;
            this.lbl_Res_Charg_Comment3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Res_Charg_Comment3.Location = new System.Drawing.Point(41, 398);
            this.lbl_Res_Charg_Comment3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Res_Charg_Comment3.Name = "lbl_Res_Charg_Comment3";
            this.lbl_Res_Charg_Comment3.Size = new System.Drawing.Size(92, 20);
            this.lbl_Res_Charg_Comment3.TabIndex = 7;
            this.lbl_Res_Charg_Comment3.Text = "- Ladestrom:";
            // 
            // lbl_Res_Charg_Comment2
            // 
            this.lbl_Res_Charg_Comment2.AutoSize = true;
            this.lbl_Res_Charg_Comment2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Res_Charg_Comment2.Location = new System.Drawing.Point(41, 360);
            this.lbl_Res_Charg_Comment2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Res_Charg_Comment2.Name = "lbl_Res_Charg_Comment2";
            this.lbl_Res_Charg_Comment2.Size = new System.Drawing.Size(83, 20);
            this.lbl_Res_Charg_Comment2.TabIndex = 6;
            this.lbl_Res_Charg_Comment2.Text = "- Akku-Typ:";
            // 
            // lbl_Res_Charg_Comment
            // 
            this.lbl_Res_Charg_Comment.AutoSize = true;
            this.lbl_Res_Charg_Comment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Res_Charg_Comment.Location = new System.Drawing.Point(41, 324);
            this.lbl_Res_Charg_Comment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Res_Charg_Comment.Name = "lbl_Res_Charg_Comment";
            this.lbl_Res_Charg_Comment.Size = new System.Drawing.Size(188, 20);
            this.lbl_Res_Charg_Comment.TabIndex = 5;
            this.lbl_Res_Charg_Comment.Text = "Am Ladegerät einzustellen:";
            // 
            // lbl_ResHeadline_Charging
            // 
            this.lbl_ResHeadline_Charging.AutoSize = true;
            this.lbl_ResHeadline_Charging.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ResHeadline_Charging.Location = new System.Drawing.Point(30, 290);
            this.lbl_ResHeadline_Charging.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ResHeadline_Charging.Name = "lbl_ResHeadline_Charging";
            this.lbl_ResHeadline_Charging.Size = new System.Drawing.Size(50, 20);
            this.lbl_ResHeadline_Charging.TabIndex = 4;
            this.lbl_ResHeadline_Charging.Text = "Laden";
            // 
            // lbl_Res_LoadCapacity
            // 
            this.lbl_Res_LoadCapacity.AutoSize = true;
            this.lbl_Res_LoadCapacity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Res_LoadCapacity.Location = new System.Drawing.Point(41, 194);
            this.lbl_Res_LoadCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Res_LoadCapacity.Name = "lbl_Res_LoadCapacity";
            this.lbl_Res_LoadCapacity.Size = new System.Drawing.Size(248, 20);
            this.lbl_Res_LoadCapacity.TabIndex = 3;
            this.lbl_Res_LoadCapacity.Text = "Der Akku ist belastbar mit max. 20A.";
            // 
            // lbl_ResHeadline_LoadCapacity
            // 
            this.lbl_ResHeadline_LoadCapacity.AutoSize = true;
            this.lbl_ResHeadline_LoadCapacity.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ResHeadline_LoadCapacity.Location = new System.Drawing.Point(30, 167);
            this.lbl_ResHeadline_LoadCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ResHeadline_LoadCapacity.Name = "lbl_ResHeadline_LoadCapacity";
            this.lbl_ResHeadline_LoadCapacity.Size = new System.Drawing.Size(97, 20);
            this.lbl_ResHeadline_LoadCapacity.TabIndex = 2;
            this.lbl_ResHeadline_LoadCapacity.Text = "Belastbarkeit";
            // 
            // lbl_Res_Voltage_CellCount
            // 
            this.lbl_Res_Voltage_CellCount.AutoSize = true;
            this.lbl_Res_Voltage_CellCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Res_Voltage_CellCount.Location = new System.Drawing.Point(41, 73);
            this.lbl_Res_Voltage_CellCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Res_Voltage_CellCount.Name = "lbl_Res_Voltage_CellCount";
            this.lbl_Res_Voltage_CellCount.Size = new System.Drawing.Size(289, 20);
            this.lbl_Res_Voltage_CellCount.TabIndex = 1;
            this.lbl_Res_Voltage_CellCount.Text = "Der Akku hat eine Nennspannung von 3,7V";
            // 
            // lbl_ResHeadline_Voltage
            // 
            this.lbl_ResHeadline_Voltage.AutoSize = true;
            this.lbl_ResHeadline_Voltage.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ResHeadline_Voltage.Location = new System.Drawing.Point(30, 47);
            this.lbl_ResHeadline_Voltage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ResHeadline_Voltage.Name = "lbl_ResHeadline_Voltage";
            this.lbl_ResHeadline_Voltage.Size = new System.Drawing.Size(79, 20);
            this.lbl_ResHeadline_Voltage.TabIndex = 0;
            this.lbl_ResHeadline_Voltage.Text = "Spannung";
            // 
            // grp_Voltage
            // 
            this.grp_Voltage.Controls.Add(this.lbl_V);
            this.grp_Voltage.Controls.Add(this.nud_Voltage);
            this.grp_Voltage.Controls.Add(this.cmb_CelCount_S);
            this.grp_Voltage.Controls.Add(this.opt_Voltage);
            this.grp_Voltage.Controls.Add(this.opt_CellCount);
            this.grp_Voltage.Controls.Add(this.lbl_Voltage);
            this.grp_Voltage.Controls.Add(this.nud_CellCount);
            this.grp_Voltage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Voltage.Location = new System.Drawing.Point(13, 211);
            this.grp_Voltage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_Voltage.Name = "grp_Voltage";
            this.grp_Voltage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_Voltage.Size = new System.Drawing.Size(449, 183);
            this.grp_Voltage.TabIndex = 5;
            this.grp_Voltage.TabStop = false;
            this.grp_Voltage.Text = "Spannung";
            // 
            // lbl_V
            // 
            this.lbl_V.AutoSize = true;
            this.lbl_V.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_V.Location = new System.Drawing.Point(390, 131);
            this.lbl_V.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_V.Name = "lbl_V";
            this.lbl_V.Size = new System.Drawing.Size(18, 20);
            this.lbl_V.TabIndex = 6;
            this.lbl_V.Text = "V";
            this.lbl_V.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_V.Visible = false;
            // 
            // nud_Voltage
            // 
            this.nud_Voltage.BackColor = System.Drawing.Color.White;
            this.nud_Voltage.DecimalPlaces = 1;
            this.nud_Voltage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Voltage.Increment = new decimal(new int[] {
            37,
            0,
            0,
            65536});
            this.nud_Voltage.Location = new System.Drawing.Point(297, 129);
            this.nud_Voltage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nud_Voltage.Name = "nud_Voltage";
            this.nud_Voltage.ReadOnly = true;
            this.nud_Voltage.Size = new System.Drawing.Size(86, 27);
            this.nud_Voltage.TabIndex = 5;
            this.nud_Voltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_Voltage.Value = new decimal(new int[] {
            37,
            0,
            0,
            65536});
            this.nud_Voltage.Visible = false;
            this.nud_Voltage.ValueChanged += new System.EventHandler(this.nud_Voltage_ValueChanged);
            // 
            // cmb_CelCount_S
            // 
            this.cmb_CelCount_S.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CelCount_S.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CelCount_S.FormattingEnabled = true;
            this.cmb_CelCount_S.Items.AddRange(new object[] {
            "1S",
            "2S",
            "3S",
            "4S",
            "5S",
            "6S",
            "7S",
            "8S"});
            this.cmb_CelCount_S.Location = new System.Drawing.Point(297, 83);
            this.cmb_CelCount_S.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_CelCount_S.Name = "cmb_CelCount_S";
            this.cmb_CelCount_S.Size = new System.Drawing.Size(47, 28);
            this.cmb_CelCount_S.TabIndex = 3;
            this.cmb_CelCount_S.SelectedIndexChanged += new System.EventHandler(this.cmb_CellCount_S_SelectedIndexChanged_1);
            // 
            // opt_Voltage
            // 
            this.opt_Voltage.AutoSize = true;
            this.opt_Voltage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_Voltage.Location = new System.Drawing.Point(30, 129);
            this.opt_Voltage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opt_Voltage.Name = "opt_Voltage";
            this.opt_Voltage.Size = new System.Drawing.Size(213, 24);
            this.opt_Voltage.TabIndex = 2;
            this.opt_Voltage.TabStop = true;
            this.opt_Voltage.Text = "... die Spannung angegeben";
            this.opt_Voltage.UseVisualStyleBackColor = true;
            this.opt_Voltage.CheckedChanged += new System.EventHandler(this.opt_Voltage_CheckedChanged_1);
            // 
            // opt_CellCount
            // 
            this.opt_CellCount.AutoSize = true;
            this.opt_CellCount.Checked = true;
            this.opt_CellCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_CellCount.Location = new System.Drawing.Point(30, 83);
            this.opt_CellCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opt_CellCount.Name = "opt_CellCount";
            this.opt_CellCount.Size = new System.Drawing.Size(263, 24);
            this.opt_CellCount.TabIndex = 1;
            this.opt_CellCount.TabStop = true;
            this.opt_CellCount.Text = "... die Anzahl der Zellen angegeben";
            this.opt_CellCount.UseVisualStyleBackColor = true;
            this.opt_CellCount.CheckedChanged += new System.EventHandler(this.opt_CellCount_CheckedChanged);
            // 
            // lbl_Voltage
            // 
            this.lbl_Voltage.AutoSize = true;
            this.lbl_Voltage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Voltage.Location = new System.Drawing.Point(25, 42);
            this.lbl_Voltage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Voltage.Name = "lbl_Voltage";
            this.lbl_Voltage.Size = new System.Drawing.Size(130, 20);
            this.lbl_Voltage.TabIndex = 0;
            this.lbl_Voltage.Text = "Auf dem Akku ist...";
            // 
            // nud_CellCount
            // 
            this.nud_CellCount.BackColor = System.Drawing.Color.White;
            this.nud_CellCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_CellCount.Location = new System.Drawing.Point(297, 83);
            this.nud_CellCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nud_CellCount.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nud_CellCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_CellCount.Name = "nud_CellCount";
            this.nud_CellCount.ReadOnly = true;
            this.nud_CellCount.Size = new System.Drawing.Size(86, 27);
            this.nud_CellCount.TabIndex = 7;
            this.nud_CellCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_CellCount.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nud_CellCount.Visible = false;
            this.nud_CellCount.ValueChanged += new System.EventHandler(this.nud_CellCount_ValueChanged);
            // 
            // grp_Type
            // 
            this.grp_Type.Controls.Add(this.opt_Type_eneloop);
            this.grp_Type.Controls.Add(this.opt_Type_NiCd);
            this.grp_Type.Controls.Add(this.opt_Type_NiMH);
            this.grp_Type.Controls.Add(this.opt_Type_Lipo);
            this.grp_Type.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Type.Location = new System.Drawing.Point(13, 14);
            this.grp_Type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_Type.Name = "grp_Type";
            this.grp_Type.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_Type.Size = new System.Drawing.Size(449, 187);
            this.grp_Type.TabIndex = 4;
            this.grp_Type.TabStop = false;
            this.grp_Type.Text = "Typ";
            // 
            // opt_Type_eneloop
            // 
            this.opt_Type_eneloop.AutoSize = true;
            this.opt_Type_eneloop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_Type_eneloop.Location = new System.Drawing.Point(36, 107);
            this.opt_Type_eneloop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opt_Type_eneloop.Name = "opt_Type_eneloop";
            this.opt_Type_eneloop.Size = new System.Drawing.Size(85, 24);
            this.opt_Type_eneloop.TabIndex = 3;
            this.opt_Type_eneloop.TabStop = true;
            this.opt_Type_eneloop.Text = "eneloop";
            this.opt_Type_eneloop.UseVisualStyleBackColor = true;
            this.opt_Type_eneloop.CheckedChanged += new System.EventHandler(this.opt_Type_eneloop_CheckedChanged);
            // 
            // opt_Type_NiCd
            // 
            this.opt_Type_NiCd.AutoSize = true;
            this.opt_Type_NiCd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_Type_NiCd.Location = new System.Drawing.Point(36, 142);
            this.opt_Type_NiCd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opt_Type_NiCd.Name = "opt_Type_NiCd";
            this.opt_Type_NiCd.Size = new System.Drawing.Size(188, 24);
            this.opt_Type_NiCd.TabIndex = 2;
            this.opt_Type_NiCd.TabStop = true;
            this.opt_Type_NiCd.Text = "NiCd (Nickel-Cadmium)";
            this.opt_Type_NiCd.UseVisualStyleBackColor = true;
            this.opt_Type_NiCd.CheckedChanged += new System.EventHandler(this.opt_Type_NiCd_CheckedChanged);
            // 
            // opt_Type_NiMH
            // 
            this.opt_Type_NiMH.AutoSize = true;
            this.opt_Type_NiMH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_Type_NiMH.Location = new System.Drawing.Point(36, 72);
            this.opt_Type_NiMH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opt_Type_NiMH.Name = "opt_Type_NiMH";
            this.opt_Type_NiMH.Size = new System.Drawing.Size(214, 24);
            this.opt_Type_NiMH.TabIndex = 1;
            this.opt_Type_NiMH.TabStop = true;
            this.opt_Type_NiMH.Text = "NiMH (Nickel-Metallhydrid)";
            this.opt_Type_NiMH.UseVisualStyleBackColor = true;
            this.opt_Type_NiMH.CheckedChanged += new System.EventHandler(this.opt_Type_NiMH_CheckedChanged);
            // 
            // opt_Type_Lipo
            // 
            this.opt_Type_Lipo.AutoSize = true;
            this.opt_Type_Lipo.Checked = true;
            this.opt_Type_Lipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_Type_Lipo.Location = new System.Drawing.Point(36, 37);
            this.opt_Type_Lipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opt_Type_Lipo.Name = "opt_Type_Lipo";
            this.opt_Type_Lipo.Size = new System.Drawing.Size(179, 24);
            this.opt_Type_Lipo.TabIndex = 0;
            this.opt_Type_Lipo.TabStop = true;
            this.opt_Type_Lipo.Text = "LiPo (Lithium-Polymer)";
            this.opt_Type_Lipo.UseVisualStyleBackColor = true;
            this.opt_Type_Lipo.CheckedChanged += new System.EventHandler(this.opt_Type_Lipo_CheckedChanged);
            // 
            // grp_Misc
            // 
            this.grp_Misc.Controls.Add(this.lbl_C);
            this.grp_Misc.Controls.Add(this.lbl_mAh);
            this.grp_Misc.Controls.Add(this.nud_LoadCapacity_C);
            this.grp_Misc.Controls.Add(this.nud_Capacity);
            this.grp_Misc.Controls.Add(this.lbl_LoadCapacity);
            this.grp_Misc.Controls.Add(this.lbl_Capacity);
            this.grp_Misc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Misc.Location = new System.Drawing.Point(13, 404);
            this.grp_Misc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_Misc.Name = "grp_Misc";
            this.grp_Misc.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_Misc.Size = new System.Drawing.Size(449, 140);
            this.grp_Misc.TabIndex = 8;
            this.grp_Misc.TabStop = false;
            // 
            // lbl_C
            // 
            this.lbl_C.AutoSize = true;
            this.lbl_C.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_C.Location = new System.Drawing.Point(390, 81);
            this.lbl_C.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_C.Name = "lbl_C";
            this.lbl_C.Size = new System.Drawing.Size(18, 20);
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
            this.lbl_mAh.Size = new System.Drawing.Size(40, 20);
            this.lbl_mAh.TabIndex = 12;
            this.lbl_mAh.Text = "mAh";
            this.lbl_mAh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nud_LoadCapacity_C
            // 
            this.nud_LoadCapacity_C.BackColor = System.Drawing.Color.White;
            this.nud_LoadCapacity_C.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_LoadCapacity_C.Location = new System.Drawing.Point(297, 79);
            this.nud_LoadCapacity_C.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nud_LoadCapacity_C.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_LoadCapacity_C.Name = "nud_LoadCapacity_C";
            this.nud_LoadCapacity_C.ReadOnly = true;
            this.nud_LoadCapacity_C.Size = new System.Drawing.Size(86, 27);
            this.nud_LoadCapacity_C.TabIndex = 11;
            this.nud_LoadCapacity_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_LoadCapacity_C.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_LoadCapacity_C.ValueChanged += new System.EventHandler(this.nud_LoadCapacity_C_ValueChanged);
            // 
            // nud_Capacity
            // 
            this.nud_Capacity.BackColor = System.Drawing.Color.White;
            this.nud_Capacity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Capacity.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud_Capacity.Location = new System.Drawing.Point(297, 41);
            this.nud_Capacity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nud_Capacity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_Capacity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud_Capacity.Name = "nud_Capacity";
            this.nud_Capacity.ReadOnly = true;
            this.nud_Capacity.Size = new System.Drawing.Size(86, 27);
            this.nud_Capacity.TabIndex = 10;
            this.nud_Capacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_Capacity.Value = new decimal(new int[] {
            1100,
            0,
            0,
            0});
            this.nud_Capacity.ValueChanged += new System.EventHandler(this.nud_Capacity_ValueChanged);
            // 
            // lbl_LoadCapacity
            // 
            this.lbl_LoadCapacity.AutoSize = true;
            this.lbl_LoadCapacity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoadCapacity.Location = new System.Drawing.Point(25, 82);
            this.lbl_LoadCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LoadCapacity.Name = "lbl_LoadCapacity";
            this.lbl_LoadCapacity.Size = new System.Drawing.Size(95, 20);
            this.lbl_LoadCapacity.TabIndex = 9;
            this.lbl_LoadCapacity.Text = "Belastbarkeit";
            // 
            // lbl_Capacity
            // 
            this.lbl_Capacity.AutoSize = true;
            this.lbl_Capacity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Capacity.Location = new System.Drawing.Point(25, 43);
            this.lbl_Capacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Capacity.Name = "lbl_Capacity";
            this.lbl_Capacity.Size = new System.Drawing.Size(72, 20);
            this.lbl_Capacity.TabIndex = 8;
            this.lbl_Capacity.Text = "Kapazität";
            // 
            // lbl_Arrow
            // 
            this.lbl_Arrow.Font = new System.Drawing.Font("Wingdings", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbl_Arrow.Location = new System.Drawing.Point(470, 14);
            this.lbl_Arrow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Arrow.Name = "lbl_Arrow";
            this.lbl_Arrow.Size = new System.Drawing.Size(138, 530);
            this.lbl_Arrow.TabIndex = 9;
            this.lbl_Arrow.Text = "ð";
            this.lbl_Arrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccuDataWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 558);
            this.Controls.Add(this.grp_Misc);
            this.Controls.Add(this.grp_Voltage);
            this.Controls.Add(this.grp_Type);
            this.Controls.Add(this.grp_Results);
            this.Controls.Add(this.lbl_Arrow);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "AccuDataWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flyer - Akkudaten berechnen";
            this.Load += new System.EventHandler(this.AccuDataWindow_Load);
            this.grp_Results.ResumeLayout(false);
            this.grp_Results.PerformLayout();
            this.grp_Voltage.ResumeLayout(false);
            this.grp_Voltage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Voltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CellCount)).EndInit();
            this.grp_Type.ResumeLayout(false);
            this.grp_Type.PerformLayout();
            this.grp_Misc.ResumeLayout(false);
            this.grp_Misc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_LoadCapacity_C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Capacity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Results;
        private System.Windows.Forms.GroupBox grp_Voltage;
        private System.Windows.Forms.Label lbl_Voltage;
        private System.Windows.Forms.GroupBox grp_Type;
        private System.Windows.Forms.RadioButton opt_Type_NiCd;
        private System.Windows.Forms.RadioButton opt_Type_NiMH;
        private System.Windows.Forms.RadioButton opt_Type_Lipo;
        private System.Windows.Forms.GroupBox grp_Misc;
        private System.Windows.Forms.Label lbl_LoadCapacity;
        private System.Windows.Forms.Label lbl_Capacity;
        private System.Windows.Forms.RadioButton opt_CellCount;
        private System.Windows.Forms.RadioButton opt_Voltage;
        public System.Windows.Forms.ComboBox cmb_CelCount_S;
        private System.Windows.Forms.NumericUpDown nud_Voltage;
        private System.Windows.Forms.NumericUpDown nud_LoadCapacity_C;
        private System.Windows.Forms.NumericUpDown nud_Capacity;
        private System.Windows.Forms.Label lbl_mAh;
        private System.Windows.Forms.Label lbl_C;
        private System.Windows.Forms.Label lbl_V;
        private System.Windows.Forms.Label lbl_ResHeadline_Voltage;
        private System.Windows.Forms.Label lbl_Res_Voltage_CellCount;
        private System.Windows.Forms.Label lbl_ResHeadline_LoadCapacity;
        private System.Windows.Forms.Label lbl_Res_LoadCapacity;
        private System.Windows.Forms.Label lbl_ResHeadline_Charging;
        private System.Windows.Forms.Label lbl_Res_Charg_Comment3;
        private System.Windows.Forms.Label lbl_Res_Charg_Comment2;
        private System.Windows.Forms.Label lbl_Res_ChargeCurrent;
        private System.Windows.Forms.Label lbl_Res_AccuType;
        private System.Windows.Forms.NumericUpDown nud_CellCount;
        private System.Windows.Forms.Label lbl_Arrow;
        private System.Windows.Forms.Label lbl_Res_Charg_Comment;
        private System.Windows.Forms.RadioButton opt_Type_eneloop;
    }
}