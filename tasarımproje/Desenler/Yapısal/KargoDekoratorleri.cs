<<<<<<< HEAD
﻿using tasarimproje.Interfaces;

namespace tasarimproje.Patterns.Structural
{
    // Dekoratör Sınıfı
    public abstract class CargoPriceDecorator : IKargoFiyati
    {
        protected IKargoFiyati _cargoPrice;

        public CargoPriceDecorator(IKargoFiyati cargoPrice)
        {
            _cargoPrice = cargoPrice;
        }

        public virtual decimal CalculatePrice(decimal weight, decimal distance)
        {
            return _cargoPrice.CalculatePrice(weight, distance);
        }
    }

    // Sigortalı Gönderim
    public class InsuredCargoDecorator : CargoPriceDecorator
    {
        public InsuredCargoDecorator(IKargoFiyati cargoPrice) : base(cargoPrice) { }

        public override decimal CalculatePrice(decimal weight, decimal distance)
        {
            decimal basePrice = base.CalculatePrice(weight, distance);
            // Sigorta için standart fiyata %10 ekleriz
            return basePrice + (basePrice * 0.10m);
        }
    }

    // Kırılacak Eşya Koruması
    public class FragileCargoDecorator : CargoPriceDecorator
    {
        public FragileCargoDecorator(IKargoFiyati cargoPrice) : base(cargoPrice) { }

        public override decimal CalculatePrice(decimal weight, decimal distance)
        {
            decimal basePrice = base.CalculatePrice(weight, distance);
            // Kırılacak eşya için fiyata sabit 50 TL ekleriz
            return basePrice + 50.0m;
        }
    }
=======
﻿using tasarimproje.Interfaces;

namespace tasarimproje.Patterns.Structural
{
    // Dekoratör Sınıfı
    public abstract class CargoPriceDecorator : IKargoFiyati
    {
        protected IKargoFiyati _cargoPrice;

        public CargoPriceDecorator(IKargoFiyati cargoPrice)
        {
            _cargoPrice = cargoPrice;
        }

        public virtual decimal CalculatePrice(decimal weight, decimal distance)
        {
            return _cargoPrice.CalculatePrice(weight, distance);
        }
    }

    // Sigortalı Gönderim
    public class InsuredCargoDecorator : CargoPriceDecorator
    {
        public InsuredCargoDecorator(IKargoFiyati cargoPrice) : base(cargoPrice) { }

        public override decimal CalculatePrice(decimal weight, decimal distance)
        {
            decimal basePrice = base.CalculatePrice(weight, distance);
            // Sigorta için standart fiyata %10 ekleriz
            return basePrice + (basePrice * 0.10m);
        }
    }

    // Kırılacak Eşya Koruması
    public class FragileCargoDecorator : CargoPriceDecorator
    {
        public FragileCargoDecorator(IKargoFiyati cargoPrice) : base(cargoPrice) { }

        public override decimal CalculatePrice(decimal weight, decimal distance)
        {
            decimal basePrice = base.CalculatePrice(weight, distance);
            // Kırılacak eşya için fiyata sabit 50 TL ekleriz
            return basePrice + 50.0m;
        }
    }
>>>>>>> a0005938bba87bf4dba2d87124c65b16e14df65d
}