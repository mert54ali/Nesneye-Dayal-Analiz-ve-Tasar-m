<<<<<<< HEAD
﻿using System;
using tasarimproje.Interfaces;
using tasarimproje.Patterns.Creational;

namespace tasarimproje.Patterns.Behavioral
{
    // Kredi Kartı Ödemesi
    public class CreditCardPayment : IOdemeStratejisi
    {
        public bool ProcessPayment(decimal amount)
        {
            // Burada normalde banka API'sine gidilir
            Loglayici.Instance.Log($"Kredi kartından {amount} TL çekildi. İşlem başarılı.");
            return true;
        }
    }

    //  Havale / EFT Ödemesi
    public class BankTransferPayment : IOdemeStratejisi
    {
        public bool ProcessPayment(decimal amount)
        {
            Loglayici.Instance.Log($"Havale bekleniyor... {amount} TL tutarındaki işlem kaydedildi.");
            return true;
        }
    }

    // İleride eklenebilecek Kripto Ödemesi
    public class CryptoPayment : IOdemeStratejisi
    {
        public bool ProcessPayment(decimal amount)
        {
            Loglayici.Instance.Log($"Kripto cüzdanından {amount} USDT çekildi.");
            return true;
        }
    }
=======
﻿using System;
using tasarimproje.Interfaces;
using tasarimproje.Patterns.Creational;

namespace tasarimproje.Patterns.Behavioral
{
    // Kredi Kartı Ödemesi
    public class CreditCardPayment : IOdemeStratejisi
    {
        public bool ProcessPayment(decimal amount)
        {
            // Burada normalde banka API'sine gidilir
            Loglayici.Instance.Log($"Kredi kartından {amount} TL çekildi. İşlem başarılı.");
            return true;
        }
    }

    //  Havale / EFT Ödemesi
    public class BankTransferPayment : IOdemeStratejisi
    {
        public bool ProcessPayment(decimal amount)
        {
            Loglayici.Instance.Log($"Havale bekleniyor... {amount} TL tutarındaki işlem kaydedildi.");
            return true;
        }
    }

    // İleride eklenebilecek Kripto Ödemesi
    public class CryptoPayment : IOdemeStratejisi
    {
        public bool ProcessPayment(decimal amount)
        {
            Loglayici.Instance.Log($"Kripto cüzdanından {amount} USDT çekildi.");
            return true;
        }
    }
>>>>>>> a0005938bba87bf4dba2d87124c65b16e14df65d
}