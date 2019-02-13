namespace SiparisOtomasyonu
{
    partial class Payment
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
            this.label1 = new System.Windows.Forms.Label();
            this.combo_Odeme = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_oToplam = new System.Windows.Forms.Label();
            this.panel_Kredi = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_kTip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_krediKno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_check = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cNo = new System.Windows.Forms.TextBox();
            this.txt_cİsim = new System.Windows.Forms.TextBox();
            this.panel_nakit = new System.Windows.Forms.Panel();
            this.label_nakit = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Ode = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.datetimepicker_Tarih = new System.Windows.Forms.DateTimePicker();
            this.panel_Kredi.SuspendLayout();
            this.panel_check.SuspendLayout();
            this.panel_nakit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bir ödeme yöntemi seçiniz\r\n\r\n";
            // 
            // combo_Odeme
            // 
            this.combo_Odeme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Odeme.FormattingEnabled = true;
            this.combo_Odeme.Items.AddRange(new object[] {
            "Kredi Kartı",
            "Nakit",
            "Çek"});
            this.combo_Odeme.Location = new System.Drawing.Point(246, 73);
            this.combo_Odeme.Name = "combo_Odeme";
            this.combo_Odeme.Size = new System.Drawing.Size(121, 24);
            this.combo_Odeme.TabIndex = 4;
            this.combo_Odeme.SelectedIndexChanged += new System.EventHandler(this.combo_Odeme_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "KDV ve Kargo Ücreti Dahil Toplam Tutar";
            // 
            // label_oToplam
            // 
            this.label_oToplam.AutoSize = true;
            this.label_oToplam.Location = new System.Drawing.Point(158, 29);
            this.label_oToplam.Name = "label_oToplam";
            this.label_oToplam.Size = new System.Drawing.Size(40, 17);
            this.label_oToplam.TabIndex = 0;
            this.label_oToplam.Text = "____";
            // 
            // panel_Kredi
            // 
            this.panel_Kredi.Controls.Add(this.datetimepicker_Tarih);
            this.panel_Kredi.Controls.Add(this.label5);
            this.panel_Kredi.Controls.Add(this.txt_kTip);
            this.panel_Kredi.Controls.Add(this.label4);
            this.panel_Kredi.Controls.Add(this.txt_krediKno);
            this.panel_Kredi.Controls.Add(this.label3);
            this.panel_Kredi.Location = new System.Drawing.Point(43, 110);
            this.panel_Kredi.Name = "panel_Kredi";
            this.panel_Kredi.Size = new System.Drawing.Size(355, 119);
            this.panel_Kredi.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Son Kullanma Tarihi";
            // 
            // txt_kTip
            // 
            this.txt_kTip.Location = new System.Drawing.Point(161, 45);
            this.txt_kTip.Name = "txt_kTip";
            this.txt_kTip.Size = new System.Drawing.Size(191, 22);
            this.txt_kTip.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tip";
            // 
            // txt_krediKno
            // 
            this.txt_krediKno.Location = new System.Drawing.Point(161, 17);
            this.txt_krediKno.MaxLength = 11;
            this.txt_krediKno.Name = "txt_krediKno";
            this.txt_krediKno.Size = new System.Drawing.Size(191, 22);
            this.txt_krediKno.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kart Numarası";
            // 
            // panel_check
            // 
            this.panel_check.Controls.Add(this.label9);
            this.panel_check.Controls.Add(this.label8);
            this.panel_check.Controls.Add(this.txt_cNo);
            this.panel_check.Controls.Add(this.txt_cİsim);
            this.panel_check.Location = new System.Drawing.Point(43, 322);
            this.panel_check.Name = "panel_check";
            this.panel_check.Size = new System.Drawing.Size(355, 102);
            this.panel_check.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Kart Numarası";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "İsim";
            // 
            // txt_cNo
            // 
            this.txt_cNo.Location = new System.Drawing.Point(161, 57);
            this.txt_cNo.Name = "txt_cNo";
            this.txt_cNo.Size = new System.Drawing.Size(191, 22);
            this.txt_cNo.TabIndex = 1;
            // 
            // txt_cİsim
            // 
            this.txt_cİsim.Location = new System.Drawing.Point(161, 19);
            this.txt_cİsim.Name = "txt_cİsim";
            this.txt_cİsim.Size = new System.Drawing.Size(191, 22);
            this.txt_cİsim.TabIndex = 1;
            // 
            // panel_nakit
            // 
            this.panel_nakit.Controls.Add(this.label_nakit);
            this.panel_nakit.Controls.Add(this.label7);
            this.panel_nakit.Controls.Add(this.label6);
            this.panel_nakit.Location = new System.Drawing.Point(43, 248);
            this.panel_nakit.Name = "panel_nakit";
            this.panel_nakit.Size = new System.Drawing.Size(355, 58);
            this.panel_nakit.TabIndex = 5;
            // 
            // label_nakit
            // 
            this.label_nakit.AutoSize = true;
            this.label_nakit.Location = new System.Drawing.Point(158, 23);
            this.label_nakit.Name = "label_nakit";
            this.label_nakit.Size = new System.Drawing.Size(40, 17);
            this.label_nakit.TabIndex = 7;
            this.label_nakit.Text = "____";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nakit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 0;
            // 
            // btn_Ode
            // 
            this.btn_Ode.Location = new System.Drawing.Point(43, 430);
            this.btn_Ode.Name = "btn_Ode";
            this.btn_Ode.Size = new System.Drawing.Size(355, 48);
            this.btn_Ode.TabIndex = 7;
            this.btn_Ode.Text = "Öde";
            this.btn_Ode.UseVisualStyleBackColor = true;
            this.btn_Ode.Click += new System.EventHandler(this.btn_Ode_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(43, 484);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(295, 48);
            this.btn_cikis.TabIndex = 8;
            this.btn_cikis.Text = "Sipariş İptal";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // datetimepicker_Tarih
            // 
            this.datetimepicker_Tarih.Location = new System.Drawing.Point(161, 73);
            this.datetimepicker_Tarih.Name = "datetimepicker_Tarih";
            this.datetimepicker_Tarih.Size = new System.Drawing.Size(191, 22);
            this.datetimepicker_Tarih.TabIndex = 9;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 571);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_Ode);
            this.Controls.Add(this.panel_nakit);
            this.Controls.Add(this.panel_check);
            this.Controls.Add(this.panel_Kredi);
            this.Controls.Add(this.combo_Odeme);
            this.Controls.Add(this.label_oToplam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Payment";
            this.Text = "Odeme";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.panel_Kredi.ResumeLayout(false);
            this.panel_Kredi.PerformLayout();
            this.panel_check.ResumeLayout(false);
            this.panel_check.PerformLayout();
            this.panel_nakit.ResumeLayout(false);
            this.panel_nakit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_Odeme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_oToplam;
        private System.Windows.Forms.Panel panel_Kredi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_kTip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_krediKno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_check;
        private System.Windows.Forms.Panel panel_nakit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_cNo;
        private System.Windows.Forms.TextBox txt_cİsim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Ode;
        private System.Windows.Forms.Label label_nakit;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.DateTimePicker datetimepicker_Tarih;
    }
}