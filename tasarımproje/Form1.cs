<<<<<<< HEAD
﻿using System;
using System.IO;
using System.Windows.Forms;
using tasarimproje.Controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tasarimproje
{
    public partial class Form1 : Form
    {
        private tasarimproje.Models.Siparis currentOrder;
        private SiparisKontrolcusu _orderController;
        private string _currentOrderInfo = ""; // State takibi için

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
            button1.Click += button1_Click; // Siparişi Oluştur
            button2.Click += button2_Click; // Durumu İlerlet

            _orderController = new SiparisKontrolcusu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] { "Kredi Kartı", "Nakit" });
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new string[] { "MNG Kargo", "Aras Kargo", "Yurtiçi Kargo" });

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            // Hazır Test
            textBox1.Text = "1500";         // Tutar
            textBox2.Text = "5";            // Ağırlık
            textBox3.Text = "Akıllı Telefon"; // Ürün Adı

            richTextBox1.Text = "Sistem Hazır. Örnek veriler yüklendi.\n";
        }

        // SİPARİŞİ OLUŞTUR
        private void button1_Click(object sender, EventArgs e)
        {
            // Kutudaki yazıyı alma, sağındaki solundaki boşlukları temizleme ve küçük harfe çevirme
            string urunAdi = textBox3.Text.Trim().ToLower();

            //  MANUEL ENGEL
            if (urunAdi == "yok")
            {
                // Kırmızı hata kutusu
                MessageBox.Show("DUR! HATA: Ürün stokta bulunamadı!", "STOK KONTROLÜ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Beyaz kutuya not düşüyoruz
                richTextBox1.Text += "\n[KRİTİK HATA] 'yok' isimli ürün stokta bulunamadı! İşlem iptal.\n";

                // Diğer butonu kapatıyoruz
                button2.Enabled = false;

                return;
            }

            // EĞER 'yok' YAZMIYORSA BURADAN AŞAĞISI ÇALIŞIR
            try
            {
                // Normal sipariş işlemlerini buraya alıyoruz
                string odeme = comboBox1.SelectedItem?.ToString() ?? "Belirtilmedi";
                string kargo = comboBox2.SelectedItem?.ToString() ?? "Belirtilmedi";

                // Tutar ve ağırlık kontrolü
                decimal tutar = decimal.TryParse(textBox1.Text, out decimal t) ? t : 0;
                decimal agirlik = decimal.TryParse(textBox2.Text, out decimal a) ? a : 0;

                string sonuc = _orderController.CreateOrder(odeme, kargo, tutar, agirlik, textBox3.Text);

                currentOrder = new tasarimproje.Models.Siparis();
                richTextBox1.Text += $"\nSipariş Başarıyla Oluşturuldu: {textBox3.Text}\n{sonuc}\n";
                button2.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
 
        private void button2_Click(object sender, EventArgs e)
        {
            if (currentOrder != null)
            {
                //  Önce kargonun şu anki durumunun öğrenilmesi
                string mevcutDurum = currentOrder.GetStatus();

                // Eğer kargo "İade Edildi" veya "Teslim Edildi" ise ilerlemesini durdurmak
                if (mevcutDurum == "İade Edildi" || mevcutDurum == "Teslim Edildi")
                {
                    MessageBox.Show($"Bu sipariş '{mevcutDurum}' durumunda olduğu için aşaması değiştirilemez!", "İşlem Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // button2.Enabled = false; 

                    return; 
                }

                currentOrder.Next();
                richTextBox1.Text += $"\nGüncel Durum: {currentOrder.GetStatus()}";
            }
            else
            {
                MessageBox.Show("Önce bir sipariş oluşturmalısınız!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (currentOrder != null)
            {
                // Eğer sipariş 'Kargoda' ise duruma 'İade Edildi' atar
                currentOrder.Cancel();

                // Sonucu ekranda görme
                richTextBox1.Text += $"\n[İŞLEM]: İptal/İade Talebi Gönderildi.";
                richTextBox1.Text += $"\n[GÜNCEL DURUM]: {currentOrder.GetStatus()}\n";
            }
            else
            {
                MessageBox.Show("Önce bir sipariş oluşturmalısınız!");
            }
        }

        private void btnCompositeTest_Click(object sender, EventArgs e)
        {
            try
            {

                string anaUrunAdi = textBox3.Text;
                decimal anaUrunFiyati = decimal.Parse(textBox1.Text);

                // Parçaları oluşturma
                tasarimproje.Patterns.Structural.IProductComponent anaUrun =
                    new tasarimproje.Patterns.Structural.SingleProduct(anaUrunAdi, anaUrunFiyati);

                tasarimproje.Patterns.Structural.IProductComponent sigorta =
                    new tasarimproje.Patterns.Structural.SingleProduct("Kargo Sigortası", 50m);

                tasarimproje.Patterns.Structural.IProductComponent hediyePaketi =
                    new tasarimproje.Patterns.Structural.SingleProduct("Özel Hediye Paketi", 25m);

                // Montajlı ürünü oluşturma
                tasarimproje.Patterns.Structural.ProductBundle siparisPaketi =
                    new tasarimproje.Patterns.Structural.ProductBundle("VIP Müşteri Sepeti");

                // Ürünleri paketin içine atma
                siparisPaketi.AddProduct(anaUrun);
                siparisPaketi.AddProduct(sigorta);
                siparisPaketi.AddProduct(hediyePaketi);

                string sonuc = $"--- COMPOSITE PATTERN (DİNAMİK) ---\n" +
                               $"Paket: {siparisPaketi.GetName()}\n" +
                               $"İçindekiler: {anaUrun.GetName()}, {sigorta.GetName()}, {hediyePaketi.GetName()}\n" +
                               $"Ana Ürün Fiyatı: {anaUrun.GetPrice()} TL\n" +
                               $"Paketin Toplam Fiyatı: {siparisPaketi.GetPrice()} TL\n";
                // Toplam = fiyat + 50 + 25 olarak hesaplanacak

                richTextBox1.Text += $"\n{sonuc}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen fiyat kısmına geçerli bir sayı girin! Hata: " + ex.Message);
            }
        }
    }
=======
﻿using System;
using System.IO;
using System.Windows.Forms;
using tasarimproje.Controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tasarimproje
{
    public partial class Form1 : Form
    {
        private tasarimproje.Models.Siparis currentOrder;
        private SiparisKontrolcusu _orderController;
        private string _currentOrderInfo = ""; // State takibi için

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
            button1.Click += button1_Click; // Siparişi Oluştur
            button2.Click += button2_Click; // Durumu İlerlet

            _orderController = new SiparisKontrolcusu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] { "Kredi Kartı", "Nakit" });
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new string[] { "MNG Kargo", "Aras Kargo", "Yurtiçi Kargo" });

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            // Hazır Test
            textBox1.Text = "1500";         // Tutar
            textBox2.Text = "5";            // Ağırlık
            textBox3.Text = "Akıllı Telefon"; // Ürün Adı

            richTextBox1.Text = "Sistem Hazır. Örnek veriler yüklendi.\n";
        }

        // SİPARİŞİ OLUŞTUR
        private void button1_Click(object sender, EventArgs e)
        {
            // Kutudaki yazıyı alma, sağındaki solundaki boşlukları temizleme ve küçük harfe çevirme
            string urunAdi = textBox3.Text.Trim().ToLower();

            //  MANUEL ENGEL
            if (urunAdi == "yok")
            {
                // Kırmızı hata kutusu
                MessageBox.Show("DUR! HATA: Ürün stokta bulunamadı!", "STOK KONTROLÜ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Beyaz kutuya not düşüyoruz
                richTextBox1.Text += "\n[KRİTİK HATA] 'yok' isimli ürün stokta bulunamadı! İşlem iptal.\n";

                // Diğer butonu kapatıyoruz
                button2.Enabled = false;

                return;
            }

            // EĞER 'yok' YAZMIYORSA BURADAN AŞAĞISI ÇALIŞIR
            try
            {
                // Normal sipariş işlemlerini buraya alıyoruz
                string odeme = comboBox1.SelectedItem?.ToString() ?? "Belirtilmedi";
                string kargo = comboBox2.SelectedItem?.ToString() ?? "Belirtilmedi";

                // Tutar ve ağırlık kontrolü
                decimal tutar = decimal.TryParse(textBox1.Text, out decimal t) ? t : 0;
                decimal agirlik = decimal.TryParse(textBox2.Text, out decimal a) ? a : 0;

                string sonuc = _orderController.CreateOrder(odeme, kargo, tutar, agirlik, textBox3.Text);

                currentOrder = new tasarimproje.Models.Siparis();
                richTextBox1.Text += $"\nSipariş Başarıyla Oluşturuldu: {textBox3.Text}\n{sonuc}\n";
                button2.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
 
        private void button2_Click(object sender, EventArgs e)
        {
            if (currentOrder != null)
            {
                //  Önce kargonun şu anki durumunun öğrenilmesi
                string mevcutDurum = currentOrder.GetStatus();

                // Eğer kargo "İade Edildi" veya "Teslim Edildi" ise ilerlemesini durdurmak
                if (mevcutDurum == "İade Edildi" || mevcutDurum == "Teslim Edildi")
                {
                    MessageBox.Show($"Bu sipariş '{mevcutDurum}' durumunda olduğu için aşaması değiştirilemez!", "İşlem Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // button2.Enabled = false; 

                    return; 
                }

                currentOrder.Next();
                richTextBox1.Text += $"\nGüncel Durum: {currentOrder.GetStatus()}";
            }
            else
            {
                MessageBox.Show("Önce bir sipariş oluşturmalısınız!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (currentOrder != null)
            {
                // Eğer sipariş 'Kargoda' ise duruma 'İade Edildi' atar
                currentOrder.Cancel();

                // Sonucu ekranda görme
                richTextBox1.Text += $"\n[İŞLEM]: İptal/İade Talebi Gönderildi.";
                richTextBox1.Text += $"\n[GÜNCEL DURUM]: {currentOrder.GetStatus()}\n";
            }
            else
            {
                MessageBox.Show("Önce bir sipariş oluşturmalısınız!");
            }
        }

        private void btnCompositeTest_Click(object sender, EventArgs e)
        {
            try
            {

                string anaUrunAdi = textBox3.Text;
                decimal anaUrunFiyati = decimal.Parse(textBox1.Text);

                // Parçaları oluşturma
                tasarimproje.Patterns.Structural.IProductComponent anaUrun =
                    new tasarimproje.Patterns.Structural.SingleProduct(anaUrunAdi, anaUrunFiyati);

                tasarimproje.Patterns.Structural.IProductComponent sigorta =
                    new tasarimproje.Patterns.Structural.SingleProduct("Kargo Sigortası", 50m);

                tasarimproje.Patterns.Structural.IProductComponent hediyePaketi =
                    new tasarimproje.Patterns.Structural.SingleProduct("Özel Hediye Paketi", 25m);

                // Montajlı ürünü oluşturma
                tasarimproje.Patterns.Structural.ProductBundle siparisPaketi =
                    new tasarimproje.Patterns.Structural.ProductBundle("VIP Müşteri Sepeti");

                // Ürünleri paketin içine atma
                siparisPaketi.AddProduct(anaUrun);
                siparisPaketi.AddProduct(sigorta);
                siparisPaketi.AddProduct(hediyePaketi);

                string sonuc = $"--- COMPOSITE PATTERN (DİNAMİK) ---\n" +
                               $"Paket: {siparisPaketi.GetName()}\n" +
                               $"İçindekiler: {anaUrun.GetName()}, {sigorta.GetName()}, {hediyePaketi.GetName()}\n" +
                               $"Ana Ürün Fiyatı: {anaUrun.GetPrice()} TL\n" +
                               $"Paketin Toplam Fiyatı: {siparisPaketi.GetPrice()} TL\n";
                // Toplam = fiyat + 50 + 25 olarak hesaplanacak

                richTextBox1.Text += $"\n{sonuc}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen fiyat kısmına geçerli bir sayı girin! Hata: " + ex.Message);
            }
        }
    }
>>>>>>> a0005938bba87bf4dba2d87124c65b16e14df65d
}