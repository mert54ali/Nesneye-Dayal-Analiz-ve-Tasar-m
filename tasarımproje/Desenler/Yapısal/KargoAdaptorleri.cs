<<<<<<< HEAD
﻿using tasarimproje.Interfaces;
using tasarimproje.Services;

namespace tasarimproje.Patterns.Structural
{
    // Aras Kargo 
    public class ArasAdapter : IKargoSaglayici
    {
        private readonly ArasApi _arasApi;

        public ArasAdapter()
        {
            _arasApi = new ArasApi();
        }

        public string CreateShipment(string address, decimal weight)
        {
            // Bizim verimizi Aras'ın anladığı tipe dönüştürür
            string trackingNumber = _arasApi.ArasKargoGonder(address, (double)weight);
            return trackingNumber;
        }
    }

    // Yurtiçi Kargo 
    public class YurticiAdapter : IKargoSaglayici
    {
        private readonly YurticiApi _yurticiApi;

        public YurticiAdapter()
        {
            _yurticiApi = new YurticiApi();
        }

        public string CreateShipment(string address, decimal weight)
        {
            string[] addressParts = address.Split('-');
            string il = addressParts.Length > 0 ? addressParts[0] : "Bilinmiyor";
            string ilce = addressParts.Length > 1 ? addressParts[1] : "Bilinmiyor";
            int desi = (int)(weight * 1.5m); // Ağırlığı desiye çeviriyor

            string trackingNumber = _yurticiApi.YurticiBarkodOlustur(desi, il, ilce);
            return trackingNumber;
        }
    }
=======
﻿using tasarimproje.Interfaces;
using tasarimproje.Services;

namespace tasarimproje.Patterns.Structural
{
    // Aras Kargo 
    public class ArasAdapter : IKargoSaglayici
    {
        private readonly ArasApi _arasApi;

        public ArasAdapter()
        {
            _arasApi = new ArasApi();
        }

        public string CreateShipment(string address, decimal weight)
        {
            // Bizim verimizi Aras'ın anladığı tipe dönüştürür
            string trackingNumber = _arasApi.ArasKargoGonder(address, (double)weight);
            return trackingNumber;
        }
    }

    // Yurtiçi Kargo 
    public class YurticiAdapter : IKargoSaglayici
    {
        private readonly YurticiApi _yurticiApi;

        public YurticiAdapter()
        {
            _yurticiApi = new YurticiApi();
        }

        public string CreateShipment(string address, decimal weight)
        {
            string[] addressParts = address.Split('-');
            string il = addressParts.Length > 0 ? addressParts[0] : "Bilinmiyor";
            string ilce = addressParts.Length > 1 ? addressParts[1] : "Bilinmiyor";
            int desi = (int)(weight * 1.5m); // Ağırlığı desiye çeviriyor

            string trackingNumber = _yurticiApi.YurticiBarkodOlustur(desi, il, ilce);
            return trackingNumber;
        }
    }
>>>>>>> a0005938bba87bf4dba2d87124c65b16e14df65d
}