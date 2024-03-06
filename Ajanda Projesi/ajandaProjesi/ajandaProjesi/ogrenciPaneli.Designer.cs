namespace ajandaProjesi
{
    partial class ogrenciPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrenciPaneli));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAktivite = new System.Windows.Forms.ComboBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstwListe = new System.Windows.Forms.ListView();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnKitapOku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aktivite:";
            // 
            // cmbAktivite
            // 
            this.cmbAktivite.FormattingEnabled = true;
            this.cmbAktivite.Location = new System.Drawing.Point(177, 69);
            this.cmbAktivite.Name = "cmbAktivite";
            this.cmbAktivite.Size = new System.Drawing.Size(161, 24);
            this.cmbAktivite.TabIndex = 1;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Location = new System.Drawing.Point(12, 12);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(378, 30);
            this.dtpTarih.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(164, 109);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(104, 45);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstwListe
            // 
            this.lstwListe.HideSelection = false;
            this.lstwListe.Location = new System.Drawing.Point(12, 160);
            this.lstwListe.Name = "lstwListe";
            this.lstwListe.Size = new System.Drawing.Size(378, 227);
            this.lstwListe.TabIndex = 5;
            this.lstwListe.UseCompatibleStateImageBehavior = false;
            this.lstwListe.View = System.Windows.Forms.View.List;
            // 
            // btnGeri
            // 
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.Location = new System.Drawing.Point(12, 403);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(46, 35);
            this.btnGeri.TabIndex = 27;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnKitapOku
            // 
            this.btnKitapOku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapOku.Location = new System.Drawing.Point(202, 401);
            this.btnKitapOku.Name = "btnKitapOku";
            this.btnKitapOku.Size = new System.Drawing.Size(126, 33);
            this.btnKitapOku.TabIndex = 29;
            this.btnKitapOku.Text = "Kitap Oku";
            this.btnKitapOku.UseVisualStyleBackColor = true;
            this.btnKitapOku.Click += new System.EventHandler(this.btnKitapOku_Click);
            // 
            // ogrenciPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.btnKitapOku);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lstwListe);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.cmbAktivite);
            this.Controls.Add(this.label1);
            this.Name = "ogrenciPaneli";
            this.Text = "Öğrenci Paneli";
            this.Load += new System.EventHandler(this.ogrenciPaneli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAktivite;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.BindingSource ajandaDBDataSetBindingSource;
        private ajandaDBDataSet ajandaDBDataSet;
        private System.Windows.Forms.ListView lstwListe;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnKitapOku;
    }
}