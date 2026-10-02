<<<<<<< HEAD
﻿using System;
using tasarimproje.Interfaces;

namespace tasarimproje.Patterns.Behavioral
{
    public class ArasKargoStratejisi : IKargoStratejisi
    {
        public decimal CalculateFee(decimal weight, decimal amount) => 40 + (weight * 7);
        public string GenerateTrackingNumber() => "ARAS-" + new Random().Next(100000, 999999);
    }
=======
﻿using System;
using tasarimproje.Interfaces;

namespace tasarimproje.Patterns.Behavioral
{
    public class ArasKargoStratejisi : IKargoStratejisi
    {
        public decimal CalculateFee(decimal weight, decimal amount) => 40 + (weight * 7);
        public string GenerateTrackingNumber() => "ARAS-" + new Random().Next(100000, 999999);
    }
>>>>>>> a0005938bba87bf4dba2d87124c65b16e14df65d
}