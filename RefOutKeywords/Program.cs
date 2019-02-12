using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutKeywords
{
    class Program
    {
        static void Main(string[] args)
        {
            //Veri tipler degere gore cagrildigi icin,
            //metoda parametre olarak gelen deger
            //metod icinde degistirmek istenecegi zaman Ref-Out anahtar kelimesi kullanilir.

            int deger = 10;
            Console.WriteLine(deger);
            Console.WriteLine("--Ref--");
            RefKullanimi(ref deger);
            Console.WriteLine(deger); //100
            Console.WriteLine("------Out---------");
            int deger2;
            OutKullanimi(out deger2);
            Console.WriteLine(deger2);    
        }
        public static void RefKullanimi(ref int arg)
        {
            arg = 100;
        }
        public static void OutKullanimi(out int arg)
        {
            arg = 2;
        }
    }
}
