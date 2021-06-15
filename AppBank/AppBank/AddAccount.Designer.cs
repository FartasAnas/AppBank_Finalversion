
namespace AppBank
{
    partial class AddAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccount));
            this.nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ajouter = new System.Windows.Forms.Button();
            this.account_type = new System.Windows.Forms.ComboBox();
            this.currency = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.d_t = new System.Windows.Forms.Label();
            this.solde = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.new_account = new System.Windows.Forms.Panel();
            this.vald_t = new System.Windows.Forms.NumericUpDown();
            this.purcentage = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.solde)).BeginInit();
            this.panel4.SuspendLayout();
            this.new_account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vald_t)).BeginInit();
            this.purcentage.SuspendLayout();
            this.SuspendLayout();
            // 
            // nom
            // 
            this.nom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nom.Font = new System.Drawing.Font("Nirmala UI", 21F);
            this.nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.nom.Location = new System.Drawing.Point(30, 33);
            this.nom.MaximumSize = new System.Drawing.Size(132, 45);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(132, 45);
            this.nom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client Nom";
            // 
            // prenom
            // 
            this.prenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.prenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prenom.Font = new System.Drawing.Font("Nirmala UI", 21F);
            this.prenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.prenom.Location = new System.Drawing.Point(166, 33);
            this.prenom.MaximumSize = new System.Drawing.Size(132, 45);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(132, 45);
            this.prenom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(164, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Client Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(27, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type de compte";
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ajouter.FlatAppearance.BorderSize = 0;
            this.ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajouter.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold);
            this.ajouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ajouter.Location = new System.Drawing.Point(30, 322);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(268, 45);
            this.ajouter.TabIndex = 6;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // account_type
            // 
            this.account_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.account_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.account_type.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.account_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.account_type.FormattingEnabled = true;
            this.account_type.Items.AddRange(new object[] {
            "Courant",
            "Epargne",
            "Payante"});
            this.account_type.Location = new System.Drawing.Point(29, 108);
            this.account_type.Name = "account_type";
            this.account_type.Size = new System.Drawing.Size(268, 45);
            this.account_type.TabIndex = 2;
            this.account_type.SelectedIndexChanged += new System.EventHandler(this.account_type_SelectedIndexChanged);
            // 
            // currency
            // 
            this.currency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.currency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currency.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.currency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.currency.FormattingEnabled = true;
            this.currency.Items.AddRange(new object[] {
            "MAD",
            "USD",
            "EUR"});
            this.currency.Location = new System.Drawing.Point(166, 184);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(131, 45);
            this.currency.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label4.Location = new System.Drawing.Point(27, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Solde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label5.Location = new System.Drawing.Point(164, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Devise";
            // 
            // d_t
            // 
            this.d_t.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_t.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.d_t.Location = new System.Drawing.Point(27, 244);
            this.d_t.Name = "d_t";
            this.d_t.Size = new System.Drawing.Size(78, 15);
            this.d_t.TabIndex = 11;
            // 
            // solde
            // 
            this.solde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.solde.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.solde.Font = new System.Drawing.Font("Nirmala UI", 23F);
            this.solde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.solde.Location = new System.Drawing.Point(30, 184);
            this.solde.Name = "solde";
            this.solde.Size = new System.Drawing.Size(126, 44);
            this.solde.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel3.Location = new System.Drawing.Point(29, 185);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 44);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(132, 184);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(24, 44);
            this.panel4.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel2.Location = new System.Drawing.Point(23, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 50);
            this.panel2.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel5.Location = new System.Drawing.Point(30, 228);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(126, 1);
            this.panel5.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel1.Location = new System.Drawing.Point(29, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 1);
            this.panel1.TabIndex = 10;
            // 
            // new_account
            // 
            this.new_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.new_account.Controls.Add(this.panel8);
            this.new_account.Controls.Add(this.purcentage);
            this.new_account.Controls.Add(this.vald_t);
            this.new_account.Controls.Add(this.panel1);
            this.new_account.Controls.Add(this.panel5);
            this.new_account.Controls.Add(this.panel4);
            this.new_account.Controls.Add(this.panel3);
            this.new_account.Controls.Add(this.solde);
            this.new_account.Controls.Add(this.d_t);
            this.new_account.Controls.Add(this.label5);
            this.new_account.Controls.Add(this.label4);
            this.new_account.Controls.Add(this.currency);
            this.new_account.Controls.Add(this.account_type);
            this.new_account.Controls.Add(this.ajouter);
            this.new_account.Controls.Add(this.label3);
            this.new_account.Controls.Add(this.label2);
            this.new_account.Controls.Add(this.prenom);
            this.new_account.Controls.Add(this.label1);
            this.new_account.Controls.Add(this.nom);
            this.new_account.Location = new System.Drawing.Point(236, 33);
            this.new_account.Name = "new_account";
            this.new_account.Size = new System.Drawing.Size(328, 381);
            this.new_account.TabIndex = 1;
            // 
            // vald_t
            // 
            this.vald_t.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.vald_t.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vald_t.Font = new System.Drawing.Font("Nirmala UI", 23F);
            this.vald_t.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.vald_t.Location = new System.Drawing.Point(29, 262);
            this.vald_t.Name = "vald_t";
            this.vald_t.Size = new System.Drawing.Size(268, 44);
            this.vald_t.TabIndex = 13;
            this.vald_t.Visible = false;
            // 
            // purcentage
            // 
            this.purcentage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("purcentage.BackgroundImage")));
            this.purcentage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.purcentage.Controls.Add(this.panel7);
            this.purcentage.Location = new System.Drawing.Point(274, 262);
            this.purcentage.Name = "purcentage";
            this.purcentage.Size = new System.Drawing.Size(24, 44);
            this.purcentage.TabIndex = 13;
            this.purcentage.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel7.Location = new System.Drawing.Point(23, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 50);
            this.panel7.TabIndex = 10;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel8.Location = new System.Drawing.Point(29, 304);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(268, 2);
            this.panel8.TabIndex = 2;
            this.panel8.Visible = false;
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.new_account);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAccount";
            this.Text = "Addaccount";
            ((System.ComponentModel.ISupportInitialize)(this.solde)).EndInit();
            this.panel4.ResumeLayout(false);
            this.new_account.ResumeLayout(false);
            this.new_account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vald_t)).EndInit();
            this.purcentage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.ComboBox account_type;
        private System.Windows.Forms.ComboBox currency;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label d_t;
        private System.Windows.Forms.NumericUpDown solde;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel new_account;
        private System.Windows.Forms.Panel purcentage;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.NumericUpDown vald_t;
        private System.Windows.Forms.Panel panel8;
    }
}