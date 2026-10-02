using Microsoft.VisualStudio.TestTools.UnitTesting;
using tasarimproje.Patterns.Structural; // Montajlı Ürün için
using tasarimproje.Patterns.Behavioral; // Kargo Stratejisi için

namespace tasarimproje.Tests
{
    [TestClass]
    public class ProjeKritikMetotTestleri
    {
        [TestMethod]
        public void MontajliUrun_FiyatHesaplama_DogruSonucVermeli()
        {
            //Hazırlık Aşaması
            // İki tane alt ürün ve bir ana paket oluşturma
            SingleProduct anakart = new SingleProduct("Anakart", 3000m);
            SingleProduct islemci = new SingleProduct("İşlemci", 5000m);
            ProductBundle bilgisayarKasasi = new ProductBundle("Oyun Kasası");

            bilgisayarKasasi.AddProduct(anakart);
            bilgisayarKasasi.AddProduct(islemci);

            // Eylem Aşaması
            // Kasanın toplam fiyatını hesaplatıyoruz
            decimal toplamFiyat = bilgisayarKasasi.GetPrice();

            // Doğrulama Aşaması
            Assert.AreEqual(8000m, toplamFiyat);
        }

        [TestMethod]
        public void ArasKargo_UcretHesaplama_DogruSonucVermeli()
        {
            ArasKargoStratejisi arasKargo = new ArasKargoStratejisi();
            decimal kargoAgirligi = 5m; 
            decimal urunTutari = 100m;

            decimal hesaplananUcret = arasKargo.CalculateFee(kargoAgirligi, urunTutari);

            // Çıkan sonucun 75 olup olmadığını sınama
            Assert.AreEqual(75m, hesaplananUcret);
        }
    }
}