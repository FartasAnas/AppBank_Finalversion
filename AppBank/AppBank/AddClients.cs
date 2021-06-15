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
    public partial class AddClients : Form
    {
        public static Client[] clients = new Client[0];
        protected int nbrClient = 0;
        private int check = 0;
        public AddClients()
        {
            InitializeComponent();
            
        }
        //public void association(Compt acc, string n, string p, MAD s,string type,double d_t)
        //{
        //    for (int i = 0; i < nbrClient; i++)
        //    {
        //        if (clients[i].Client_check(clients[i],n,p))
        //        {
        //            if (type == "Courant")
        //                acc = new CompteCourant(clients[i], s, d_t);
        //            else if (type == "Epargne")
        //                acc = new CompteEpargne(clients[i], s, d_t);
        //            else
        //                acc = new ComptePayante(clients[i], s);
        //        }
        //    }
        //}

        private void ajouter_Click(object sender, EventArgs e)
        {
            if (nom.Text != "" && prenom.Text != "" && adresse.Text != "")
            {
                for(int i = 0; i < nbrClient; i++)
                {
                    if (clients[i].Client_check(clients[i], nom.Text, prenom.Text)) { }
                    else
                         check = 1;
                }
                if (check == 0) {
                    Array.Resize(ref clients, clients.Length + 1);
                    clients[nbrClient] = new Client(nom.Text, prenom.Text, adresse.Text);
                    nbrClient++;
                    addedname.Text = nom.Text + " " + prenom.Text;
                    addedadr.Text = adresse.Text;
                    msgbox.Width = new_client.Width;
                    msgbox.Height = new_client.Height;
                    msgbox.Location = new_client.Location;
                }
                else if(check==1)
                {
                    erreur.Text = "Client Exist";
                    Error.Width = new_client.Width;
                    Error.Height = new_client.Height;
                    Error.Location = new_client.Location;
                }
            }
            else
            {
                erreur.Text = "informations incorrectes";
                Error.Width= new_client.Width; 
                Error.Height= new_client.Height;
                Error.Location= new_client.Location;
            }

        }

        private void msgbox_clear(object sender, EventArgs e)
        {
            msgbox.Width = 0;
            msgbox.Height = 0;
            msgbox.Location = new Point(0, 0);
            nom.Text = "";
            prenom.Text = "";
            adresse.Text = "";
        }

        private void continuez_Click(object sender, EventArgs e)
        {
            Error.Width = 0;
            Error.Height = 0;
            Error.Location = new Point(0, 0);
            nom.Text = "";
            prenom.Text = "";
            adresse.Text = "";
        }
    }
}
