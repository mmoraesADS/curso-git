using System;
using System.Globalization;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;

namespace Course {
    class Program {
        static void Main(string[] args) {
            DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d2 = DateTime.ParseExact("15/08/2020 13:10:25", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime d3 = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            DateTime d4 = d3.AddHours(5.47);


            TimeSpan t1 = TimeSpan.FromDays(1.5);


            Console.WriteLine(t1);
            Console.WriteLine(d3);
            Console.WriteLine(d3.Date);
            Console.WriteLine(d3.Day);
            Console.WriteLine(d3.ToLongDateString());
            Console.WriteLine(d3.ToLongTimeString());
            Console.WriteLine(d3.ToShortDateString());
            Console.WriteLine(d3.ToShortTimeString());
            Console.WriteLine(d3.ToString());
            Console.WriteLine(d3.ToString("dd/MM/yyyy"));
            Console.WriteLine(d4);
        }

    }
}