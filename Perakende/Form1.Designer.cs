
namespace Perakende
{
    partial class Form1
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
            this.txt_alis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_yuzde = new System.Windows.Forms.TextBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.btn_web = new System.Windows.Forms.Button();
            this.btn_iletisim = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alış Fiyatı :";
            // 
            // txt_alis
            // 
            this.txt_alis.Location = new System.Drawing.Point(141, 13);
            this.txt_alis.Name = "txt_alis";
            this.txt_alis.Size = new System.Drawing.Size(188, 20);
            this.txt_alis.TabIndex = 1;
            this.txt_alis.TextChanged += new System.EventHandler(this.txt_alis_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yüzde :";
            // 
            // txt_yuzde
            // 
            this.txt_yuzde.Location = new System.Drawing.Point(141, 57);
            this.txt_yuzde.Name = "txt_yuzde";
            this.txt_yuzde.Size = new System.Drawing.Size(188, 20);
            this.txt_yuzde.TabIndex = 1;
            this.txt_yuzde.TextChanged += new System.EventHandler(this.txt_yuzde_TextChanged);
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_hesapla.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hesapla.Location = new System.Drawing.Point(55, 94);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(237, 43);
            this.btn_hesapla.TabIndex = 2;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = false;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // btn_web
            // 
            this.btn_web.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_web.ForeColor = System.Drawing.Color.Red;
            this.btn_web.Location = new System.Drawing.Point(26, 189);
            this.btn_web.Name = "btn_web";
            this.btn_web.Size = new System.Drawing.Size(97, 44);
            this.btn_web.TabIndex = 3;
            this.btn_web.Text = "Web Sitemiz";
            this.btn_web.UseVisualStyleBackColor = true;
            this.btn_web.Click += new System.EventHandler(this.btn_web_Click);
            // 
            // btn_iletisim
            // 
            this.btn_iletisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iletisim.ForeColor = System.Drawing.Color.Red;
            this.btn_iletisim.Location = new System.Drawing.Point(204, 189);
            this.btn_iletisim.Name = "btn_iletisim";
            this.btn_iletisim.Size = new System.Drawing.Size(97, 44);
            this.btn_iletisim.TabIndex = 4;
            this.btn_iletisim.Text = "İletişim";
            this.btn_iletisim.UseVisualStyleBackColor = true;
            this.btn_iletisim.Click += new System.EventHandler(this.btn_iletisim_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(55, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Satış Fiyatı :";
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sonuc.Location = new System.Drawing.Point(169, 153);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(21, 24);
            this.lbl_sonuc.TabIndex = 5;
            this.lbl_sonuc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 255);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_iletisim);
            this.Controls.Add(this.btn_web);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.txt_yuzde);
            this.Controls.Add(this.txt_alis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_alis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_yuzde;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Button btn_web;
        private System.Windows.Forms.Button btn_iletisim;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_sonuc;
    }
}

