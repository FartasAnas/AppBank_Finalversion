
namespace AppBank
{
    partial class AppBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppBank));
            this.Management = new System.Windows.Forms.Panel();
            this.convert = new System.Windows.Forms.Button();
            this.transaction = new System.Windows.Forms.Button();
            this.add_compt = new System.Windows.Forms.Button();
            this.add_client = new System.Windows.Forms.Button();
            this.accueil = new System.Windows.Forms.Button();
            this.UserInfo = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Button();
            this.container = new System.Windows.Forms.Panel();
            this.admin = new System.Windows.Forms.Label();
            this.UserPic = new System.Windows.Forms.PictureBox();
            this.Management.SuspendLayout();
            this.UserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPic)).BeginInit();
            this.SuspendLayout();
            // 
            // Management
            // 
            this.Management.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.Management.Controls.Add(this.convert);
            this.Management.Controls.Add(this.transaction);
            this.Management.Controls.Add(this.add_compt);
            this.Management.Controls.Add(this.add_client);
            this.Management.Controls.Add(this.accueil);
            this.Management.Controls.Add(this.UserInfo);
            this.Management.Dock = System.Windows.Forms.DockStyle.Left;
            this.Management.Location = new System.Drawing.Point(0, 0);
            this.Management.Name = "Management";
            this.Management.Size = new System.Drawing.Size(186, 577);
            this.Management.TabIndex = 0;
            // 
            // convert
            // 
            this.convert.FlatAppearance.BorderSize = 0;
            this.convert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convert.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.convert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.convert.Image = ((System.Drawing.Image)(resources.GetObject("convert.Image")));
            this.convert.Location = new System.Drawing.Point(0, 368);
            this.convert.Name = "convert";
            this.convert.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.convert.Size = new System.Drawing.Size(186, 42);
            this.convert.TabIndex = 5;
            this.convert.Text = "Convertiseur      ";
            this.convert.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // transaction
            // 
            this.transaction.FlatAppearance.BorderSize = 0;
            this.transaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transaction.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.transaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.transaction.Image = ((System.Drawing.Image)(resources.GetObject("transaction.Image")));
            this.transaction.Location = new System.Drawing.Point(0, 320);
            this.transaction.Name = "transaction";
            this.transaction.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.transaction.Size = new System.Drawing.Size(186, 42);
            this.transaction.TabIndex = 4;
            this.transaction.Text = "Transaction       ";
            this.transaction.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.transaction.UseVisualStyleBackColor = true;
            this.transaction.Click += new System.EventHandler(this.transaction_Click);
            // 
            // add_compt
            // 
            this.add_compt.FlatAppearance.BorderSize = 0;
            this.add_compt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_compt.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.add_compt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.add_compt.Image = ((System.Drawing.Image)(resources.GetObject("add_compt.Image")));
            this.add_compt.Location = new System.Drawing.Point(0, 272);
            this.add_compt.Name = "add_compt";
            this.add_compt.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.add_compt.Size = new System.Drawing.Size(186, 42);
            this.add_compt.TabIndex = 3;
            this.add_compt.Text = "Ajout de Compts";
            this.add_compt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.add_compt.UseVisualStyleBackColor = true;
            this.add_compt.Click += new System.EventHandler(this.add_compt_Click);
            // 
            // add_client
            // 
            this.add_client.FlatAppearance.BorderSize = 0;
            this.add_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_client.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.add_client.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.add_client.Image = ((System.Drawing.Image)(resources.GetObject("add_client.Image")));
            this.add_client.Location = new System.Drawing.Point(0, 224);
            this.add_client.Name = "add_client";
            this.add_client.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.add_client.Size = new System.Drawing.Size(186, 42);
            this.add_client.TabIndex = 2;
            this.add_client.Text = "Ajout de Clients  ";
            this.add_client.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.add_client.UseVisualStyleBackColor = true;
            this.add_client.Click += new System.EventHandler(this.add_client_Click);
            // 
            // accueil
            // 
            this.accueil.FlatAppearance.BorderSize = 0;
            this.accueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accueil.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.accueil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.accueil.Image = ((System.Drawing.Image)(resources.GetObject("accueil.Image")));
            this.accueil.Location = new System.Drawing.Point(0, 176);
            this.accueil.Name = "accueil";
            this.accueil.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.accueil.Size = new System.Drawing.Size(186, 42);
            this.accueil.TabIndex = 1;
            this.accueil.Text = "Accueil               ";
            this.accueil.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.accueil.UseVisualStyleBackColor = true;
            this.accueil.Click += new System.EventHandler(this.accueil_Click);
            // 
            // UserInfo
            // 
            this.UserInfo.Controls.Add(this.admin);
            this.UserInfo.Controls.Add(this.UserPic);
            this.UserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserInfo.Location = new System.Drawing.Point(0, 0);
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.Size = new System.Drawing.Size(186, 170);
            this.UserInfo.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 176);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 42);
            this.pnlNav.TabIndex = 3;
            // 
            // Close
            // 
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(908, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(31, 26);
            this.Close.TabIndex = 4;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // container
            // 
            this.container.Location = new System.Drawing.Point(192, 51);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(747, 514);
            this.container.TabIndex = 5;
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.admin.Location = new System.Drawing.Point(32, 118);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(118, 22);
            this.admin.TabIndex = 1;
            this.admin.Text = "Anas Fartas";
            this.admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserPic
            // 
            this.UserPic.Image = ((System.Drawing.Image)(resources.GetObject("UserPic.Image")));
            this.UserPic.Location = new System.Drawing.Point(53, 25);
            this.UserPic.Name = "UserPic";
            this.UserPic.Size = new System.Drawing.Size(79, 80);
            this.UserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPic.TabIndex = 0;
            this.UserPic.TabStop = false;
            // 
            // AppBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.container);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.Management);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppBank";
            this.Management.ResumeLayout(false);
            this.UserInfo.ResumeLayout(false);
            this.UserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Management;
        private System.Windows.Forms.Panel UserInfo;
        private System.Windows.Forms.Button accueil;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Button transaction;
        private System.Windows.Forms.Button add_compt;
        private System.Windows.Forms.Button add_client;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Label admin;
        private System.Windows.Forms.PictureBox UserPic;
    }
}

