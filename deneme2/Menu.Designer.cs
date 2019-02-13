namespace SiparisOtomasyonu
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yetkiliFirmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünlerToolStripMenuItem,
            this.sepetToolStripMenuItem,
            this.ödemeToolStripMenuItem,
            this.yetkiliFirmaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(643, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
       
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.ürünlerToolStripMenuItem.Text = "Ürünler";
            this.ürünlerToolStripMenuItem.Click += new System.EventHandler(this.ürünlerToolStripMenuItem_Click_1);
            // 
            // sepetToolStripMenuItem
            // 
            this.sepetToolStripMenuItem.Name = "sepetToolStripMenuItem";
            this.sepetToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.sepetToolStripMenuItem.Text = "Sepet";
            this.sepetToolStripMenuItem.Click += new System.EventHandler(this.sepetToolStripMenuItem_Click);
            // 
            // ödemeToolStripMenuItem
            // 
            this.ödemeToolStripMenuItem.Name = "ödemeToolStripMenuItem";
            this.ödemeToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.ödemeToolStripMenuItem.Text = "Ödeme";
            this.ödemeToolStripMenuItem.Click += new System.EventHandler(this.ödemeToolStripMenuItem_Click);
            // 
            // yetkiliFirmaToolStripMenuItem
            // 
            this.yetkiliFirmaToolStripMenuItem.Name = "yetkiliFirmaToolStripMenuItem";
            this.yetkiliFirmaToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.yetkiliFirmaToolStripMenuItem.Text = "Yetkili Firma";
            this.yetkiliFirmaToolStripMenuItem.Click += new System.EventHandler(this.yetkiliFirmaToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 473);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yetkiliFirmaToolStripMenuItem;
    }
}

