<<<<<<< HEAD
﻿using System;
using tasarimproje.Interfaces;

namespace tasarimproje.Patterns.Behavioral
{
    public class YurticiKargoStratejisi : IKargoStratejisi
    {
        public decimal CalculateFee(decimal weight, decimal amount) => 60 + (weight * 4);
        public string GenerateTrackingNumber() => "YRT-" + DateTime.Now.Ticks.ToString().Substring(10);
    }
=======
﻿using System;
using tasarimproje.Interfaces;

namespace tasarimproje.Patterns.Behavioral
{
    public class YurticiKargoStratejisi : IKargoStratejisi
    {
        public decimal CalculateFee(decimal weight, decimal amount) => 60 + (weight * 4);
        public string GenerateTrackingNumber() => "YRT-" + DateTime.Now.Ticks.ToString().Substring(10);
    }
>>>>>>> a0005938bba87bf4dba2d87124c65b16e14df65d
}