<<<<<<< HEAD
﻿using tasarimproje.Models;

namespace tasarimproje.Patterns.Creational
{
    public class ComputerBuilder
    {
        private Urun _product;

        public ComputerBuilder()
        {
            _product = new Urun
            {
                Name = "Toplama Bilgisayar",
                IsComposite = true,
                Price = 0
            };
        }

        public ComputerBuilder AddCPU(string cpuName, decimal price)
        {
            _product.Name += $" - {cpuName}";
            _product.Price += price;
            return this;
        }

        public ComputerBuilder AddRAM(string ramName, decimal price)
        {
            _product.Name += $" - {ramName}";
            _product.Price += price;
            return this;
        }

        public ComputerBuilder AddGPU(string gpuName, decimal price)
        {
            _product.Name += $" - {gpuName}";
            _product.Price += price;
            return this;
        }

        public Urun Build()
        {
            return _product;
        }
    }
=======
﻿using tasarimproje.Models;

namespace tasarimproje.Patterns.Creational
{
    public class ComputerBuilder
    {
        private Urun _product;

        public ComputerBuilder()
        {
            _product = new Urun
            {
                Name = "Toplama Bilgisayar",
                IsComposite = true,
                Price = 0
            };
        }

        public ComputerBuilder AddCPU(string cpuName, decimal price)
        {
            _product.Name += $" - {cpuName}";
            _product.Price += price;
            return this;
        }

        public ComputerBuilder AddRAM(string ramName, decimal price)
        {
            _product.Name += $" - {ramName}";
            _product.Price += price;
            return this;
        }

        public ComputerBuilder AddGPU(string gpuName, decimal price)
        {
            _product.Name += $" - {gpuName}";
            _product.Price += price;
            return this;
        }

        public Urun Build()
        {
            return _product;
        }
    }
>>>>>>> a0005938bba87bf4dba2d87124c65b16e14df65d
}