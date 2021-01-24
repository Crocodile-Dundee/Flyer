using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyer
{

    public class Accu
    {

        
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Konstanten
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ 
        private const double ZELLENSPG_LIPO = 3.7;
        private const double ZELLENSPG_NIMH = 1.2;
        private const double ZELLENSPG_NICD = 1.2;
        
        
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Eigenschaften
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++        
        
        // Liste der möglichen Akkutypen
        public enum Akkutyp
        {
            LiPo,
            NiMH,
            NiCd
        }

        // Akkutyp
        // (Setzt automatisch die Zellenspannung)
        private Akkutyp _eTyp;
        public Akkutyp eTyp
        {
            get { return _eTyp; }

            set
            {
                _eTyp = value; 
                
                switch (_eTyp)
                {
                    case Akkutyp.LiPo: Zellenspannung = ZELLENSPG_LIPO;
                        break;
                    case Akkutyp.NiMH: Zellenspannung = ZELLENSPG_NIMH;
                        break;
                    case Akkutyp.NiCd: Zellenspannung = ZELLENSPG_NICD;
                        break;
                }
            }
        }

        // Zellenspannung [V]
        // (wird automatisch gesetzt beim Setzen des Akkutyps)
        public double Zellenspannung { get; set; }

        // Gibt an, ob die Zellenzahl angegeben ist
        public bool ZellenzahlAngabe { get; set; }
        
        // Anzahl der Zellen
        // (berechnet automatisch die Nennspannung, wenn Zellen angegeben sind)
        private int _Zellenzahl;
        public int Zellenzahl
        {
            get { return _Zellenzahl; }
        
            set 
            {
                _Zellenzahl = value;
                if (ZellenzahlAngabe == true)
                 Nennspannung = Zellenspannung * Zellenzahl;
            }
        }

        // Nennspannung [V]
        // (berechnet automatische die Zellenzahl)
        private double _Nennspannung;
        public double Nennspannung 
        {
            get { return _Nennspannung; }

            set
            {
                _Nennspannung = value;
                if (ZellenzahlAngabe == false)
                    Zellenzahl = Convert.ToInt32(Nennspannung / Zellenspannung);
            }
        }

        // Kapazität [mAh]
        public int Kapazitaet { get; set; }

        // Belastbarkeit [C]
        // (berechnet automatisch die Belastbarkeit in A)
        private int _iBelastbarkeit_C;
        public int iBelastbarkeit_C
        {
            get { return _iBelastbarkeit_C; }

            set
            {
                _iBelastbarkeit_C = value;
                Belastbarkeit = (Kapazitaet * _iBelastbarkeit_C) / 1000.0;
            }
        }

        // Belastbarkeit [A]
        public double Belastbarkeit { get; set; }

        public string sLadetyp { get; set; }                // Am Ladegerät einzustellender Akkutyp
        public int iLadestrom_mA { get; set; }              // Am Ladegerät einzustellender Ladestrom in mA
        public double dLadestrom_A { get; set; }            // Am Ladegerät einzustellender Ladestrom in A

    }
}
