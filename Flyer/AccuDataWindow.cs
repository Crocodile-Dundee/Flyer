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
        Accu Akku = new Accu();                   // Akku instanzieren


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
        private void formAkkudaten_Load(object sender, EventArgs e)
        {
            // Form
            this.Size = new Size(1016, 544);
            this.CenterToScreen();

            // - Typ
            opt_Typ_Lipo.Checked = true;
            opt_Typ_NiMH.Checked = false;
            opt_Typ_NiCd.Checked = false;

            // - Spannung
            opt_Anzahl_Zellen.Checked = true;                   // Zellen angegeben
            opt_Spannung.Checked = false;

            cmb_Zellen_S.Visible = true;                        // Combo-Boxen für die Akku-Zellenzahl
            ud_Zellen_N.Visible = false;

            cmb_Zellen_S.SelectedIndex = 0;
            ud_Zellen_N.Value = 8;

            ud_Spannung.Value = Convert.ToDecimal(3.7);         // Zellenspannung LiPo
            ud_Spannung.Increment = Convert.ToDecimal(3.7);

            // - Kapazität und Belastbarkeit
            ud_Kapazitaet.Value = 2000;                         // Kapazität
            ud_Belastbarkeit_C.Value = 20;                      // Belastbarkeit

            // Berechnen
            Akkudaten_berechnen();
        }

        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Auswahl: Typ
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void opt_Typ_Lipo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (opt_Typ_Lipo.Checked == true)
            {
                ud_Spannung.Minimum = Convert.ToDecimal(Akku.Zellenspannung);
                ud_Spannung.Value = Convert.ToDecimal(Akku.Zellenspannung);
                lbl_Erg_Belastbarkeit_Headline.Visible = true;
                lbl_Erg_Belastbarkeit_A.Visible = true;
                lbl_Belastbarkeit.Visible = true;
                ud_Belastbarkeit_C.Visible = true;
                lbl_C.Visible = true;
            }
            Akkudaten_berechnen();
        }

        private void opt_Typ_NiMH_CheckedChanged_1(object sender, EventArgs e)
        {
            if (opt_Typ_NiMH.Checked == true)
            {
                ud_Spannung.Minimum = Convert.ToDecimal(Akku.Zellenspannung);
                ud_Spannung.Value = Convert.ToDecimal(Akku.Zellenspannung);
                lbl_Erg_Belastbarkeit_Headline.Visible = false;
                lbl_Erg_Belastbarkeit_A.Visible = false;
                lbl_Belastbarkeit.Visible = false;
                ud_Belastbarkeit_C.Visible = false;
                lbl_C.Visible = false;
            }
           Akkudaten_berechnen();
        }

        private void opt_Typ_NiCd_CheckedChanged_1(object sender, EventArgs e)
        {
            if (opt_Typ_NiCd.Checked == true)
            {
                ud_Spannung.Minimum = Convert.ToDecimal(Akku.Zellenspannung);
                ud_Spannung.Value = Convert.ToDecimal(Akku.Zellenspannung);
                lbl_Erg_Belastbarkeit_Headline.Visible = false;
                lbl_Erg_Belastbarkeit_A.Visible = false;
                lbl_Belastbarkeit.Visible = false;
                ud_Belastbarkeit_C.Visible = false;
                lbl_C.Visible = false;
            }
            Akkudaten_berechnen();
        }

        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Auswahl: Spannung
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void opt_Anzahl_Zellen_CheckedChanged(object sender, EventArgs e)
        {
            Akkudaten_berechnen();
        }

        private void opt_Spannung_CheckedChanged_1(object sender, EventArgs e)
        {
            if (opt_Spannung.Checked == true)
            {
                ud_Spannung.Minimum = Convert.ToDecimal(Akku.Zellenspannung);
                ud_Spannung.Value = Convert.ToDecimal(Akku.Zellenspannung);
            }
            Akkudaten_berechnen();
        }

        private void ud_Zellen_N_ValueChanged(object sender, EventArgs e)
        {
            Akkudaten_berechnen();
        }

        private void cmb_Zellen_S_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Akkudaten_berechnen();
        }

        private void ud_Spannung_ValueChanged(object sender, EventArgs e)
        {
            Akkudaten_berechnen();
        }

        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Auswahl: Kapazität und Belastbarkeit
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void ud_Kapazitaet_ValueChanged_1(object sender, EventArgs e)
        {
            Akkudaten_berechnen();
        }

        private void ud_Belastbarkeit_C_ValueChanged(object sender, EventArgs e)
        {
            Akkudaten_berechnen();
        }

        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Funktion: Werte berechnen 
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public void Akkudaten_berechnen()
        {

            // Typ
            // -----------------
            if (opt_Typ_Lipo.Checked == true)
            {
                Akku.eTyp = Accu.Akkutyp.LiPo;
                Akku.sLadetyp = Convert.ToString(Accu.Akkutyp.LiPo);
            }   
            if (opt_Typ_NiMH.Checked == true)
            {
                Akku.eTyp = Accu.Akkutyp.NiMH;
                Akku.sLadetyp = Convert.ToString(Accu.Akkutyp.NiMH);
            }   
            if (opt_Typ_NiCd.Checked == true)
            {
                Akku.eTyp = Accu.Akkutyp.NiCd;
                Akku.sLadetyp = Convert.ToString(Accu.Akkutyp.NiCd);
            }   
                       
 
            // Spannung
            // -----------------
            
            // Wenn die Zellenzahl angegeben ist:
            if (opt_Anzahl_Zellen.Checked == true)
            {
                // Zellen sind angegeben
                Akku.ZellenzahlAngabe = true;

                // Wenn LiPo ausgewählt
                if (opt_Typ_Lipo.Checked == true)
                {
                    cmb_Zellen_S.Visible = true;
                    ud_Zellen_N.Visible = false;
                    Akku.Zellenzahl = cmb_Zellen_S.SelectedIndex + 1;
                }
                // Wenn kein LiPo ausgewählt
                else
                {
                    cmb_Zellen_S.Visible = false;
                    ud_Zellen_N.Visible = true;
                    Akku.Zellenzahl = Convert.ToInt32(ud_Zellen_N.Value);
                }
                
                ud_Spannung.Visible = false;
                lbl_V.Visible = false;
                lbl_Erg_V_Zellen_Headline.Text = "Spannung";
            }

            // Wenn die Spannung angegeben ist:
            if (opt_Spannung.Checked == true)
            {
                // Zellen sind nicht angegeben
                Akku.ZellenzahlAngabe = false;

                cmb_Zellen_S.Visible = false;
                ud_Zellen_N.Visible = false;

                ud_Spannung.Visible = true;

                ud_Spannung.Increment = Convert.ToDecimal(Akku.Zellenspannung);
                Akku.Nennspannung = Convert.ToDouble(ud_Spannung.Value);

                lbl_V.Visible = true;
                lbl_Erg_V_Zellen_Headline.Text = "Zellen";
            }


            // Kapazität und Belastbarkeit
            // -----------------
            Akku.Kapazitaet = Convert.ToInt32(ud_Kapazitaet.Value);
            Akku.iBelastbarkeit_C = Convert.ToInt32(ud_Belastbarkeit_C.Value);


            // Berechnete Werte ausgeben
            // -----------------        
            
            // - Spannung
            if (opt_Anzahl_Zellen.Checked == true)
                lbl_Erg_Spannung_Zellenzahl.Text = Convert.ToString(string.Format("Der Akku hat eine Nennspannung von {0:0.0} V", Akku.Nennspannung));

            // - Zellen
            else
                if (Akku.Zellenzahl == 1)
                    lbl_Erg_Spannung_Zellenzahl.Text = Convert.ToString(string.Format("Der Akku hat 1 Zelle.", Akku.Zellenzahl));
                else
                    lbl_Erg_Spannung_Zellenzahl.Text = Convert.ToString(string.Format("Der Akku hat {0} Zellen.", Akku.Zellenzahl));

            // - Belastbarkeit in A
            lbl_Erg_Belastbarkeit_A.Text = Convert.ToString(string.Format("Der Akku ist belastbar mit max. {0:0.0} A.", Akku.Belastbarkeit));
        
            // - Ladetyp
            lbl_Erg_Laden_AkkuTyp.Text = Akku.sLadetyp;
        }

    }
}
