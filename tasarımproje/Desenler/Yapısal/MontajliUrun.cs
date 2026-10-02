<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;

namespace tasarimproje.Patterns.Structural
{
    //  COMPONENT
    public interface IProductComponent
    {
        decimal GetPrice();
        string GetName();
    }

    // Tekil Ürün
    public class SingleProduct : IProductComponent
    {
        private string _name;
        private decimal _price;

        public SingleProduct(string name, decimal price)
        {
            _name = name;
            _price = price;
        }

        public decimal GetPrice() => _price;
        public string GetName() => _name;
    }

    //  Montajlı Ürün)
    public class ProductBundle : IProductComponent
    {
        private string _bundleName;
        // Kasanın içindeki parçaları tutacağımız liste
        private List<IProductComponent> _components = new List<IProductComponent>();

        public ProductBundle(string bundleName)
        {
            _bundleName = bundleName;
        }

        //Kasaya yeni parça ekleme metodu
        public void AddProduct(IProductComponent component)
        {
            _components.Add(component);
        }

        public string GetName() => _bundleName;

        // Kasanın fiyatı sorulduğunda içindeki tüm parçaların fiyatını toplar
        public decimal GetPrice()
        {
            decimal total = 0;
            foreach (var item in _components)
            {
                total += item.GetPrice();
            }
            return total;
        }
    }
=======
﻿using System;
using System.Collections.Generic;

namespace tasarimproje.Patterns.Structural
{
    //  COMPONENT
    public interface IProductComponent
    {
        decimal GetPrice();
        string GetName();
    }

    // Tekil Ürün
    public class SingleProduct : IProductComponent
    {
        private string _name;
        private decimal _price;

        public SingleProduct(string name, decimal price)
        {
            _name = name;
            _price = price;
        }

        public decimal GetPrice() => _price;
        public string GetName() => _name;
    }

    //  Montajlı Ürün)
    public class ProductBundle : IProductComponent
    {
        private string _bundleName;
        // Kasanın içindeki parçaları tutacağımız liste
        private List<IProductComponent> _components = new List<IProductComponent>();

        public ProductBundle(string bundleName)
        {
            _bundleName = bundleName;
        }

        //Kasaya yeni parça ekleme metodu
        public void AddProduct(IProductComponent component)
        {
            _components.Add(component);
        }

        public string GetName() => _bundleName;

        // Kasanın fiyatı sorulduğunda içindeki tüm parçaların fiyatını toplar
        public decimal GetPrice()
        {
            decimal total = 0;
            foreach (var item in _components)
            {
                total += item.GetPrice();
            }
            return total;
        }
    }
>>>>>>> a0005938bba87bf4dba2d87124c65b16e14df65d
}