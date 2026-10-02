<<<<<<< HEAD
﻿public interface IKargoStratejisi
{
    // Her kargo firması kendi fiyatını hesaplayacak
    decimal CalculateFee(decimal weight, decimal amount);

    // Her kargo firması kendi formatında takip no üretecek
    string GenerateTrackingNumber();
=======
﻿public interface IKargoStratejisi
{
    // Her kargo firması kendi fiyatını hesaplayacak
    decimal CalculateFee(decimal weight, decimal amount);

    // Her kargo firması kendi formatında takip no üretecek
    string GenerateTrackingNumber();
>>>>>>> a0005938bba87bf4dba2d87124c65b16e14df65d
}