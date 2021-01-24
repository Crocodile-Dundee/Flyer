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
    public partial class SelectorWindow : Form
    {

        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Variablen und Konstanten
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private const int FORM_WIDTH = 600;
        private const int FORM_HEIGHT = 400;

        AccuDataWindow Akkudaten;
        InfoWindow Info;


        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Konstruktor
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public SelectorWindow()
        {
            InitializeComponent();
            Akkudaten = new AccuDataWindow();    // Akkudaten-Form instanzieren
            Info = new InfoWindow();              // Info-Form instanzieren
        }


        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Form laden
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void formSelector_Load(object sender, EventArgs e)
        {
            this.Text = "Flyer - Version " + FlyerVersion.Number;
        }


        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Formgröße beibehalten
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void formSelector_Resize(object sender, EventArgs e)
        {
            // Größe der Form beibehalten beim Versuch zu resizen
            this.Width = FORM_WIDTH;
            this.Height = FORM_HEIGHT;
        }

        
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Akkudaten-Form anzeigen
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void picIconAkku_Click(object sender, EventArgs e)
        {
            this.Hide();
            Akkudaten.ShowDialog();
            this.Show();
        }

        private void lblIconAkku_Click(object sender, EventArgs e)
        {
            this.Hide();
            Akkudaten.ShowDialog();
            this.Show();
        }


        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Info-Form anzeigen
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void lblIconInfo_Click_1(object sender, EventArgs e)
        {
            Info.ShowDialog();
        }



        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Abfrage Form schliessen
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void formSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Programm beenden ?", "Flyer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) { e.Cancel = true; }
        }




    }
}