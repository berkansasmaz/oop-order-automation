namespace SiparisOtomasyonu
{
    partial class Urunler
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
            this.listbox_giyim = new System.Windows.Forms.ListBox();
            this.btn_uSepeteEkle = new System.Windows.Forms.Button();
            this.combo_uAdet = new System.Windows.Forms.ComboBox();
            this.label_uKdv = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_uFiyat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listbox_giyim
            // 
            this.listbox_giyim.FormattingEnabled = true;
            this.listbox_giyim.ItemHeight = 16;
            this.listbox_giyim.Location = new System.Drawing.Point(26, 66);
            this.listbox_giyim.Name = "listbox_giyim";
            this.listbox_giyim.Size = new System.Drawing.Size(540, 340);
            this.listbox_giyim.TabIndex = 23;
            this.listbox_giyim.SelectedIndexChanged += new System.EventHandler(this.listbox_giyim_SelectedIndexChanged_1);
            // 
            // btn_uSepeteEkle
            // 
            this.btn_uSepeteEkle.Location = new System.Drawing.Point(581, 173);
            this.btn_uSepeteEkle.Name = "btn_uSepeteEkle";
            this.btn_uSepeteEkle.Size = new System.Drawing.Size(121, 47);
            this.btn_uSepeteEkle.TabIndex = 27;
            this.btn_uSepeteEkle.Text = "Sepete Ekle";
            this.btn_uSepeteEkle.UseVisualStyleBackColor = true;
            this.btn_uSepeteEkle.Click += new System.EventHandler(this.btn_uSepeteEkle_Click);
            // 
            // combo_uAdet
            // 
            this.combo_uAdet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_uAdet.FormattingEnabled = true;
            this.combo_uAdet.Location = new System.Drawing.Point(631, 63);
            this.combo_uAdet.Name = "combo_uAdet";
            this.combo_uAdet.Size = new System.Drawing.Size(121, 24);
            this.combo_uAdet.TabIndex = 24;
            this.combo_uAdet.SelectedIndexChanged += new System.EventHandler(this.combo_uAdet_SelectedIndexChanged);
            // 
            // label_uKdv
            // 
            this.label_uKdv.AutoSize = true;
            this.label_uKdv.Location = new System.Drawing.Point(622, 144);
            this.label_uKdv.Name = "label_uKdv";
            this.label_uKdv.Size = new System.Drawing.Size(32, 17);
            this.label_uKdv.TabIndex = 20;
            this.label_uKdv.Text = "___";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(578, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 17);
            this.label16.TabIndex = 21;
            this.label16.Text = "KDV";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(578, 107);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 17);
            this.label17.TabIndex = 22;
            this.label17.Text = "Fiyat";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(578, 66);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 17);
            this.label18.TabIndex = 23;
            this.label18.Text = "Adedi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "ÜRÜNLER";
            // 
            // lbl_uFiyat
            // 
            this.lbl_uFiyat.AutoSize = true;
            this.lbl_uFiyat.Location = new System.Drawing.Point(622, 107);
            this.lbl_uFiyat.Name = "lbl_uFiyat";
            this.lbl_uFiyat.Size = new System.Drawing.Size(32, 17);
            this.lbl_uFiyat.TabIndex = 20;
            this.lbl_uFiyat.Text = "___";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Ürün Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Stok Miktarı";
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 411);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listbox_giyim);
            this.Controls.Add(this.btn_uSepeteEkle);
            this.Controls.Add(this.combo_uAdet);
            this.Controls.Add(this.lbl_uFiyat);
            this.Controls.Add(this.label_uKdv);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Name = "Urunler";
            this.Text = "Urunler";
            this.Load += new System.EventHandler(this.Urunler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_uSepeteEkle;
        private System.Windows.Forms.Label label_uKdv;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox listbox_giyim;
        public System.Windows.Forms.ComboBox combo_uAdet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_uFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}