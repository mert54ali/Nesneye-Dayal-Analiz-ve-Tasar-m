<<<<<<< HEAD
﻿using System;
using tasarimproje.Services;

namespace tasarimproje.Controllers
{
    public class SiparisKontrolcusu
    {
        private int _stateCounter = 0;
        private readonly EnvanterServisi _inventoryService;

        public SiparisKontrolcusu()
        {
            _inventoryService = new EnvanterServisi();
        }

        public string CreateOrder(string payment, string cargo, decimal amount, decimal weight, string productName)
        {
            // STOK KONTROLÜ
            if (!_inventoryService.CheckStock(productName))
            {
                return "HATA: Ürün stokta bulunamadı!";
            }

            // SİPARİŞ ONAYI
            string orderNo = "YRT-" + Guid.NewGuid().ToString().Substring(0, 5);
            return $"Takip No: {orderNo}\nLojistik: (Sistem)\nDurum: Hazırlanıyor";
        }

        public string AdvanceOrderState()
        {
            _stateCounter++;
            if (_stateCounter == 1) return "Sipariş Paketleniyor (State: Processing)";
            if (_stateCounter == 2) return "Kargoya Verildi (State: Shipped)";
            if (_stateCounter >= 3) return "Teslim Edildi (State: Delivered)";
            return "Sipariş zaten sonuçlandı.";
        }
    }
=======
﻿using System;
using tasarimproje.Services;

namespace tasarimproje.Controllers
{
    public class SiparisKontrolcusu
    {
        private int _stateCounter = 0;
        private readonly EnvanterServisi _inventoryService;

        public SiparisKontrolcusu()
        {
            _inventoryService = new EnvanterServisi();
        }

        public string CreateOrder(string payment, string cargo, decimal amount, decimal weight, string productName)
        {
            // STOK KONTROLÜ
            if (!_inventoryService.CheckStock(productName))
            {
                return "HATA: Ürün stokta bulunamadı!";
            }

            // SİPARİŞ ONAYI
            string orderNo = "YRT-" + Guid.NewGuid().ToString().Substring(0, 5);
            return $"Takip No: {orderNo}\nLojistik: (Sistem)\nDurum: Hazırlanıyor";
        }

        public string AdvanceOrderState()
        {
            _stateCounter++;
            if (_stateCounter == 1) return "Sipariş Paketleniyor (State: Processing)";
            if (_stateCounter == 2) return "Kargoya Verildi (State: Shipped)";
            if (_stateCounter >= 3) return "Teslim Edildi (State: Delivered)";
            return "Sipariş zaten sonuçlandı.";
        }
    }
>>>>>>> a0005938bba87bf4dba2d87124c65b16e14df65d
}