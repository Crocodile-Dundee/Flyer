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
        Accu AccuPack = new Accu();                   // Akku instanzieren


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
            opt_Typ_Lipo.Checked = true;

            // - Voltage
            opt_Anzahl_Zellen.Checked = true;                   // Zellen angegeben
            opt_Spannung.Checked = false;

            cmb_Zellen_S.Visible = true;                        // Combo-Boxen für die Akku-Zellenzahl
            ud_Zellen_N.Visible = false;

            cmb_Zellen_S.SelectedIndex = 0;
            ud_Zellen_N.Value = 8;

            ud_Spannung.Value = Convert.ToDecimal(3.7);         // Zellenspannung LiPo
            ud_Spannung.Increment = Convert.ToDecimal(3.7);

            // - Capacity and Load capacity
            ud_Kapazitaet.Value = 2000;                         // Kapazität
            ud_Belastbarkeit_C.Value = 20;                      // Belastbarkeit

            // Calculate
            CalcAccuValues();
        }

        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Auswahl: Typ
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void opt_Typ_Lipo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (opt_Typ_Lipo.Checked == true)
            {
                ud_Spannung.Minimum = Convert.ToDecimal(AccuPack.CellVoltage);
                ud_Spannung.Value = Convert.ToDecimal(AccuPack.CellVoltage);
                lbl_Erg_Belastbarkeit_Headline.Visible = true;
                lbl_Erg_Belastbarkeit_A.Visible = true;
                lbl_Belastbarkeit.Visible = true;
                ud_Belastbarkeit_C.Visible = true;
                lbl_C.Visible = true;
            }
            CalcAccuValues();
        }

        private void opt_Typ_NiMH_CheckedChanged_1(object sender, EventArgs e)
        {
            if (opt_Typ_NiMH.Checked == true)
            {
                ud_Spannung.Minimum = Convert.ToDecimal(AccuPack.CellVoltage);
                ud_Spannung.Value = Convert.ToDecimal(AccuPack.CellVoltage);
                lbl_Erg_Belastbarkeit_Headline.Visible = false;
                lbl_Erg_Belastbarkeit_A.Visible = false;
                lbl_Belastbarkeit.Visible = false;
                ud_Belastbarkeit_C.Visible = false;
                lbl_C.Visible = false;
            }
           CalcAccuValues();
        }

        private void opt_Typ_NiCd_CheckedChanged_1(object sender, EventArgs e)
        {
            if (opt_Typ_NiCd.Checked == true)
            {
                ud_Spannung.Minimum = Convert.ToDecimal(AccuPack.CellVoltage);
                ud_Spannung.Value = Convert.ToDecimal(AccuPack.CellVoltage);
                lbl_Erg_Belastbarkeit_Headline.Visible = false;
                lbl_Erg_Belastbarkeit_A.Visible = false;
                lbl_Belastbarkeit.Visible = false;
                ud_Belastbarkeit_C.Visible = false;
                lbl_C.Visible = false;
            }
            CalcAccuValues();
        }

        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Auswahl: Spannung
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void opt_Anzahl_Zellen_CheckedChanged(object sender, EventArgs e)
        {
            CalcAccuValues();
        }

        private void opt_Spannung_CheckedChanged_1(object sender, EventArgs e)
        {
            if (opt_Spannung.Checked == true)
            {
                ud_Spannung.Minimum = Convert.ToDecimal(AccuPack.CellVoltage);
                ud_Spannung.Value = Convert.ToDecimal(AccuPack.CellVoltage);
            }
            CalcAccuValues();
        }

        private void ud_Zellen_N_ValueChanged(object sender, EventArgs e)
        {
            CalcAccuValues();
        }

        private void cmb_Zellen_S_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CalcAccuValues();
        }

        private void ud_Spannung_ValueChanged(object sender, EventArgs e)
        {
            CalcAccuValues();
        }

        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Auswahl: Kapazität und Belastbarkeit
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void ud_Kapazitaet_ValueChanged_1(object sender, EventArgs e)
        {
            CalcAccuValues();
        }

        private void ud_Belastbarkeit_C_ValueChanged(object sender, EventArgs e)
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
            if (opt_Anzahl_Zellen.Checked == true)
                lbl_Erg_Spannung_Zellenzahl.Text = Convert.ToString(string.Format("Der Akku hat eine Nennspannung von {0:0.0} V", AccuPack.RatedVoltage));

            // - Zellen
            else
                if (AccuPack.CellCount == 1)
                    lbl_Erg_Spannung_Zellenzahl.Text = Convert.ToString(string.Format("Der Akku hat 1 Zelle.", AccuPack.CellCount));
                else
                    lbl_Erg_Spannung_Zellenzahl.Text = Convert.ToString(string.Format("Der Akku hat {0} Zellen.", AccuPack.CellCount));

            // - Belastbarkeit
            lbl_Erg_Belastbarkeit_A.Text = Convert.ToString(string.Format("Der Akku ist belastbar mit max. {0:0.0} A.", AccuPack.AmpLoadCapacity));
        
            // - Laden
            lbl_Erg_Laden_AkkuTyp.Text = AccuPack.ChargeAccuType;
        }

    }
}
