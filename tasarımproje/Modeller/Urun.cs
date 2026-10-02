<<<<<<< HEAD
﻿namespace tasarimproje.Models
{
    public class Urun
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int CriticalThreshold { get; set; } // Stok uyarısı için eşik değer
 
        // İleride Composite desenine çevirmek için bu yapı temel
        public bool IsComposite { get; set; }
    }
=======
﻿namespace tasarimproje.Models
{
    public class Urun
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int CriticalThreshold { get; set; } // Stok uyarısı için eşik değer
 
        // İleride Composite desenine çevirmek için bu yapı temel
        public bool IsComposite { get; set; }
    }
>>>>>>> a0005938bba87bf4dba2d87124c65b16e14df65d
}