
namespace VeriTabaniOdev
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
            this.KbtnEkle = new System.Windows.Forms.Button();
            this.KbtnSil = new System.Windows.Forms.Button();
            this.KbtnGuncelle = new System.Windows.Forms.Button();
            this.KbtnArama = new System.Windows.Forms.Button();
            this.KbtnListele = new System.Windows.Forms.Button();
            this.YbtnEkle = new System.Windows.Forms.Button();
            this.YbtnSil = new System.Windows.Forms.Button();
            this.YbtnGuncelle = new System.Windows.Forms.Button();
            this.YbtnArama = new System.Windows.Forms.Button();
            this.YbtnListele = new System.Windows.Forms.Button();
            this.TxtYazarAdi = new System.Windows.Forms.TextBox();
            this.TxtYazarSoyadi = new System.Windows.Forms.TextBox();
            this.TxtYazarTur = new System.Windows.Forms.TextBox();
            this.TxtDogumYili = new System.Windows.Forms.TextBox();
            this.TxtAraYazar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtYazarNo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtKitapAdi = new System.Windows.Forms.TextBox();
            this.TxtTur = new System.Windows.Forms.TextBox();
            this.TxtSayfa = new System.Windows.Forms.TextBox();
            this.TxtYazar = new System.Windows.Forms.TextBox();
            this.TxtAraKitap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtKitapNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AbtnEkle = new System.Windows.Forms.Button();
            this.AbtnSil = new System.Windows.Forms.Button();
            this.AbtnGuncelle = new System.Windows.Forms.Button();
            this.AbtnArama = new System.Windows.Forms.Button();
            this.TxtAliciAdi = new System.Windows.Forms.TextBox();
            this.TxtAliciSoyadi = new System.Windows.Forms.TextBox();
            this.TxtAdresil = new System.Windows.Forms.TextBox();
            this.TxtKartNo = new System.Windows.Forms.TextBox();
            this.TxtArama = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.AbtnListele = new System.Windows.Forms.Button();
            this.TxtAliciNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // KbtnEkle
            // 
            this.KbtnEkle.Location = new System.Drawing.Point(528, 336);
            this.KbtnEkle.Name = "KbtnEkle";
            this.KbtnEkle.Size = new System.Drawing.Size(75, 23);
            this.KbtnEkle.TabIndex = 138;
            this.KbtnEkle.Text = "Ekle";
            this.KbtnEkle.UseVisualStyleBackColor = true;
            this.KbtnEkle.Click += new System.EventHandler(this.KbtnEkle_Click);
            // 
            // KbtnSil
            // 
            this.KbtnSil.Location = new System.Drawing.Point(528, 370);
            this.KbtnSil.Name = "KbtnSil";
            this.KbtnSil.Size = new System.Drawing.Size(75, 23);
            this.KbtnSil.TabIndex = 137;
            this.KbtnSil.Text = "Sil";
            this.KbtnSil.UseVisualStyleBackColor = true;
            this.KbtnSil.Click += new System.EventHandler(this.KbtnSil_Click);
            // 
            // KbtnGuncelle
            // 
            this.KbtnGuncelle.Location = new System.Drawing.Point(528, 396);
            this.KbtnGuncelle.Name = "KbtnGuncelle";
            this.KbtnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.KbtnGuncelle.TabIndex = 136;
            this.KbtnGuncelle.Text = "Güncelle";
            this.KbtnGuncelle.UseVisualStyleBackColor = true;
            this.KbtnGuncelle.Click += new System.EventHandler(this.KbtnGuncelle_Click);
            // 
            // KbtnArama
            // 
            this.KbtnArama.Location = new System.Drawing.Point(528, 425);
            this.KbtnArama.Name = "KbtnArama";
            this.KbtnArama.Size = new System.Drawing.Size(75, 23);
            this.KbtnArama.TabIndex = 135;
            this.KbtnArama.Text = "Arama";
            this.KbtnArama.UseVisualStyleBackColor = true;
            this.KbtnArama.Click += new System.EventHandler(this.KbtnArama_Click);
            // 
            // KbtnListele
            // 
            this.KbtnListele.Location = new System.Drawing.Point(528, 307);
            this.KbtnListele.Name = "KbtnListele";
            this.KbtnListele.Size = new System.Drawing.Size(75, 23);
            this.KbtnListele.TabIndex = 134;
            this.KbtnListele.Text = "Listele";
            this.KbtnListele.UseVisualStyleBackColor = true;
            this.KbtnListele.Click += new System.EventHandler(this.KbtnListele_Click);
            // 
            // YbtnEkle
            // 
            this.YbtnEkle.Location = new System.Drawing.Point(834, 343);
            this.YbtnEkle.Name = "YbtnEkle";
            this.YbtnEkle.Size = new System.Drawing.Size(75, 23);
            this.YbtnEkle.TabIndex = 133;
            this.YbtnEkle.Text = "Ekle";
            this.YbtnEkle.UseVisualStyleBackColor = true;
            this.YbtnEkle.Click += new System.EventHandler(this.YbtnEkle_Click);
            // 
            // YbtnSil
            // 
            this.YbtnSil.Location = new System.Drawing.Point(834, 372);
            this.YbtnSil.Name = "YbtnSil";
            this.YbtnSil.Size = new System.Drawing.Size(75, 23);
            this.YbtnSil.TabIndex = 132;
            this.YbtnSil.Text = "Sil";
            this.YbtnSil.UseVisualStyleBackColor = true;
            this.YbtnSil.Click += new System.EventHandler(this.YbtnSil_Click);
            // 
            // YbtnGuncelle
            // 
            this.YbtnGuncelle.Location = new System.Drawing.Point(833, 401);
            this.YbtnGuncelle.Name = "YbtnGuncelle";
            this.YbtnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.YbtnGuncelle.TabIndex = 131;
            this.YbtnGuncelle.Text = "Güncelle";
            this.YbtnGuncelle.UseVisualStyleBackColor = true;
            this.YbtnGuncelle.Click += new System.EventHandler(this.YbtnGuncelle_Click);
            // 
            // YbtnArama
            // 
            this.YbtnArama.Location = new System.Drawing.Point(833, 430);
            this.YbtnArama.Name = "YbtnArama";
            this.YbtnArama.Size = new System.Drawing.Size(75, 23);
            this.YbtnArama.TabIndex = 130;
            this.YbtnArama.Text = "Arama";
            this.YbtnArama.UseVisualStyleBackColor = true;
            this.YbtnArama.Click += new System.EventHandler(this.YbtnArama_Click);
            // 
            // YbtnListele
            // 
            this.YbtnListele.Location = new System.Drawing.Point(833, 314);
            this.YbtnListele.Name = "YbtnListele";
            this.YbtnListele.Size = new System.Drawing.Size(75, 23);
            this.YbtnListele.TabIndex = 129;
            this.YbtnListele.Text = "Listele";
            this.YbtnListele.UseVisualStyleBackColor = true;
            this.YbtnListele.Click += new System.EventHandler(this.YbtnListele_Click);
            // 
            // TxtYazarAdi
            // 
            this.TxtYazarAdi.Location = new System.Drawing.Point(728, 342);
            this.TxtYazarAdi.Name = "TxtYazarAdi";
            this.TxtYazarAdi.Size = new System.Drawing.Size(100, 22);
            this.TxtYazarAdi.TabIndex = 128;
            // 
            // TxtYazarSoyadi
            // 
            this.TxtYazarSoyadi.Location = new System.Drawing.Point(728, 370);
            this.TxtYazarSoyadi.Name = "TxtYazarSoyadi";
            this.TxtYazarSoyadi.Size = new System.Drawing.Size(100, 22);
            this.TxtYazarSoyadi.TabIndex = 127;
            // 
            // TxtYazarTur
            // 
            this.TxtYazarTur.Location = new System.Drawing.Point(728, 398);
            this.TxtYazarTur.Name = "TxtYazarTur";
            this.TxtYazarTur.Size = new System.Drawing.Size(100, 22);
            this.TxtYazarTur.TabIndex = 126;
            // 
            // TxtDogumYili
            // 
            this.TxtDogumYili.Location = new System.Drawing.Point(728, 430);
            this.TxtDogumYili.Name = "TxtDogumYili";
            this.TxtDogumYili.Size = new System.Drawing.Size(100, 22);
            this.TxtDogumYili.TabIndex = 125;
            // 
            // TxtAraYazar
            // 
            this.TxtAraYazar.Location = new System.Drawing.Point(758, 457);
            this.TxtAraYazar.Name = "TxtAraYazar";
            this.TxtAraYazar.Size = new System.Drawing.Size(100, 22);
            this.TxtAraYazar.TabIndex = 124;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(639, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 123;
            this.label9.Text = "YazarNo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(639, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 122;
            this.label10.Text = "Yazar Adı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(639, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 121;
            this.label11.Text = "Yazar Soyadı:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(639, 397);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 17);
            this.label12.TabIndex = 120;
            this.label12.Text = "Tür:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(639, 426);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 17);
            this.label13.TabIndex = 119;
            this.label13.Text = "Doğum Yılı:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(639, 461);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 17);
            this.label14.TabIndex = 118;
            this.label14.Text = "Aranacak Yazar:";
            // 
            // txtYazarNo
            // 
            this.txtYazarNo.Location = new System.Drawing.Point(727, 313);
            this.txtYazarNo.Name = "txtYazarNo";
            this.txtYazarNo.Size = new System.Drawing.Size(100, 22);
            this.txtYazarNo.TabIndex = 117;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(637, 282);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 25);
            this.label15.TabIndex = 116;
            this.label15.Text = "YAZAR";
            // 
            // TxtKitapAdi
            // 
            this.TxtKitapAdi.Location = new System.Drawing.Point(412, 342);
            this.TxtKitapAdi.Name = "TxtKitapAdi";
            this.TxtKitapAdi.Size = new System.Drawing.Size(100, 22);
            this.TxtKitapAdi.TabIndex = 115;
            // 
            // TxtTur
            // 
            this.TxtTur.Location = new System.Drawing.Point(412, 370);
            this.TxtTur.Name = "TxtTur";
            this.TxtTur.Size = new System.Drawing.Size(100, 22);
            this.TxtTur.TabIndex = 114;
            // 
            // TxtSayfa
            // 
            this.TxtSayfa.Location = new System.Drawing.Point(412, 398);
            this.TxtSayfa.Name = "TxtSayfa";
            this.TxtSayfa.Size = new System.Drawing.Size(100, 22);
            this.TxtSayfa.TabIndex = 113;
            // 
            // TxtYazar
            // 
            this.TxtYazar.Location = new System.Drawing.Point(412, 425);
            this.TxtYazar.Name = "TxtYazar";
            this.TxtYazar.Size = new System.Drawing.Size(100, 22);
            this.TxtYazar.TabIndex = 112;
            // 
            // TxtAraKitap
            // 
            this.TxtAraKitap.Location = new System.Drawing.Point(437, 458);
            this.TxtAraKitap.Name = "TxtAraKitap";
            this.TxtAraKitap.Size = new System.Drawing.Size(100, 22);
            this.TxtAraKitap.TabIndex = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 110;
            this.label2.Text = "KitapNo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 109;
            this.label3.Text = "Kitap Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 108;
            this.label4.Text = "Tür:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 107;
            this.label5.Text = "Sayfa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 106;
            this.label6.Text = "Yazar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 105;
            this.label7.Text = "Aranacak Kitap:";
            // 
            // TxtKitapNo
            // 
            this.TxtKitapNo.Location = new System.Drawing.Point(411, 313);
            this.TxtKitapNo.Name = "TxtKitapNo";
            this.TxtKitapNo.Size = new System.Drawing.Size(100, 22);
            this.TxtKitapNo.TabIndex = 104;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(320, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 25);
            this.label8.TabIndex = 103;
            this.label8.Text = "KİTAP";
            // 
            // AbtnEkle
            // 
            this.AbtnEkle.Location = new System.Drawing.Point(234, 339);
            this.AbtnEkle.Name = "AbtnEkle";
            this.AbtnEkle.Size = new System.Drawing.Size(75, 23);
            this.AbtnEkle.TabIndex = 102;
            this.AbtnEkle.Text = "Ekle";
            this.AbtnEkle.UseVisualStyleBackColor = true;
            this.AbtnEkle.Click += new System.EventHandler(this.AbtnEkle_Click);
            // 
            // AbtnSil
            // 
            this.AbtnSil.Location = new System.Drawing.Point(234, 370);
            this.AbtnSil.Name = "AbtnSil";
            this.AbtnSil.Size = new System.Drawing.Size(75, 23);
            this.AbtnSil.TabIndex = 101;
            this.AbtnSil.Text = "Sil";
            this.AbtnSil.UseVisualStyleBackColor = true;
            this.AbtnSil.Click += new System.EventHandler(this.AbtnSil_Click);
            // 
            // AbtnGuncelle
            // 
            this.AbtnGuncelle.Location = new System.Drawing.Point(234, 399);
            this.AbtnGuncelle.Name = "AbtnGuncelle";
            this.AbtnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.AbtnGuncelle.TabIndex = 100;
            this.AbtnGuncelle.Text = "Güncelle";
            this.AbtnGuncelle.UseVisualStyleBackColor = true;
            this.AbtnGuncelle.Click += new System.EventHandler(this.AbtnGuncelle_Click);
            // 
            // AbtnArama
            // 
            this.AbtnArama.Location = new System.Drawing.Point(234, 428);
            this.AbtnArama.Name = "AbtnArama";
            this.AbtnArama.Size = new System.Drawing.Size(75, 23);
            this.AbtnArama.TabIndex = 99;
            this.AbtnArama.Text = "Arama";
            this.AbtnArama.UseVisualStyleBackColor = true;
            this.AbtnArama.Click += new System.EventHandler(this.AbtnArama_Click);
            // 
            // TxtAliciAdi
            // 
            this.TxtAliciAdi.Location = new System.Drawing.Point(113, 342);
            this.TxtAliciAdi.Name = "TxtAliciAdi";
            this.TxtAliciAdi.Size = new System.Drawing.Size(100, 22);
            this.TxtAliciAdi.TabIndex = 98;
            // 
            // TxtAliciSoyadi
            // 
            this.TxtAliciSoyadi.Location = new System.Drawing.Point(113, 370);
            this.TxtAliciSoyadi.Name = "TxtAliciSoyadi";
            this.TxtAliciSoyadi.Size = new System.Drawing.Size(100, 22);
            this.TxtAliciSoyadi.TabIndex = 97;
            // 
            // TxtAdresil
            // 
            this.TxtAdresil.Location = new System.Drawing.Point(113, 398);
            this.TxtAdresil.Name = "TxtAdresil";
            this.TxtAdresil.Size = new System.Drawing.Size(100, 22);
            this.TxtAdresil.TabIndex = 96;
            // 
            // TxtKartNo
            // 
            this.TxtKartNo.Location = new System.Drawing.Point(113, 425);
            this.TxtKartNo.Name = "TxtKartNo";
            this.TxtKartNo.Size = new System.Drawing.Size(100, 22);
            this.TxtKartNo.TabIndex = 95;
            // 
            // TxtArama
            // 
            this.TxtArama.Location = new System.Drawing.Point(130, 457);
            this.TxtArama.Name = "TxtArama";
            this.TxtArama.Size = new System.Drawing.Size(100, 22);
            this.TxtArama.TabIndex = 94;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(23, 313);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(55, 17);
            this.label25.TabIndex = 93;
            this.label25.Text = "AlıcıNo:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(23, 342);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 17);
            this.label24.TabIndex = 92;
            this.label24.Text = "Alıcı Adı:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(23, 368);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(84, 17);
            this.label23.TabIndex = 91;
            this.label23.Text = "Alıcı Soyadı:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(23, 396);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 17);
            this.label22.TabIndex = 90;
            this.label22.Text = "Adres İl:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(23, 425);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 17);
            this.label21.TabIndex = 89;
            this.label21.Text = "Kart No:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(23, 460);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(101, 17);
            this.label20.TabIndex = 88;
            this.label20.Text = "Aranacak Alıcı:";
            // 
            // AbtnListele
            // 
            this.AbtnListele.Location = new System.Drawing.Point(234, 310);
            this.AbtnListele.Name = "AbtnListele";
            this.AbtnListele.Size = new System.Drawing.Size(75, 23);
            this.AbtnListele.TabIndex = 87;
            this.AbtnListele.Text = "Listele";
            this.AbtnListele.UseVisualStyleBackColor = true;
            this.AbtnListele.Click += new System.EventHandler(this.AbtnListele_Click);
            // 
            // TxtAliciNo
            // 
            this.TxtAliciNo.Location = new System.Drawing.Point(112, 313);
            this.TxtAliciNo.Name = "TxtAliciNo";
            this.TxtAliciNo.Size = new System.Drawing.Size(100, 22);
            this.TxtAliciNo.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 85;
            this.label1.Text = "ALICI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(895, 267);
            this.dataGridView1.TabIndex = 84;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 498);
            this.Controls.Add(this.KbtnEkle);
            this.Controls.Add(this.KbtnSil);
            this.Controls.Add(this.KbtnGuncelle);
            this.Controls.Add(this.KbtnArama);
            this.Controls.Add(this.KbtnListele);
            this.Controls.Add(this.YbtnEkle);
            this.Controls.Add(this.YbtnSil);
            this.Controls.Add(this.YbtnGuncelle);
            this.Controls.Add(this.YbtnArama);
            this.Controls.Add(this.YbtnListele);
            this.Controls.Add(this.TxtYazarAdi);
            this.Controls.Add(this.TxtYazarSoyadi);
            this.Controls.Add(this.TxtYazarTur);
            this.Controls.Add(this.TxtDogumYili);
            this.Controls.Add(this.TxtAraYazar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtYazarNo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtKitapAdi);
            this.Controls.Add(this.TxtTur);
            this.Controls.Add(this.TxtSayfa);
            this.Controls.Add(this.TxtYazar);
            this.Controls.Add(this.TxtAraKitap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtKitapNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AbtnEkle);
            this.Controls.Add(this.AbtnSil);
            this.Controls.Add(this.AbtnGuncelle);
            this.Controls.Add(this.AbtnArama);
            this.Controls.Add(this.TxtAliciAdi);
            this.Controls.Add(this.TxtAliciSoyadi);
            this.Controls.Add(this.TxtAdresil);
            this.Controls.Add(this.TxtKartNo);
            this.Controls.Add(this.TxtArama);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.AbtnListele);
            this.Controls.Add(this.TxtAliciNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KbtnEkle;
        private System.Windows.Forms.Button KbtnSil;
        private System.Windows.Forms.Button KbtnGuncelle;
        private System.Windows.Forms.Button KbtnArama;
        private System.Windows.Forms.Button KbtnListele;
        private System.Windows.Forms.Button YbtnEkle;
        private System.Windows.Forms.Button YbtnSil;
        private System.Windows.Forms.Button YbtnGuncelle;
        private System.Windows.Forms.Button YbtnArama;
        private System.Windows.Forms.Button YbtnListele;
        private System.Windows.Forms.TextBox TxtYazarAdi;
        private System.Windows.Forms.TextBox TxtYazarSoyadi;
        private System.Windows.Forms.TextBox TxtYazarTur;
        private System.Windows.Forms.TextBox TxtDogumYili;
        private System.Windows.Forms.TextBox TxtAraYazar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtYazarNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtKitapAdi;
        private System.Windows.Forms.TextBox TxtTur;
        private System.Windows.Forms.TextBox TxtSayfa;
        private System.Windows.Forms.TextBox TxtYazar;
        private System.Windows.Forms.TextBox TxtAraKitap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtKitapNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AbtnEkle;
        private System.Windows.Forms.Button AbtnSil;
        private System.Windows.Forms.Button AbtnGuncelle;
        private System.Windows.Forms.Button AbtnArama;
        private System.Windows.Forms.TextBox TxtAliciAdi;
        private System.Windows.Forms.TextBox TxtAliciSoyadi;
        private System.Windows.Forms.TextBox TxtAdresil;
        private System.Windows.Forms.TextBox TxtKartNo;
        private System.Windows.Forms.TextBox TxtArama;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button AbtnListele;
        private System.Windows.Forms.TextBox TxtAliciNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

