namespace pharmacy
{
    partial class ZaposleniForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZaposleniForm));
            this.lbl_titile = new System.Windows.Forms.Label();
            this.lv_Main = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lbl_titile
            // 
            this.lbl_titile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_titile.AutoSize = true;
            this.lbl_titile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titile.Location = new System.Drawing.Point(237, 9);
            this.lbl_titile.Name = "lbl_titile";
            this.lbl_titile.Size = new System.Drawing.Size(91, 18);
            this.lbl_titile.TabIndex = 0;
            this.lbl_titile.Text = "Employees";
            // 
            // lv_Main
            // 
            this.lv_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_Main.FullRowSelect = true;
            this.lv_Main.GridLines = true;
            this.lv_Main.Location = new System.Drawing.Point(12, 52);
            this.lv_Main.Name = "lv_Main";
            this.lv_Main.Size = new System.Drawing.Size(561, 198);
            this.lv_Main.TabIndex = 6;
            this.lv_Main.UseCompatibleStateImageBehavior = false;
            this.lv_Main.View = System.Windows.Forms.View.Details;
            // 
            // ZaposleniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 262);
            this.Controls.Add(this.lv_Main);
            this.Controls.Add(this.lbl_titile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZaposleniForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Habitus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titile;
        private System.Windows.Forms.ListView lv_Main;
    }
}