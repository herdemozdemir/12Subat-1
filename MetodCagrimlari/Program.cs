using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodCagrimlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Normalde c# da referans tipler, (object,string,class)
            //referansa gore cagriliyor.
            Ogrenci nesne = new Ogrenci();
            nesne.Not = 11;
            Ogrenci nesne2 = nesne;
            nesne2.Not = 100;
            Console.WriteLine(nesne.Not); //100
            Metod(nesne);
            Console.WriteLine(nesne.Not); //1
            //Call by Referance. Referensa gore metod cagrimi.

            //Veri tipleri ise (Value Type) int,float,double vs vs.
            //degere gore cagrilir.
            //Nedemek
            int degisken = 100;
            DegereGore(degisken);
            Console.WriteLine(degisken); //100
            //Call by Value
        }
        public static void Metod(Ogrenci ogr)
        {
            Ogrenci temp = ogr;
            temp.Not = 1;
        }

        public static void DegereGore(int arg)
        {
            arg = 1;
        }
    }
    class Ogrenci
    {
        public int Not;   
    }
}
