using System;
using System.Drawing;
using System.Windows.Forms;

namespace Flyer
{
    public partial class AccuDataWindow : Form
    {

        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Variablendeklarationen
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        Accu AccuPack = new Accu();


        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Konstruktor
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public AccuDataWindow()
        {
            InitializeComponent();
        }

        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Form laden 
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void AccuDataWindow_Load(object sender, EventArgs e)
        {
            // Form
            this.Size = new Size(1016, 544);
            this.CenterToScreen();

            // - Type
            opt_Type_Lipo.Checked = true;

            // - Voltage
            opt_CellCount.Checked = true;

            cmb_CelCount_S.Visible = true;                        // Combo-Boxen für die Akku-Zellenzahl
            nud_CellCount.Visible = false;

            cmb_CelCount_S.SelectedIndex = 0;
            nud_CellCount.Value = 8;

            nud_Voltage.Value = Convert.ToDecimal(3.7);         // Zellenspannung LiPo
            nud_Voltage.Increment = Convert.ToDecimal(3.7);

            // - Capacity and Load capacity
            nud_Capacity.Value = 2000;                         // Kapazität
            nud_LoadCapacity_C.Value = 20;                      // Belastbarkeit

            // Calculate
            CalcAccuValues();
        }

        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Auswahl: Typ
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void opt_Type_Lipo_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_Type_Lipo.Checked == true)
            {
                nud_Voltage.Minimum = Convert.ToDecimal(AccuPack.CellVoltage);
                nud_Voltage.Value = Convert.ToDecimal(AccuPack.CellVoltage);
                lbl_ResHeadline_LoadCapacity.Visible = true;
                lbl_Res_LoadCapacity.Visible = true;
                lbl_LoadCapacity.Visible = true;
                nud_LoadCapacity_C.Visible = true;
                lbl_C.Visible = true;
            }
            CalcAccuValues();
        }

        private void opt_Type_NiMH_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_Type_NiMH.Checked == true)
            {
                nud_Voltage.Minimum = Convert.ToDecimal(AccuPack.CellVoltage);
                nud_Voltage.Value = Convert.ToDecimal(AccuPack.CellVoltage);
                lbl_ResHeadline_LoadCapacity.Visible = false;
                lbl_Res_LoadCapacity.Visible = false;
                lbl_LoadCapacity.Visible = false;
                nud_LoadCapacity_C.Visible = false;
                lbl_C.Visible = false;
            }
           CalcAccuValues();
        }

        private void opt_Type_eneloop_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_Type_NiMH.Checked == true)
            {
                nud_Voltage.Minimum = Convert.ToDecimal(AccuPack.CellVoltage);
                nud_Voltage.Value = Convert.ToDecimal(AccuPack.CellVoltage);
                lbl_ResHeadline_LoadCapacity.Visible = false;
                lbl_Res_LoadCapacity.Visible = false;
                lbl_LoadCapacity.Visible = false;
                nud_LoadCapacity_C.Visible = false;
                lbl_C.Visible = false;
            }
            CalcAccuValues();
        }

        private void opt_Type_NiCd_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_Type_NiCd.Checked == true)
            {
                nud_Voltage.Minimum = Convert.ToDecimal(AccuPack.CellVoltage);
                nud_Voltage.Value = Convert.ToDecimal(AccuPack.CellVoltage);
                lbl_ResHeadline_LoadCapacity.Visible = false;
                lbl_Res_LoadCapacity.Visible = false;
                lbl_LoadCapacity.Visible = false;
                nud_LoadCapacity_C.Visible = false;
                lbl_C.Visible = false;
            }
            CalcAccuValues();
        }

        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Auswahl: Spannung
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void opt_CellCount_CheckedChanged(object sender, EventArgs e)
        {
            CalcAccuValues();
        }

        private void opt_Voltage_CheckedChanged_1(object sender, EventArgs e)
        {
            if (opt_Voltage.Checked == true)
            {
                nud_Voltage.Minimum = Convert.ToDecimal(AccuPack.CellVoltage);
                nud_Voltage.Value = Convert.ToDecimal(AccuPack.CellVoltage);
            }
            CalcAccuValues();
        }

        private void nud_CellCount_ValueChanged(object sender, EventArgs e)
        {
            CalcAccuValues();
        }

        private void cmb_CellCount_S_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CalcAccuValues();
        }

        private void nud_Voltage_ValueChanged(object sender, EventArgs e)
        {
            CalcAccuValues();
        }

        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Auswahl: Kapazität und Belastbarkeit
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void nud_Capacity_ValueChanged(object sender, EventArgs e)
        {
            CalcAccuValues();
        }

        private void nud_LoadCapacity_C_ValueChanged(object sender, EventArgs e)
        {
            CalcAccuValues();
        }

        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Funktion: Werte berechnen 
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public void CalcAccuValues()
        {

            // Calculate values
            AccuPack.CalcValues();


            // Show values     

            // - Spannung
            if (opt_CellCount.Checked == true)
                lbl_Res_Voltage_CellCount.Text = Convert.ToString(string.Format("Der Akku hat eine Nennspannung von {0:0.0} V", AccuPack.RatedVoltage));

            // - Zellen
            else
                if (AccuPack.CellCount == 1)
                    lbl_Res_Voltage_CellCount.Text = Convert.ToString(string.Format("Der Akku hat 1 Zelle.", AccuPack.CellCount));
                else
                    lbl_Res_Voltage_CellCount.Text = Convert.ToString(string.Format("Der Akku hat {0} Zellen.", AccuPack.CellCount));

            // - Belastbarkeit
            lbl_Res_LoadCapacity.Text = Convert.ToString(string.Format("Der Akku ist belastbar mit max. {0:0.0} A.", AccuPack.AmpLoadCapacity));
        
            // - Laden
            lbl_Res_AccuType.Text = AccuPack.ChargeAccuType;
        }


    }
}
