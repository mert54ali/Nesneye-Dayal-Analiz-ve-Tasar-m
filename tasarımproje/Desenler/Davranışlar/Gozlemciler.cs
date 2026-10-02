<<<<<<< HEAD
﻿using System;
using tasarimproje.Interfaces;
using tasarimproje.Patterns.Creational;

namespace tasarimproje.Patterns.Behavioral
{
    // Satın Alma
    public class PurchasingObserver : IGozlemci
    {
        public void Update(string productName, int currentStock)
        {
            string msg = $"SATIN ALMAYA MAİL: {productName} stoğu kritik seviyede ({currentStock}). Lütfen sipariş geçin.";
            Loglayici.Instance.Log(msg); // Singleton logger
        }
    }

    // Sistem içi bildirim
    public class WarehouseObserver : IGozlemci
    {
        public void Update(string productName, int currentStock)
        {
            string msg = $"DEPO BİLDİRİMİ: {productName} ürünü azalıyor. Kalan: {currentStock}";
            Loglayici.Instance.Log(msg);
        }
    }
=======
﻿using System;
using tasarimproje.Interfaces;
using tasarimproje.Patterns.Creational;

namespace tasarimproje.Patterns.Behavioral
{
    // Satın Alma
    public class PurchasingObserver : IGozlemci
    {
        public void Update(string productName, int currentStock)
        {
            string msg = $"SATIN ALMAYA MAİL: {productName} stoğu kritik seviyede ({currentStock}). Lütfen sipariş geçin.";
            Loglayici.Instance.Log(msg); // Singleton logger
        }
    }

    // Sistem içi bildirim
    public class WarehouseObserver : IGozlemci
    {
        public void Update(string productName, int currentStock)
        {
            string msg = $"DEPO BİLDİRİMİ: {productName} ürünü azalıyor. Kalan: {currentStock}";
            Loglayici.Instance.Log(msg);
        }
    }
>>>>>>> a0005938bba87bf4dba2d87124c65b16e14df65d
}