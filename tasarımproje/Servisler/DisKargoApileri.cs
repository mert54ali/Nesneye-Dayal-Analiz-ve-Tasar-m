<<<<<<< HEAD
﻿using System;

namespace tasarimproje.Services
{
    //  Aras Kargo'nun kendi yazdığı dış sistem 
    public class ArasApi
    {
        public string ArasKargoGonder(string teslimatAdresi, double kilo)
        {
            return $"ARAS-{Guid.NewGuid().ToString().Substring(0, 5)}";
        }
    }

    // Yurtiçi Kargo'nun kendi yazdığı dış sistem 
    public class YurticiApi
    {
        public string YurticiBarkodOlustur(int desi, string il, string ilce)
        {
            return $"YRT-{Guid.NewGuid().ToString().Substring(0, 5)}";
        }
    }
=======
﻿using System;

namespace tasarimproje.Services
{
    //  Aras Kargo'nun kendi yazdığı dış sistem 
    public class ArasApi
    {
        public string ArasKargoGonder(string teslimatAdresi, double kilo)
        {
            return $"ARAS-{Guid.NewGuid().ToString().Substring(0, 5)}";
        }
    }

    // Yurtiçi Kargo'nun kendi yazdığı dış sistem 
    public class YurticiApi
    {
        public string YurticiBarkodOlustur(int desi, string il, string ilce)
        {
            return $"YRT-{Guid.NewGuid().ToString().Substring(0, 5)}";
        }
    }
>>>>>>> a0005938bba87bf4dba2d87124c65b16e14df65d
}