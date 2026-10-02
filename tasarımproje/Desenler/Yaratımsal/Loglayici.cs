<<<<<<< HEAD
﻿using System;
using System.IO;

namespace tasarimproje.Patterns.Creational
{
    public sealed class Loglayici // Miras alınmasını engeller
    {
        private static Loglayici _instance;
        private static readonly object _lock = new object();

        // Dışarıdan "new Logger()" yapılmasını engeller 
        private Loglayici() { }

        public static Loglayici Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Loglayici();
                    }
                    return _instance;
                }
            }
        }

        public void Log(string message)
        {
            string logEntry = $"{DateTime.Now}: {message}";
            // Proje klasöründeki log.txt dosyasına yazar
            File.AppendAllText("log.txt", logEntry + Environment.NewLine);
        }
    }
=======
﻿using System;
using System.IO;

namespace tasarimproje.Patterns.Creational
{
    public sealed class Loglayici // Miras alınmasını engeller
    {
        private static Loglayici _instance;
        private static readonly object _lock = new object();

        // Dışarıdan "new Logger()" yapılmasını engeller 
        private Loglayici() { }

        public static Loglayici Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Loglayici();
                    }
                    return _instance;
                }
            }
        }

        public void Log(string message)
        {
            string logEntry = $"{DateTime.Now}: {message}";
            // Proje klasöründeki log.txt dosyasına yazar
            File.AppendAllText("log.txt", logEntry + Environment.NewLine);
        }
    }
>>>>>>> a0005938bba87bf4dba2d87124c65b16e14df65d
}