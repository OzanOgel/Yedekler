using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İrbami
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string isim = "Hello World";
            //Console.WriteLine(isim);

            //int iboint = 8 + 5;
            //Console.WriteLine(iboint);
            //int sayi1 = 2;
            //int sayi2 = 9;
            //double sayi3 = 2.3;
            //Console.WriteLine(sayi3);

            bool ibovarmı = true;
            //if(ibovarmı ==false)
            //{

            //    Console.WriteLine("ojsdaojısda");



            //}
            //else
            //{
            //    Console.WriteLine("Yarrak");
            //}


            //int sayi = 0;
            //while (sayi < 10)
            //{

            //    if (sayi % 2 == 0)
            //    {
            //        Console.WriteLine(sayi);
            //    }

            //    sayi = sayi + 1;
            //}

            List<Class1> arabalist = new List<Class1>();

            Class1 a = new Class1();
            a.Marka = "Hyundai";
            a.Model = "Tucson";
            arabalist.Add(a);
            Class1 b = new Class1();
            b.Marka = "Hyundai";
            b.Model = "i20";
            arabalist.Add(b);
            Class1 c = new Class1();
            c.Marka = "tofaş";
            c.Model = "şahin";

            arabalist.Add(c);

            foreach (Class1 i in arabalist)
            {
                if(i.Marka == "Hyundai")
                {
                    Console.WriteLine(i.Marka + " " + i.Model);
                }
                

            }



























        }
    }
}
