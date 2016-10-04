namespace pharmacy
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_sifraPr = new System.Windows.Forms.Label();
            this.lb_naziv = new System.Windows.Forms.Label();
            this.lb_proizvodjac = new System.Windows.Forms.Label();
            this.lb_cijena = new System.Windows.Forms.Label();
            this.lb_rokU = new System.Windows.Forms.Label();
            this.lb_kolicina = new System.Windows.Forms.Label();
            this.lb_atcS = new System.Windows.Forms.Label();
            this.lb_oblik = new System.Windows.Forms.Label();
            this.lb_lista = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tb_sifraP = new System.Windows.Forms.TextBox();
            this.tb_naziv = new System.Windows.Forms.TextBox();
            this.tb_kolicina = new System.Windows.Forms.TextBox();
            this.tb_cijena = new System.Windows.Forms.TextBox();
            this.tb_oblik = new System.Windows.Forms.TextBox();
            this.tb_proizvodjac = new System.Windows.Forms.TextBox();
            this.tb_lista = new System.Windows.Forms.TextBox();
            this.tb_atcS = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lb_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(106, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(118, 18);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "Add medicament";
            // 
            // lb_sifraPr
            // 
            this.lb_sifraPr.AutoSize = true;
            this.lb_sifraPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sifraPr.Location = new System.Drawing.Point(12, 40);
            this.lb_sifraPr.Name = "lb_sifraPr";
            this.lb_sifraPr.Size = new System.Drawing.Size(88, 15);
            this.lb_sifraPr.TabIndex = 1;
            this.lb_sifraPr.Text = "Sifra proizvoda";
            // 
            // lb_naziv
            // 
            this.lb_naziv.AutoSize = true;
            this.lb_naziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_naziv.Location = new System.Drawing.Point(12, 70);
            this.lb_naziv.Name = "lb_naziv";
            this.lb_naziv.Size = new System.Drawing.Size(37, 15);
            this.lb_naziv.TabIndex = 2;
            this.lb_naziv.Text = "Naziv";
            // 
            // lb_proizvodjac
            // 
            this.lb_proizvodjac.AutoSize = true;
            this.lb_proizvodjac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_proizvodjac.Location = new System.Drawing.Point(12, 92);
            this.lb_proizvodjac.Name = "lb_proizvodjac";
            this.lb_proizvodjac.Size = new System.Drawing.Size(70, 15);
            this.lb_proizvodjac.TabIndex = 3;
            this.lb_proizvodjac.Text = "Proizvodjac";
            // 
            // lb_cijena
            // 
            this.lb_cijena.AutoSize = true;
            this.lb_cijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cijena.Location = new System.Drawing.Point(12, 119);
            this.lb_cijena.Name = "lb_cijena";
            this.lb_cijena.Size = new System.Drawing.Size(42, 15);
            this.lb_cijena.TabIndex = 4;
            this.lb_cijena.Text = "Cijena";
            // 
            // lb_rokU
            // 
            this.lb_rokU.AutoSize = true;
            this.lb_rokU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rokU.Location = new System.Drawing.Point(12, 175);
            this.lb_rokU.Name = "lb_rokU";
            this.lb_rokU.Size = new System.Drawing.Size(81, 15);
            this.lb_rokU.TabIndex = 5;
            this.lb_rokU.Text = "Rok upotrebe";
            // 
            // lb_kolicina
            // 
            this.lb_kolicina.AutoSize = true;
            this.lb_kolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_kolicina.Location = new System.Drawing.Point(12, 145);
            this.lb_kolicina.Name = "lb_kolicina";
            this.lb_kolicina.Size = new System.Drawing.Size(51, 15);
            this.lb_kolicina.TabIndex = 6;
            this.lb_kolicina.Text = "Kolicina";
            // 
            // lb_atcS
            // 
            this.lb_atcS.AutoSize = true;
            this.lb_atcS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_atcS.Location = new System.Drawing.Point(12, 202);
            this.lb_atcS.Name = "lb_atcS";
            this.lb_atcS.Size = new System.Drawing.Size(55, 15);
            this.lb_atcS.TabIndex = 7;
            this.lb_atcS.Text = "ATC sifra";
            // 
            // lb_oblik
            // 
            this.lb_oblik.AutoSize = true;
            this.lb_oblik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_oblik.Location = new System.Drawing.Point(12, 224);
            this.lb_oblik.Name = "lb_oblik";
            this.lb_oblik.Size = new System.Drawing.Size(35, 15);
            this.lb_oblik.TabIndex = 8;
            this.lb_oblik.Text = "Oblik";
            // 
            // lb_lista
            // 
            this.lb_lista.AutoSize = true;
            this.lb_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lista.Location = new System.Drawing.Point(12, 254);
            this.lb_lista.Name = "lb_lista";
            this.lb_lista.Size = new System.Drawing.Size(33, 15);
            this.lb_lista.TabIndex = 9;
            this.lb_lista.Text = "Lista";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(149, 299);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(245, 299);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // tb_sifraP
            // 
            this.tb_sifraP.Location = new System.Drawing.Point(109, 39);
            this.tb_sifraP.Name = "tb_sifraP";
            this.tb_sifraP.Size = new System.Drawing.Size(211, 20);
            this.tb_sifraP.TabIndex = 1;
            // 
            // tb_naziv
            // 
            this.tb_naziv.Location = new System.Drawing.Point(109, 65);
            this.tb_naziv.Name = "tb_naziv";
            this.tb_naziv.Size = new System.Drawing.Size(211, 20);
            this.tb_naziv.TabIndex = 2;
            // 
            // tb_kolicina
            // 
            this.tb_kolicina.Location = new System.Drawing.Point(109, 145);
            this.tb_kolicina.Name = "tb_kolicina";
            this.tb_kolicina.Size = new System.Drawing.Size(211, 20);
            this.tb_kolicina.TabIndex = 5;
            // 
            // tb_cijena
            // 
            this.tb_cijena.Location = new System.Drawing.Point(109, 119);
            this.tb_cijena.Name = "tb_cijena";
            this.tb_cijena.Size = new System.Drawing.Size(211, 20);
            this.tb_cijena.TabIndex = 4;
            // 
            // tb_oblik
            // 
            this.tb_oblik.Location = new System.Drawing.Point(109, 223);
            this.tb_oblik.Name = "tb_oblik";
            this.tb_oblik.Size = new System.Drawing.Size(211, 20);
            this.tb_oblik.TabIndex = 8;
            // 
            // tb_proizvodjac
            // 
            this.tb_proizvodjac.Location = new System.Drawing.Point(109, 92);
            this.tb_proizvodjac.Name = "tb_proizvodjac";
            this.tb_proizvodjac.Size = new System.Drawing.Size(211, 20);
            this.tb_proizvodjac.TabIndex = 3;
            // 
            // tb_lista
            // 
            this.tb_lista.Location = new System.Drawing.Point(109, 249);
            this.tb_lista.Name = "tb_lista";
            this.tb_lista.Size = new System.Drawing.Size(211, 20);
            this.tb_lista.TabIndex = 9;
            // 
            // tb_atcS
            // 
            this.tb_atcS.Location = new System.Drawing.Point(109, 197);
            this.tb_atcS.Name = "tb_atcS";
            this.tb_atcS.Size = new System.Drawing.Size(211, 20);
            this.tb_atcS.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 171);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // lb_message
            // 
            this.lb_message.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_message.AutoSize = true;
            this.lb_message.ForeColor = System.Drawing.Color.Red;
            this.lb_message.Location = new System.Drawing.Point(12, 278);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(147, 13);
            this.lb_message.TabIndex = 21;
            this.lb_message.Text = "Some informations  are invalid";
            this.lb_message.Visible = false;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 334);
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tb_atcS);
            this.Controls.Add(this.tb_lista);
            this.Controls.Add(this.tb_proizvodjac);
            this.Controls.Add(this.tb_oblik);
            this.Controls.Add(this.tb_cijena);
            this.Controls.Add(this.tb_kolicina);
            this.Controls.Add(this.tb_naziv);
            this.Controls.Add(this.tb_sifraP);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lb_lista);
            this.Controls.Add(this.lb_oblik);
            this.Controls.Add(this.lb_atcS);
            this.Controls.Add(this.lb_kolicina);
            this.Controls.Add(this.lb_rokU);
            this.Controls.Add(this.lb_cijena);
            this.Controls.Add(this.lb_proizvodjac);
            this.Controls.Add(this.lb_naziv);
            this.Controls.Add(this.lb_sifraPr);
            this.Controls.Add(this.lb_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Habitus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_sifraPr;
        private System.Windows.Forms.Label lb_naziv;
        private System.Windows.Forms.Label lb_proizvodjac;
        private System.Windows.Forms.Label lb_cijena;
        private System.Windows.Forms.Label lb_rokU;
        private System.Windows.Forms.Label lb_kolicina;
        private System.Windows.Forms.Label lb_atcS;
        private System.Windows.Forms.Label lb_oblik;
        private System.Windows.Forms.Label lb_lista;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox tb_sifraP;
        private System.Windows.Forms.TextBox tb_naziv;
        private System.Windows.Forms.TextBox tb_kolicina;
        private System.Windows.Forms.TextBox tb_cijena;
        private System.Windows.Forms.TextBox tb_oblik;
        private System.Windows.Forms.TextBox tb_proizvodjac;
        private System.Windows.Forms.TextBox tb_lista;
        private System.Windows.Forms.TextBox tb_atcS;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lb_message;
    }
}