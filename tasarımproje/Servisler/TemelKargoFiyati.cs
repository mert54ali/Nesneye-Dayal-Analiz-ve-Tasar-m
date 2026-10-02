<<<<<<< HEAD
﻿using tasarimproje.Interfaces;

namespace tasarimproje.Services
{
    // Hiçbir ek hizmeti olmayan standart kargo fiyatı
    public class TemelKargoFiyati : IKargoFiyati
    {
        public decimal CalculatePrice(decimal weight, decimal distance)
        {
            // Temel formül: Kilo * 10 + Mesafe * 2
            return (weight * 10) + (distance * 2);
        }
    }
=======
﻿using tasarimproje.Interfaces;

namespace tasarimproje.Services
{
    // Hiçbir ek hizmeti olmayan standart kargo fiyatı
    public class TemelKargoFiyati : IKargoFiyati
    {
        public decimal CalculatePrice(decimal weight, decimal distance)
        {
            // Temel formül: Kilo * 10 + Mesafe * 2
            return (weight * 10) + (distance * 2);
        }
    }
>>>>>>> a0005938bba87bf4dba2d87124c65b16e14df65d
}