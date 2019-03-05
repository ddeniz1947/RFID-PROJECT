namespace RFID
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.btn_oku = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_goster = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_dogrula = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dogrulama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Okul Numarası";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(82, 48);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_ad.TabIndex = 2;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(199, 48);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(100, 20);
            this.txt_soyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID";
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(137, 84);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(100, 20);
            this.txt_num.TabIndex = 5;
            // 
            // btn_kayit
            // 
            this.btn_kayit.Location = new System.Drawing.Point(26, 190);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(75, 23);
            this.btn_kayit.TabIndex = 6;
            this.btn_kayit.Text = "Kayıt";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // btn_oku
            // 
            this.btn_oku.Location = new System.Drawing.Point(137, 190);
            this.btn_oku.Name = "btn_oku";
            this.btn_oku.Size = new System.Drawing.Size(75, 23);
            this.btn_oku.TabIndex = 7;
            this.btn_oku.Text = "Oku";
            this.btn_oku.UseVisualStyleBackColor = true;
            this.btn_oku.Click += new System.EventHandler(this.btn_oku_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(415, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 184);
            this.dataGridView1.TabIndex = 8;
            // 
            // btn_goster
            // 
            this.btn_goster.Location = new System.Drawing.Point(26, 240);
            this.btn_goster.Name = "btn_goster";
            this.btn_goster.Size = new System.Drawing.Size(75, 23);
            this.btn_goster.TabIndex = 9;
            this.btn_goster.Text = "Göster";
            this.btn_goster.UseVisualStyleBackColor = true;
            this.btn_goster.Click += new System.EventHandler(this.btn_goster_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(137, 119);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 10;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            // 
            // btn_dogrula
            // 
            this.btn_dogrula.Location = new System.Drawing.Point(137, 240);
            this.btn_dogrula.Name = "btn_dogrula";
            this.btn_dogrula.Size = new System.Drawing.Size(75, 23);
            this.btn_dogrula.TabIndex = 11;
            this.btn_dogrula.Text = "Doğrula";
            this.btn_dogrula.UseVisualStyleBackColor = true;
            this.btn_dogrula.Click += new System.EventHandler(this.btn_dogrula_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Doğrulama Kodu";
            // 
            // txt_dogrulama
            // 
            this.txt_dogrulama.Location = new System.Drawing.Point(137, 146);
            this.txt_dogrulama.Name = "txt_dogrulama";
            this.txt_dogrulama.Size = new System.Drawing.Size(100, 20);
            this.txt_dogrulama.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 275);
            this.Controls.Add(this.txt_dogrulama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_dogrula);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_goster);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_oku);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.Button btn_oku;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_goster;
        private System.Windows.Forms.TextBox txt_id;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_dogrula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dogrulama;
    }
}

