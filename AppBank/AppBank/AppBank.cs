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

namespace AppBank
{
    public partial class AppBank : Form
    {
        public AppBank()
        {
            InitializeComponent();
        }

        private void accueil_Click(object sender, EventArgs e)
        {
            change_pnlnav(sender);
        }

        private void add_client_Click(object sender, EventArgs e)
        {
            change_pnlnav(sender);
            AddClients newcl = new AddClients() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            container.Controls.Add(newcl);
            newcl.Show();
        }

        private void add_compt_Click(object sender, EventArgs e)
        {
            change_pnlnav(sender);
            AddAccount newac = new AddAccount() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            container.Controls.Add(newac);
            newac.Show();
        }

        private void transaction_Click(object sender, EventArgs e)
        {
            change_pnlnav(sender);
        }

        private void convert_Click(object sender, EventArgs e)
        {
            change_pnlnav(sender);
            Convertiseur conv = new Convertiseur() { TopLevel = false, TopMost = true,Dock=DockStyle.Fill };
            container.Controls.Add(conv);
            conv.Show();
            
        }
        private void change_pnlnav(object sender)
        {
            Button btn = (Button)sender;
            pnlNav.Width = 3;
            pnlNav.Height = btn.Height;
            pnlNav.Location = btn.Location;
            container.Controls.Clear();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
