
namespace AppBank
{
    partial class Convertiseur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Convertiseur));
            this.main = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.val1 = new System.Windows.Forms.NumericUpDown();
            this.Devise2 = new System.Windows.Forms.ComboBox();
            this.val2curency = new System.Windows.Forms.TextBox();
            this.val2 = new System.Windows.Forms.TextBox();
            this.convertir = new System.Windows.Forms.Button();
            this.Devise1 = new System.Windows.Forms.ComboBox();
            this.main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.val1)).BeginInit();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.main.Controls.Add(this.panel2);
            this.main.Controls.Add(this.panel1);
            this.main.Controls.Add(this.val1);
            this.main.Controls.Add(this.Devise2);
            this.main.Controls.Add(this.val2curency);
            this.main.Controls.Add(this.val2);
            this.main.Controls.Add(this.convertir);
            this.main.Controls.Add(this.Devise1);
            this.main.Location = new System.Drawing.Point(229, 32);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(328, 365);
            this.main.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel2.Location = new System.Drawing.Point(19, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 2);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(250, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(56, 41);
            this.panel1.TabIndex = 12;
            // 
            // val1
            // 
            this.val1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.val1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.val1.Font = new System.Drawing.Font("Nirmala UI", 21F);
            this.val1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.val1.Location = new System.Drawing.Point(19, 16);
            this.val1.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.val1.Name = "val1";
            this.val1.Size = new System.Drawing.Size(287, 41);
            this.val1.TabIndex = 11;
            // 
            // Devise2
            // 
            this.Devise2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Devise2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Devise2.Font = new System.Drawing.Font("Nirmala UI", 21F);
            this.Devise2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Devise2.FormattingEnabled = true;
            this.Devise2.Items.AddRange(new object[] {
            "MAD",
            "USD",
            "EUR"});
            this.Devise2.Location = new System.Drawing.Point(19, 150);
            this.Devise2.Name = "Devise2";
            this.Devise2.Size = new System.Drawing.Size(287, 46);
            this.Devise2.TabIndex = 10;
            // 
            // val2curency
            // 
            this.val2curency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.val2curency.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.val2curency.Font = new System.Drawing.Font("Nirmala UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val2curency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.val2curency.Location = new System.Drawing.Point(166, 292);
            this.val2curency.Name = "val2curency";
            this.val2curency.Size = new System.Drawing.Size(140, 38);
            this.val2curency.TabIndex = 9;
            // 
            // val2
            // 
            this.val2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.val2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.val2.Font = new System.Drawing.Font("Nirmala UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.val2.Location = new System.Drawing.Point(20, 292);
            this.val2.Name = "val2";
            this.val2.Size = new System.Drawing.Size(140, 38);
            this.val2.TabIndex = 8;
            this.val2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // convertir
            // 
            this.convertir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.convertir.FlatAppearance.BorderSize = 0;
            this.convertir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertir.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold);
            this.convertir.Location = new System.Drawing.Point(19, 218);
            this.convertir.Name = "convertir";
            this.convertir.Size = new System.Drawing.Size(287, 46);
            this.convertir.TabIndex = 5;
            this.convertir.Text = "Convertir";
            this.convertir.UseVisualStyleBackColor = false;
            this.convertir.Click += new System.EventHandler(this.convertir_Click);
            // 
            // Devise1
            // 
            this.Devise1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Devise1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Devise1.Font = new System.Drawing.Font("Nirmala UI", 21F);
            this.Devise1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Devise1.FormattingEnabled = true;
            this.Devise1.IntegralHeight = false;
            this.Devise1.Items.AddRange(new object[] {
            "MAD",
            "USD",
            "EUR"});
            this.Devise1.Location = new System.Drawing.Point(19, 82);
            this.Devise1.Name = "Devise1";
            this.Devise1.Size = new System.Drawing.Size(287, 46);
            this.Devise1.TabIndex = 2;
            // 
            // Convertiseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.main);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Convertiseur";
            this.Text = "converter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.val1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.ComboBox Devise1;
        private System.Windows.Forms.Button convertir;
        private System.Windows.Forms.TextBox val2;
        private System.Windows.Forms.TextBox val2curency;
        private System.Windows.Forms.ComboBox Devise2;
        private System.Windows.Forms.NumericUpDown val1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}