namespace SiparisOtomasyonu
{
    partial class Sepet
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
            this.text_sToplam = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_sAlısveris = new System.Windows.Forms.Button();
            this.btn_sTemizle = new System.Windows.Forms.Button();
            this.btn_sOnayOde = new System.Windows.Forms.Button();
            this.btn_sCikis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // text_sToplam
            // 
            this.text_sToplam.Location = new System.Drawing.Point(178, 358);
            this.text_sToplam.Margin = new System.Windows.Forms.Padding(4);
            this.text_sToplam.Name = "text_sToplam";
            this.text_sToplam.Size = new System.Drawing.Size(185, 22);
            this.text_sToplam.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 361);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 17);
            this.label14.TabIndex = 23;
            this.label14.Text = "KDV siz Toplam Fiyat";
            // 
            // btn_sAlısveris
            // 
            this.btn_sAlısveris.Location = new System.Drawing.Point(404, 394);
            this.btn_sAlısveris.Name = "btn_sAlısveris";
            this.btn_sAlısveris.Size = new System.Drawing.Size(209, 25);
            this.btn_sAlısveris.TabIndex = 25;
            this.btn_sAlısveris.Text = "Alışverişe devam et";
            this.btn_sAlısveris.UseVisualStyleBackColor = true;
            this.btn_sAlısveris.Click += new System.EventHandler(this.btn_sAlısveris_Click);
            // 
            // btn_sTemizle
            // 
            this.btn_sTemizle.Location = new System.Drawing.Point(404, 437);
            this.btn_sTemizle.Name = "btn_sTemizle";
            this.btn_sTemizle.Size = new System.Drawing.Size(209, 28);
            this.btn_sTemizle.TabIndex = 25;
            this.btn_sTemizle.Text = "Sepeti Temizle";
            this.btn_sTemizle.UseVisualStyleBackColor = true;
            this.btn_sTemizle.Click += new System.EventHandler(this.btn_sTemizle_Click);
            // 
            // btn_sOnayOde
            // 
            this.btn_sOnayOde.Location = new System.Drawing.Point(404, 350);
            this.btn_sOnayOde.Name = "btn_sOnayOde";
            this.btn_sOnayOde.Size = new System.Drawing.Size(209, 30);
            this.btn_sOnayOde.TabIndex = 25;
            this.btn_sOnayOde.Text = "Sepeti onayla - ödeme yap";
            this.btn_sOnayOde.UseVisualStyleBackColor = true;
            this.btn_sOnayOde.Click += new System.EventHandler(this.btn_sOnayOde_Click);
            // 
            // btn_sCikis
            // 
            this.btn_sCikis.Location = new System.Drawing.Point(473, 490);
            this.btn_sCikis.Name = "btn_sCikis";
            this.btn_sCikis.Size = new System.Drawing.Size(79, 33);
            this.btn_sCikis.TabIndex = 25;
            this.btn_sCikis.Text = "Çıkış yap";
            this.btn_sCikis.UseVisualStyleBackColor = true;
            this.btn_sCikis.Click += new System.EventHandler(this.btn_sCikis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ürün Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Seçilen Miktar";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(601, 292);
            this.listBox1.TabIndex = 0;
       
            // 
            // Sepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 534);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_sCikis);
            this.Controls.Add(this.btn_sOnayOde);
            this.Controls.Add(this.btn_sTemizle);
            this.Controls.Add(this.btn_sAlısveris);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.text_sToplam);
            this.Controls.Add(this.listBox1);
            this.Name = "Sepet";
            this.Text = "Sepet";
            this.Load += new System.EventHandler(this.Sepet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox text_sToplam;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_sAlısveris;
        private System.Windows.Forms.Button btn_sTemizle;
        private System.Windows.Forms.Button btn_sOnayOde;
        private System.Windows.Forms.Button btn_sCikis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
    }
}