using System;
using System.Drawing;
using System.Windows.Forms;

namespace Flyer
{
    // ---------------------------------------------------------------------------------
    // Enumerations
    // ---------------------------------------------------------------------------------

    // ---------------------------------------------------------------------------------
    // Form
    // --------------------------------------------------------------------------------- 

    /// <summary>
    /// Accu Data Window
    /// </summary>
    public partial class AccuDataWindow : Form
    {

        // ---------------------------------------------------------------------------------
        // Declarations
        // ---------------------------------------------------------------------------------

        Accu AccuPack = new Accu();


        // ---------------------------------------------------------------------------------
        // Declarations
        // ---------------------------------------------------------------------------------
        // Form
        // ---------------------------------------------------------------------------------

        /// <summary>
        /// Form: Constructor
        /// </summary>
        public AccuDataWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form: Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccuDataWindow_Load(object sender, EventArgs e)
        {
            // Form
            this.Size = new Size(1018, 595);
            this.CenterToScreen();

            // - Set Type
            opt_Type_Lipo.Checked = true;

            // - Set Voltage
            opt_CellCount.Checked = true;
            cmb_CelCount_S.SelectedIndex = 0;
        }


        // ---------------------------------------------------------------------------------
        // Form
        // ---------------------------------------------------------------------------------
        // Controls
        // ---------------------------------------------------------------------------------

        // Type
        // +++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// RadioButton: Accu Type "Lipo" changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// RadioButton: Accu Type "NiMH" changed
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// RadioButton: Accu Type "eneloo" changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// RadioButton: Accu Type "NiCd" changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        // Voltage
        // +++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// RadioButton: Cell count changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void opt_CellCount_CheckedChanged(object sender, EventArgs e)
        {
            CalcAccuValues();
        }

        /// <summary>
        ///RadioButton: Voltage changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void opt_Voltage_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_Voltage.Checked)
            {
                nud_Voltage.Visible = true;
                lbl_V.Visible = true;

                cmb_CelCount_S.Visible = false;
                nud_CellCount.Visible = false;

                nud_Voltage.Minimum = Convert.ToDecimal(AccuPack.CellVoltage);
                nud_Voltage.Value = Convert.ToDecimal(AccuPack.CellVoltage);
            }
            else
            {
                nud_Voltage.Visible = false;
                lbl_V.Visible = false;

                if (AccuPack.Type == Accu.AccuType.LiPo)
                {
                    cmb_CelCount_S.Visible = true;
                    nud_CellCount.Visible = false;
                }
                else
                {
                    cmb_CelCount_S.Visible = false;
                    nud_CellCount.Visible = true;
                }
            }
            CalcAccuValues();
        }


        /// <summary>
        /// NumericUpDown: Cell count
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nud_CellCount_ValueChanged(object sender, EventArgs e)
        {
            CalcAccuValues();
        }

        /// <summary>
        /// ComboBox: Cell count
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_CellCount_S_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CalcAccuValues();
        }

        /// <summary>
        /// NumericUpDown: Voltage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nud_Voltage_ValueChanged(object sender, EventArgs e)
        {
            CalcAccuValues();
        }


        // Capacity and Load capacity
        // +++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// NumericUpDown: Capacity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nud_Capacity_ValueChanged(object sender, EventArgs e)
        {
            CalcAccuValues();
        }

        /// <summary>
        /// NumericUpDown: Load Capacity [C]
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nud_LoadCapacity_C_ValueChanged(object sender, EventArgs e)
        {
            CalcAccuValues();
        }

        // ---------------------------------------------------------------------------------
        // Controls
        // ---------------------------------------------------------------------------------
        // Methods
        // ---------------------------------------------------------------------------------

        /// <summary>
        /// Calculate the accu values
        /// </summary>
        public void CalcAccuValues()
        {
            // Read valuea 

            // - Accu type
            if (opt_Type_Lipo.Checked)    { AccuPack.Type = Accu.AccuType.LiPo; }
            if (opt_Type_NiMH.Checked)    { AccuPack.Type = Accu.AccuType.NiMH; }
            if (opt_Type_eneloop.Checked) { AccuPack.Type = Accu.AccuType.eneloop; }
            if (opt_Type_NiCd.Checked)    { AccuPack.Type = Accu.AccuType.NiCd; }

            // - Voltage
            if (opt_CellCount.Checked)
            {
                AccuPack.IsCellCountSpecified = true;
            }
            else
            {

            }

            // Calculate values
            AccuPack.CalcValues();

            // Show values     

            // - Voltage
            if (opt_CellCount.Checked == true)
            {
                lbl_Res_Voltage_CellCount.Text = Convert.ToString(string.Format("Der Akku hat eine Nennspannung von {0:0.0} V", AccuPack.RatedVoltage));
            }
            // - Cell count
            else
            {
                if (AccuPack.CellCount == 1)
                {
                    lbl_Res_Voltage_CellCount.Text = Convert.ToString(string.Format("Der Akku hat 1 Zelle.", AccuPack.CellCount));
                }
                else
                {
                    lbl_Res_Voltage_CellCount.Text = Convert.ToString(string.Format("Der Akku hat {0} Zellen.", AccuPack.CellCount));
                }
            }


            // - Load capacity
            lbl_Res_LoadCapacity.Text = Convert.ToString(string.Format("Der Akku ist belastbar mit max. {0:0.0} A.", AccuPack.LoadCapacityA));
        
            // - Charging
            lbl_Res_AccuType.Text = AccuPack.ChargeAccuType;
        }


    }
}

