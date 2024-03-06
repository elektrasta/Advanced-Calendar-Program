namespace ajandaProjesi
{
    partial class yoneticiPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yoneticiPaneli));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnArastirmaci = new System.Windows.Forms.Button();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(558, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 34);
            this.label3.TabIndex = 11;
            this.label3.Text = "ARAŞTIRMACI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(324, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "PERSONEL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(69, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "ÖĞRENCİ";
            // 
            // btnArastirmaci
            // 
            this.btnArastirmaci.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArastirmaci.BackgroundImage")));
            this.btnArastirmaci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArastirmaci.Location = new System.Drawing.Point(546, 99);
            this.btnArastirmaci.Name = "btnArastirmaci";
            this.btnArastirmaci.Size = new System.Drawing.Size(221, 161);
            this.btnArastirmaci.TabIndex = 8;
            this.btnArastirmaci.UseVisualStyleBackColor = true;
            this.btnArastirmaci.Click += new System.EventHandler(this.btnArastirmaci_Click);
            // 
            // btnPersonel
            // 
            this.btnPersonel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersonel.BackgroundImage")));
            this.btnPersonel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPersonel.Location = new System.Drawing.Point(290, 99);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(221, 161);
            this.btnPersonel.TabIndex = 7;
            this.btnPersonel.UseVisualStyleBackColor = true;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOgrenci.BackgroundImage")));
            this.btnOgrenci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOgrenci.Location = new System.Drawing.Point(34, 99);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(221, 161);
            this.btnOgrenci.TabIndex = 6;
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.Location = new System.Drawing.Point(34, 373);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 65);
            this.btnGeri.TabIndex = 12;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // yoneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnArastirmaci);
            this.Controls.Add(this.btnPersonel);
            this.Controls.Add(this.btnOgrenci);
            this.Name = "yoneticiPaneli";
            this.Text = "Yönetici Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnArastirmaci;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnGeri;
    }
}