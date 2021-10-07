using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a_grund_farbfuellung
{
    public partial class Farbabfuellung : Form
    {
        public Farbabfuellung()
        {
            InitializeComponent();
            UpdatePicture();
        }

        // Checkboxen abfragen und anhand der Farbeigenschaften die Bilder aussuchen
        private void UpdatePicture() {
            
            // boolesche Variablen, die Zustand der Checkboxen abfragen
            cb_giftig.Checked
            cb_feuer.Checked

            // Zuweisungsmöglichkeiten der einzelnen Kanister
            pb_behaelter.Image = Image.FromFile("icon_eimer.png");
            pb_behaelter.Image = Image.FromFile("icon_kanister_kunststoff.png");
            pb_behaelter.Image = Image.FromFile("icon_kanister_blech.png");

        }
        private void ColorPropertyChanged(object sender, EventArgs e)
        {
            UpdatePicture();
        }
    }
}
