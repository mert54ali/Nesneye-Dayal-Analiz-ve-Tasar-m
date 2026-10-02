<<<<<<< HEAD
﻿using System;

namespace tasarimproje.Services
{
    public class EnvanterServisi
    {
        // Stok kontrolünü yapan metodumuz
        public bool CheckStock(string productName)
        {
            // Eğer içinde "yok" geçiyorsa FALSE (Stok Yok) dönmeli
            if (productName.ToLower().Contains("yok"))
            {
                return false;
            }

            return true; // Diğer durumlarda TRUE (Stok Var) dönmeli
        }
    }
=======
﻿using System;

namespace tasarimproje.Services
{
    public class EnvanterServisi
    {
        // Stok kontrolünü yapan metodumuz
        public bool CheckStock(string productName)
        {
            // Eğer içinde "yok" geçiyorsa FALSE (Stok Yok) dönmeli
            if (productName.ToLower().Contains("yok"))
            {
                return false;
            }

            return true; // Diğer durumlarda TRUE (Stok Var) dönmeli
        }
    }
>>>>>>> a0005938bba87bf4dba2d87124c65b16e14df65d
}