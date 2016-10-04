namespace pharmacy
{
    partial class ProdajaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdajaForm));
            this.cb_lijek = new System.Windows.Forms.ComboBox();
            this.nup_kolicna = new System.Windows.Forms.NumericUpDown();
            this.lb_title = new System.Windows.Forms.Label();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_stampaj = new System.Windows.Forms.Button();
            this.lb_racun = new System.Windows.Forms.ListBox();
            this.lb_ukupan_racun = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nup_kolicna)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_lijek
            // 
            this.cb_lijek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_lijek.FormattingEnabled = true;
            this.cb_lijek.Location = new System.Drawing.Point(12, 38);
            this.cb_lijek.Name = "cb_lijek";
            this.cb_lijek.Size = new System.Drawing.Size(191, 21);
            this.cb_lijek.TabIndex = 0;
            this.cb_lijek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_keyPressed);
            // 
            // nup_kolicna
            // 
            this.nup_kolicna.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nup_kolicna.Location = new System.Drawing.Point(209, 39);
            this.nup_kolicna.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nup_kolicna.Name = "nup_kolicna";
            this.nup_kolicna.Size = new System.Drawing.Size(63, 20);
            this.nup_kolicna.TabIndex = 1;
            this.nup_kolicna.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(229, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(63, 16);
            this.lb_title.TabIndex = 2;
            this.lb_title.Text = "Prodaja";
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_dodaj.Location = new System.Drawing.Point(12, 227);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(75, 23);
            this.btn_dodaj.TabIndex = 4;
            this.btn_dodaj.Text = "Dodaj";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(140, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Izbrisi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_stampaj
            // 
            this.btn_stampaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_stampaj.Location = new System.Drawing.Point(440, 227);
            this.btn_stampaj.Name = "btn_stampaj";
            this.btn_stampaj.Size = new System.Drawing.Size(75, 23);
            this.btn_stampaj.TabIndex = 6;
            this.btn_stampaj.Text = "Stampaj";
            this.btn_stampaj.UseVisualStyleBackColor = true;
            this.btn_stampaj.Click += new System.EventHandler(this.btn_stampaj_Click);
            // 
            // lb_racun
            // 
            this.lb_racun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_racun.FormattingEnabled = true;
            this.lb_racun.Location = new System.Drawing.Point(278, 39);
            this.lb_racun.Name = "lb_racun";
            this.lb_racun.Size = new System.Drawing.Size(236, 173);
            this.lb_racun.TabIndex = 8;
            // 
            // lb_ukupan_racun
            // 
            this.lb_ukupan_racun.AutoSize = true;
            this.lb_ukupan_racun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ukupan_racun.Location = new System.Drawing.Point(275, 230);
            this.lb_ukupan_racun.Name = "lb_ukupan_racun";
            this.lb_ukupan_racun.Size = new System.Drawing.Size(0, 15);
            this.lb_ukupan_racun.TabIndex = 9;
            // 
            // ProdajaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 262);
            this.Controls.Add(this.lb_ukupan_racun);
            this.Controls.Add(this.lb_racun);
            this.Controls.Add(this.btn_stampaj);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.nup_kolicna);
            this.Controls.Add(this.cb_lijek);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProdajaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProdajaForm";
            ((System.ComponentModel.ISupportInitialize)(this.nup_kolicna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_lijek;
        private System.Windows.Forms.NumericUpDown nup_kolicna;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_stampaj;
        private System.Windows.Forms.ListBox lb_racun;
        private System.Windows.Forms.Label lb_ukupan_racun;
    }
}