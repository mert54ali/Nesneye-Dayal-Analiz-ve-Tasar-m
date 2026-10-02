<<<<<<< HEAD
﻿using System;
using tasarimproje.Interfaces;

namespace tasarimproje.Patterns.Behavioral
{
    public class MngKargoStratejisi : IKargoStratejisi
    {
        public decimal CalculateFee(decimal weight, decimal amount) => 50 + (weight * 5);
        public string GenerateTrackingNumber() => "MNG-" + Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
    }
=======
﻿using System;
using tasarimproje.Interfaces;

namespace tasarimproje.Patterns.Behavioral
{
    public class MngKargoStratejisi : IKargoStratejisi
    {
        public decimal CalculateFee(decimal weight, decimal amount) => 50 + (weight * 5);
        public string GenerateTrackingNumber() => "MNG-" + Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
    }
>>>>>>> a0005938bba87bf4dba2d87124c65b16e14df65d
}