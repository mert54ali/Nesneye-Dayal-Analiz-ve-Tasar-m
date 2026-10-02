<<<<<<< HEAD
﻿using System;
using tasarimproje.Models;
using tasarimproje.Interfaces;

namespace tasarimproje.Patterns.Behavioral
{
    public class PendingState : ISiparisDurumu //Bekleme
    {
        public void Next(Siparis order) => order.SetState(new ApprovedState());
        public void Cancel(Siparis order) => Console.WriteLine("İptal edildi");
        public string GetStatus() => "Beklemede";
    }

    public class ApprovedState : ISiparisDurumu //Onaylama
    {
        public void Next(Siparis order) => order.SetState(new PreparingState());
        public void Cancel(Siparis order) => Console.WriteLine("İptal edildi");
        public string GetStatus() => "Onaylandı";
    }

    public class PreparingState : ISiparisDurumu //Hazırlanma
    {
        public void Next(Siparis order) => order.SetState(new ShippedState());
        public void Cancel(Siparis order) => Console.WriteLine("İptal edildi");
        public string GetStatus() => "Hazırlanıyor";
    }

    public class ShippedState : ISiparisDurumu //Kargolama
    {
        public void Next(Siparis order) => order.SetState(new DeliveredState());
        public void Cancel(Siparis order) => order.SetState(new ReturnedState());
        public string GetStatus() => "Kargoda";
    }

    public class DeliveredState : ISiparisDurumu //Teslim edilme
    {
        public void Next(Siparis order) { }
        public void Cancel(Siparis order) { }
        public string GetStatus() => "Teslim Edildi";
    }

    public class ReturnedState : ISiparisDurumu //İade
    {
        public void Next(Siparis order) {  }
        public void Cancel(Siparis order) { }
        public string GetStatus() => "İade Edildi";
    }
=======
﻿using System;
using tasarimproje.Models;
using tasarimproje.Interfaces;

namespace tasarimproje.Patterns.Behavioral
{
    public class PendingState : ISiparisDurumu //Bekleme
    {
        public void Next(Siparis order) => order.SetState(new ApprovedState());
        public void Cancel(Siparis order) => Console.WriteLine("İptal edildi");
        public string GetStatus() => "Beklemede";
    }

    public class ApprovedState : ISiparisDurumu //Onaylama
    {
        public void Next(Siparis order) => order.SetState(new PreparingState());
        public void Cancel(Siparis order) => Console.WriteLine("İptal edildi");
        public string GetStatus() => "Onaylandı";
    }

    public class PreparingState : ISiparisDurumu //Hazırlanma
    {
        public void Next(Siparis order) => order.SetState(new ShippedState());
        public void Cancel(Siparis order) => Console.WriteLine("İptal edildi");
        public string GetStatus() => "Hazırlanıyor";
    }

    public class ShippedState : ISiparisDurumu //Kargolama
    {
        public void Next(Siparis order) => order.SetState(new DeliveredState());
        public void Cancel(Siparis order) => order.SetState(new ReturnedState());
        public string GetStatus() => "Kargoda";
    }

    public class DeliveredState : ISiparisDurumu //Teslim edilme
    {
        public void Next(Siparis order) { }
        public void Cancel(Siparis order) { }
        public string GetStatus() => "Teslim Edildi";
    }

    public class ReturnedState : ISiparisDurumu //İade
    {
        public void Next(Siparis order) {  }
        public void Cancel(Siparis order) { }
        public string GetStatus() => "İade Edildi";
    }
>>>>>>> a0005938bba87bf4dba2d87124c65b16e14df65d
}