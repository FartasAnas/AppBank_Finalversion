using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeviseLLibraries;

namespace AppBank
{
    public partial class Convertiseur : Form
    {
        public Convertiseur()
        {
            InitializeComponent();
        }

        private void convertir_Click(object sender, EventArgs e)
        {
            double montant = double.Parse(val1.Text);
            string type = Devise1.Text;
            Devise dev;
            if (type == "MAD")
                dev = new MAD(montant);
            else if (type == "US")
                dev = new USD(montant);
            else
                dev = new EUR(montant);

            Devise res = dev.ConvertTo(Devise2.Text);

            val2.Text = res.afficherDevise();
            val2curency.Text = Devise2.Text;
        }
    }
}
