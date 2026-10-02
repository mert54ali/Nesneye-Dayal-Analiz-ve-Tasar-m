<<<<<<< HEAD
﻿namespace tasarimproje.Interfaces
{
    public interface ISiparisDurumu
    {
        void Next(Models.Siparis order); // Bir sonraki aşamaya geçme
        void Cancel(Models.Siparis order); // Siparişi iptal etme/iade etme
        string GetStatus();
    }
=======
﻿namespace tasarimproje.Interfaces
{
    public interface ISiparisDurumu
    {
        void Next(Models.Siparis order); // Bir sonraki aşamaya geçme
        void Cancel(Models.Siparis order); // Siparişi iptal etme/iade etme
        string GetStatus();
    }
>>>>>>> a0005938bba87bf4dba2d87124c65b16e14df65d
}