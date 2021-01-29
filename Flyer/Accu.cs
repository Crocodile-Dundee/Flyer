using System;

namespace Flyer
{

    public class Accu
    {
   
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Constants
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ 
        private const double CELL_VOLTAGE_LIPO = 3.7;
        private const double CELL_VOLTAGE_NIMH = 1.2;
        private const double CELL_VOLTAGE_NICD = 1.2;
        
        
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Enumerations
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++        
        
        // Accu type
        public enum AccuType
        {
            LiPo,
            NiMH,
            eneloop,
            NiCd
        }


        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Properties
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++        

        /// <summary>
        /// Accu type
        /// </summary>
        private AccuType _Type;
        public AccuType Type
        {
            get { return _Type; }

            set
            {
                _Type = value; 
                
                switch (_Type)
                {
                    case AccuType.LiPo: 
                        CellVoltage = CELL_VOLTAGE_LIPO;
                        ChargeAccuType = Convert.ToString(Accu.AccuType.LiPo);
                        break;

                    case AccuType.NiMH:
                        CellVoltage = CELL_VOLTAGE_NIMH;
                        ChargeAccuType = Convert.ToString(Accu.AccuType.NiMH);
                        break;

                    case AccuType.eneloop:
                        CellVoltage = CELL_VOLTAGE_NIMH;
                        ChargeAccuType = Convert.ToString(Accu.AccuType.NiMH);
                        break;

                    case AccuType.NiCd: 
                        CellVoltage = CELL_VOLTAGE_NICD;
                        ChargeAccuType = Convert.ToString(Accu.AccuType.NiCd);
                        break;
                }
            }
        }


        /// <summary>
        /// Cell voltage [V]
        /// </summary>
        public double CellVoltage { get; private set; }


        /// <summary>
        /// If the cell count is speficied
        /// </summary>
        public bool IsCellCountSpecified { get; private set; }
        

        /// <summary>
        /// Cell count
        /// </summary>
        private int _CellCount;
        public int CellCount
        {
            get { return _CellCount; }

            private set 
            {
                _CellCount = value;
                if (IsCellCountSpecified == true)
                 RatedVoltage = CellVoltage * CellCount;
            }
        }


        /// <summary>
        /// Rated voltage [V]
        /// </summary>
        private double _RatedVoltage;
        public double RatedVoltage 
        {
            get { return _RatedVoltage; }

            private set
            {
                _RatedVoltage = value;
                if (IsCellCountSpecified == false)
                    CellCount = Convert.ToInt32(RatedVoltage / CellVoltage);
            }
        }


        /// <summary>
        /// Rated capacity [mAh]
        /// </summary>
        public int RatedCapacity { get; private set; }


        /// <summary>
        /// Load capacity [C]
        /// </summary>
        private int _LoadCapacityC;
        public int LoadCapacityC
        {
            get { return _LoadCapacityC; }

            private set
            {
                _LoadCapacityC = value;
                LoadCapacityA = (RatedCapacity * _LoadCapacityC) / 1000.0;
            }
        }


        /// <summary>
        /// Load capacity [A]
        /// </summary>
        public double LoadCapacityA { get; private set; }


        /// <summary>
        /// Accu type to be set on charging
        /// </summary>
        public string ChargeAccuType { get; private set; }


        /// <summary>
        /// Rated charge current [mA]
        /// </summary>
        public int ChargeCurrent { get; private set; }


        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Methods
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++  

        /// <summary>
        /// Calculates the accu values
        /// </summary>
        public void CalcValues()
        {

            // Voltage
            // -----------------

            // If cell count was entered:
            if (opt_Anzahl_Zellen.Checked == true)
            {
                // Cell count is entered
                IsCellCountSpecified = true;

                // Type "Lipo" is selected
                if (opt_Typ_Lipo.Checked == true)
                {
                    cmb_Zellen_S.Visible = true;
                    ud_Zellen_N.Visible = false;
                    CellCount = cmb_Zellen_S.SelectedIndex + 1;
                }
                // Type "Lipo" is not selected
                else
                {
                    cmb_Zellen_S.Visible = false;
                    ud_Zellen_N.Visible = true;
                    CellCount = Convert.ToInt32(ud_Zellen_N.Value);
                }

                ud_Spannung.Visible = false;
                lbl_V.Visible = false;
                lbl_Erg_V_Zellen_Headline.Text = "Spannung";
            }

            // Voltage is entered:
            if (opt_Spannung.Checked == true)
            {
                // Cell count is not entered
                IsCellCountSpecified = false;

                cmb_Zellen_S.Visible = false;
                ud_Zellen_N.Visible = false;

                ud_Spannung.Visible = true;

                ud_Spannung.Increment = Convert.ToDecimal(AccuPack.CellVoltage);
                RatedVoltage = Convert.ToDouble(ud_Spannung.Value);

                lbl_V.Visible = true;
                lbl_Erg_V_Zellen_Headline.Text = "Zellen";
            }


            // Capacity and Load capacity
            // -----------------
            RatedCapacity = Convert.ToInt32(ud_Kapazitaet.Value);
            LoadCapacityC = Convert.ToInt32(ud_Belastbarkeit_C.Value);


            // Charging accu type
            // -----------------
            if (Type == Accu.AccuType.LiPo)     { ChargeAccuType = Convert.ToString(Accu.AccuType.LiPo); }
            if (Type == Accu.AccuType.NiMH)     { ChargeAccuType = Convert.ToString(Accu.AccuType.NiMH); }
            if (Type == Accu.AccuType.eneloop)  { ChargeAccuType = Convert.ToString(Accu.AccuType.NiMH); }
            if (Type == Accu.AccuType.NiCd)     { ChargeAccuType = Convert.ToString(Accu.AccuType.NiCd); }
        }


    }
}
