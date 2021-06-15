using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankLibrary;
using DeviseLLibraries;

namespace AppBank
{
    public partial class AddAccount : Form
    {
        public static Compt[] Compts = new Compt[0];
        protected int nbrCompt = 0;
        public AddAccount()
        {
            InitializeComponent();

        }
        //private void ajouter_Click(object sender, EventArgs e)
        //{
        //    if(nom.Text != "" && prenom.Text != "" && account_type.Text != "" && currency.Text != "")
        //    {
        //        Devise dev;
        //        if (account_type.Text == "MAD")
        //            dev = new MAD(Convert.ToDouble(solde.Value));
        //        else if (account_type.Text == "US")
        //            dev = new USD(Convert.ToDouble(solde.Value));
        //        else
        //            dev = new EUR(Convert.ToDouble(solde.Value));

        //        MAD res = (MAD)dev.ConvertTo("MAD");
        //    }
        //}
        private void account_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (account_type.Text == "Courant")
            {
                panel8.Visible = true;
                vald_t.Visible = true;
                purcentage.Visible = false;
                d_t.Text = "Decouvert";
            }
            else if(account_type.Text == "Epargne")
            {
                panel8.Visible = true;
                purcentage.Visible = true;
                vald_t.Visible = true;
                d_t.Text = "Taux Interet";
            }
            else
            {
                panel8.Visible = false;
                purcentage.Visible = false;
                vald_t.Visible = false;
                d_t.Text = "";
            }
        }

        
    }
}
