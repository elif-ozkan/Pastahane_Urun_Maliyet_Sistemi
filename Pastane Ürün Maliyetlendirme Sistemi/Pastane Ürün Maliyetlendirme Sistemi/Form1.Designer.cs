namespace Pastane_Ürün_Maliyetlendirme_Sistemi
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnMalzemeEkle = new System.Windows.Forms.Button();
            this.TxtNotlar = new System.Windows.Forms.TextBox();
            this.TxtFıyat = new System.Windows.Forms.TextBox();
            this.TxtStok = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.TxtUrunSatısFıyat = new System.Windows.Forms.TextBox();
            this.TxtUrunFıyat = new System.Windows.Forms.TextBox();
            this.TxtUrunStok = new System.Windows.Forms.TextBox();
            this.TxtUrunAd = new System.Windows.Forms.TextBox();
            this.TxtUrunId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnÇıkıs = new System.Windows.Forms.Button();
            this.BtnKasa = new System.Windows.Forms.Button();
            this.BtnUrun = new System.Windows.Forms.Button();
            this.BtnMalzeme = new System.Windows.Forms.Button();
            this.BtnGetir = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnGetir);
            this.groupBox1.Controls.Add(this.BtnMalzemeEkle);
            this.groupBox1.Controls.Add(this.TxtNotlar);
            this.groupBox1.Controls.Add(this.TxtFıyat);
            this.groupBox1.Controls.Add(this.TxtStok);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(370, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Malzeme Girişi";
            // 
            // BtnMalzemeEkle
            // 
            this.BtnMalzemeEkle.Location = new System.Drawing.Point(101, 279);
            this.BtnMalzemeEkle.Name = "BtnMalzemeEkle";
            this.BtnMalzemeEkle.Size = new System.Drawing.Size(170, 38);
            this.BtnMalzemeEkle.TabIndex = 2;
            this.BtnMalzemeEkle.Text = "Malzeme Ekle";
            this.BtnMalzemeEkle.UseVisualStyleBackColor = true;
            this.BtnMalzemeEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtNotlar
            // 
            this.TxtNotlar.Location = new System.Drawing.Point(126, 234);
            this.TxtNotlar.Name = "TxtNotlar";
            this.TxtNotlar.Size = new System.Drawing.Size(145, 30);
            this.TxtNotlar.TabIndex = 11;
            // 
            // TxtFıyat
            // 
            this.TxtFıyat.Location = new System.Drawing.Point(126, 183);
            this.TxtFıyat.Name = "TxtFıyat";
            this.TxtFıyat.Size = new System.Drawing.Size(145, 30);
            this.TxtFıyat.TabIndex = 10;
            // 
            // TxtStok
            // 
            this.TxtStok.Location = new System.Drawing.Point(126, 135);
            this.TxtStok.Name = "TxtStok";
            this.TxtStok.Size = new System.Drawing.Size(145, 30);
            this.TxtStok.TabIndex = 9;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(126, 82);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(145, 30);
            this.TxtAd.TabIndex = 8;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(126, 39);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(145, 30);
            this.TxtId.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "NOTLAR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "FİYAT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "STOK:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "AD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.TxtUrunSatısFıyat);
            this.groupBox2.Controls.Add(this.TxtUrunFıyat);
            this.groupBox2.Controls.Add(this.TxtUrunStok);
            this.groupBox2.Controls.Add(this.TxtUrunAd);
            this.groupBox2.Controls.Add(this.TxtUrunId);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(416, 19);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(367, 342);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Girişi";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(173, 288);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(133, 29);
            this.button7.TabIndex = 13;
            this.button7.Text = "Güncelle";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(34, 284);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 30);
            this.button6.TabIndex = 12;
            this.button6.Text = "Ürün Ekle";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // TxtUrunSatısFıyat
            // 
            this.TxtUrunSatısFıyat.Location = new System.Drawing.Point(117, 248);
            this.TxtUrunSatısFıyat.Name = "TxtUrunSatısFıyat";
            this.TxtUrunSatısFıyat.Size = new System.Drawing.Size(131, 30);
            this.TxtUrunSatısFıyat.TabIndex = 11;
            // 
            // TxtUrunFıyat
            // 
            this.TxtUrunFıyat.Location = new System.Drawing.Point(117, 197);
            this.TxtUrunFıyat.Name = "TxtUrunFıyat";
            this.TxtUrunFıyat.Size = new System.Drawing.Size(131, 30);
            this.TxtUrunFıyat.TabIndex = 10;
            // 
            // TxtUrunStok
            // 
            this.TxtUrunStok.Location = new System.Drawing.Point(110, 149);
            this.TxtUrunStok.Name = "TxtUrunStok";
            this.TxtUrunStok.Size = new System.Drawing.Size(129, 30);
            this.TxtUrunStok.TabIndex = 9;
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.Location = new System.Drawing.Point(92, 97);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Size = new System.Drawing.Size(147, 30);
            this.TxtUrunAd.TabIndex = 8;
            // 
            // TxtUrunId
            // 
            this.TxtUrunId.Location = new System.Drawing.Point(92, 50);
            this.TxtUrunId.Name = "TxtUrunId";
            this.TxtUrunId.Size = new System.Drawing.Size(147, 30);
            this.TxtUrunId.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "S.FİYAT:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "M.Fiyat:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "STOK:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "AD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(18, 383);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(1044, 336);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Malzemeler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1036, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.textBox14);
            this.groupBox4.Controls.Add(this.textBox13);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(826, 19);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(375, 342);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ürün Oluştur";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(123, 217);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(121, 30);
            this.textBox14.TabIndex = 10;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(123, 165);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(121, 30);
            this.textBox13.TabIndex = 9;
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(82, 263);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(124, 29);
            this.button8.TabIndex = 6;
            this.button8.Text = "Ekle";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 25);
            this.label14.TabIndex = 5;
            this.label14.Text = "Maliyet:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 25);
            this.label13.TabIndex = 4;
            this.label13.Text = "Miktar:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "Malzeme:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Ürün:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBox1);
            this.groupBox5.Location = new System.Drawing.Point(1232, 19);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(392, 326);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ürün Oluştur";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(4, 28);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(384, 293);
            this.listBox1.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BtnÇıkıs);
            this.groupBox6.Controls.Add(this.BtnKasa);
            this.groupBox6.Controls.Add(this.BtnMalzeme);
            this.groupBox6.Controls.Add(this.BtnUrun);
            this.groupBox6.Location = new System.Drawing.Point(1083, 383);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Size = new System.Drawing.Size(455, 323);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "İşlemler";
            // 
            // BtnÇıkıs
            // 
            this.BtnÇıkıs.Location = new System.Drawing.Point(24, 191);
            this.BtnÇıkıs.Name = "BtnÇıkıs";
            this.BtnÇıkıs.Size = new System.Drawing.Size(149, 36);
            this.BtnÇıkıs.TabIndex = 5;
            this.BtnÇıkıs.Text = "Çıkış";
            this.BtnÇıkıs.UseVisualStyleBackColor = true;
            this.BtnÇıkıs.Click += new System.EventHandler(this.BtnÇıkıs_Click);
            // 
            // BtnKasa
            // 
            this.BtnKasa.Location = new System.Drawing.Point(24, 140);
            this.BtnKasa.Name = "BtnKasa";
            this.BtnKasa.Size = new System.Drawing.Size(149, 30);
            this.BtnKasa.TabIndex = 4;
            this.BtnKasa.Text = "Kasa";
            this.BtnKasa.UseVisualStyleBackColor = true;
            this.BtnKasa.Click += new System.EventHandler(this.BtnKasa_Click);
            // 
            // BtnUrun
            // 
            this.BtnUrun.Location = new System.Drawing.Point(24, 41);
            this.BtnUrun.Name = "BtnUrun";
            this.BtnUrun.Size = new System.Drawing.Size(160, 31);
            this.BtnUrun.TabIndex = 2;
            this.BtnUrun.Text = "Ürün Listesi";
            this.BtnUrun.UseVisualStyleBackColor = true;
            this.BtnUrun.Click += new System.EventHandler(this.BtnUrun_Click);
            // 
            // BtnMalzeme
            // 
            this.BtnMalzeme.Location = new System.Drawing.Point(24, 95);
            this.BtnMalzeme.Name = "BtnMalzeme";
            this.BtnMalzeme.Size = new System.Drawing.Size(160, 29);
            this.BtnMalzeme.TabIndex = 3;
            this.BtnMalzeme.Text = "Malzeme Listesi";
            this.BtnMalzeme.UseVisualStyleBackColor = true;
            this.BtnMalzeme.Click += new System.EventHandler(this.BtnMalzeme_Click);
            // 
            // BtnGetir
            // 
            this.BtnGetir.Location = new System.Drawing.Point(277, 79);
            this.BtnGetir.Name = "BtnGetir";
            this.BtnGetir.Size = new System.Drawing.Size(75, 36);
            this.BtnGetir.TabIndex = 6;
            this.BtnGetir.Text = "Getir";
            this.BtnGetir.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(123, 113);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 33);
            this.comboBox2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1358, 733);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnMalzemeEkle;
        private System.Windows.Forms.TextBox TxtNotlar;
        private System.Windows.Forms.TextBox TxtFıyat;
        private System.Windows.Forms.TextBox TxtStok;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox TxtUrunSatısFıyat;
        private System.Windows.Forms.TextBox TxtUrunFıyat;
        private System.Windows.Forms.TextBox TxtUrunStok;
        private System.Windows.Forms.TextBox TxtUrunAd;
        private System.Windows.Forms.TextBox TxtUrunId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnÇıkıs;
        private System.Windows.Forms.Button BtnKasa;
        private System.Windows.Forms.Button BtnUrun;
        private System.Windows.Forms.Button BtnMalzeme;
        private System.Windows.Forms.Button BtnGetir;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

