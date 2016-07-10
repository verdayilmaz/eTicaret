namespace eTicaret
{
    partial class SiparisDetay
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
            this.listView1SiparisDetay = new System.Windows.Forms.ListView();
            this.UrunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrununFiyati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kategorisi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblToplamFiyatGoster = new System.Windows.Forms.Label();
            this.lblKargoDetay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1SiparisDetay
            // 
            this.listView1SiparisDetay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UrunAdi,
            this.UrununFiyati,
            this.Kategorisi});
            this.listView1SiparisDetay.Location = new System.Drawing.Point(12, 12);
            this.listView1SiparisDetay.Name = "listView1SiparisDetay";
            this.listView1SiparisDetay.Size = new System.Drawing.Size(446, 174);
            this.listView1SiparisDetay.TabIndex = 0;
            this.listView1SiparisDetay.UseCompatibleStateImageBehavior = false;
            this.listView1SiparisDetay.View = System.Windows.Forms.View.Details;
            // 
            // UrunAdi
            // 
            this.UrunAdi.Text = "Urun Adi";
            this.UrunAdi.Width = 123;
            // 
            // UrununFiyati
            // 
            this.UrununFiyati.Text = "Urunun Fiyati";
            this.UrununFiyati.Width = 192;
            // 
            // Kategorisi
            // 
            this.Kategorisi.Text = "Kategorisi";
            this.Kategorisi.Width = 205;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toplam Fiyat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kargo Bilgileri:";
            // 
            // lblToplamFiyatGoster
            // 
            this.lblToplamFiyatGoster.AutoSize = true;
            this.lblToplamFiyatGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamFiyatGoster.Location = new System.Drawing.Point(135, 205);
            this.lblToplamFiyatGoster.Name = "lblToplamFiyatGoster";
            this.lblToplamFiyatGoster.Size = new System.Drawing.Size(171, 20);
            this.lblToplamFiyatGoster.TabIndex = 3;
            this.lblToplamFiyatGoster.Text = "Toplam Fiyat Göster";
            // 
            // lblKargoDetay
            // 
            this.lblKargoDetay.AutoSize = true;
            this.lblKargoDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKargoDetay.Location = new System.Drawing.Point(135, 243);
            this.lblKargoDetay.Name = "lblKargoDetay";
            this.lblKargoDetay.Size = new System.Drawing.Size(108, 20);
            this.lblKargoDetay.TabIndex = 4;
            this.lblKargoDetay.Text = "Kargo Detay";
            // 
            // SiparisDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 404);
            this.Controls.Add(this.lblKargoDetay);
            this.Controls.Add(this.lblToplamFiyatGoster);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1SiparisDetay);
            this.Name = "SiparisDetay";
            this.Text = "SiparisDetay";
            this.Load += new System.EventHandler(this.SiparisDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1SiparisDetay;
        private System.Windows.Forms.ColumnHeader UrunAdi;
        private System.Windows.Forms.ColumnHeader UrununFiyati;
        private System.Windows.Forms.ColumnHeader Kategorisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToplamFiyatGoster;
        private System.Windows.Forms.Label lblKargoDetay;
    }
}