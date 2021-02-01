using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Flyer
{
    public partial class MainWindow : Form
    {


        /// <summary>
        /// Form: Constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form: Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.Text = "Flyer - Version " + FlyerVersion.Number;
            this.Size = new Size(1000, 620);
            this.CenterToScreen();
        }

        /// <summary>
        /// Form: Close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Programm beenden ?", "Flyer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            { 
                e.Cancel = true; 
            }
        }


        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Akkudaten-Form anzeigen
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void pic_IconAkku_Click(object sender, EventArgs e)
        {
            ShowAccuDataWindow();
        }

        private void lbl_IconAkku_Click(object sender, EventArgs e)
        {
            ShowAccuDataWindow();
        }


        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Info-Form anzeigen
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void lbl_IconInfo_Click(object sender, EventArgs e)
        {
            using (InfoWindow InfoWin = new InfoWindow())
            {
                InfoWin.ShowDialog();
            }
        }



        private void ShowAccuDataWindow()
        {
            this.Hide();
            using (AccuDataWindow AccuDataWin = new AccuDataWindow())
            {
                AccuDataWin.ShowDialog();
            }
            this.Show();
        }




    }
}