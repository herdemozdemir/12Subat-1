using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoleksiyonLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ogrenci> ogrenciListesi = new List<Ogrenci>();
            Ogrenci ornek = new Ogrenci()
            { OgrenciAdi = "Firat", Sira = 7, OgrenciSoyadi = "Oz" };
            ogrenciListesi.Add(ornek);

            ogrenciListesi.Add(new Ogrenci() { OgrenciAdi = "Ender", OgrenciSoyadi = "Kader", Sira = 2 });

            ogrenciListesi.Add(new Ogrenci() { OgrenciAdi = "Leo", OgrenciSoyadi = "Ozturk", Sira = 3 });

            ogrenciListesi.Add(new Ogrenci() { OgrenciAdi = "Merve", OgrenciSoyadi = "Ozer", Sira = 4 });

            ogrenciListesi.Add(new Ogrenci() { OgrenciAdi = "Tugce", OgrenciSoyadi = "Kokcu", Sira = 5 });

            ogrenciListesi.Add(new Ogrenci() { OgrenciAdi = "Ziya", OgrenciSoyadi = "Cetin", Sira = 8 });

            ogrenciListesi.Add(new Ogrenci() { OgrenciAdi = "Ali", OgrenciSoyadi = "Guven", Sira = 6 });

            ogrenciListesi.Add(new Ogrenci() { OgrenciAdi = "Ercan", OgrenciSoyadi = "Tamer", Sira = 7 });
            ogrenciListesi.Add(new Ogrenci() { OgrenciAdi = "Ali", OgrenciSoyadi = "Temel", Sira = 7 });
            ogrenciListesi.Add(new Ogrenci() { OgrenciAdi = "Veli", OgrenciSoyadi = "Tekin", Sira = 7 });


            //Bul Metodu.
            //First, FirstOrDefault Extensin Methods, eklenti metodlari.
            //First ilk esleseni bulur.
            Ogrenci sonuc = ogrenciListesi.First(x => x.Sira == 7);
            Console.WriteLine("BulunanOgrenci");
            Console.WriteLine("OgrenciAdi=" + sonuc.OgrenciAdi);
            Console.WriteLine("OgrenciSoyadi=" + sonuc.OgrenciSoyadi);
            Console.WriteLine("OgrenciSira=" + sonuc.Sira);

            //Sorgu
            Console.WriteLine("--Eleman Yoksa--");
            //Ogrenci sonuc2 = ogrenciListesi.First(x => x.Sira == 10);
            //First metodu aranan elemani bulamazsa hata dondurur.

            Ogrenci sonuc2 = ogrenciListesi.FirstOrDefault(x => x.Sira == 10);
            if (sonuc2 == null)
                Console.WriteLine("Eleman yok");
            else
                Console.WriteLine(sonuc2.OgrenciAdi + " " + sonuc2.OgrenciSoyadi);
            Console.WriteLine("-----Sorting-----");
            var sortAscList = ogrenciListesi.OrderBy(x => x.Sira);
            foreach (var item in sortAscList)
            {
                Console.WriteLine(item.Sira + " " + item.OgrenciAdi+ " "+ item.OgrenciSoyadi);    
            }

            Console.WriteLine("-------Single------------");
            //var single= ogrenciListesi.Single(x => x.Sira == 7);
            //Console.WriteLine(single.Sira+ " " +single.OgrenciAdi+" "+single.OgrenciSoyadi);
            //Kesin olan listenin birden fazla ayni kayidi tutmadigini bildigimizde Single kullaniriz.
            //Ama First birden fazla kayit varsa, ilk bulunani getirecek.
            var single = ogrenciListesi.SingleOrDefault(x => x.Sira == 6);
            if(single==null)
                Console.WriteLine("Kayit bulundu");
            else
                Console.WriteLine(single.Sira+" "+single.OgrenciAdi+ " "+single.OgrenciSoyadi);

            Console.WriteLine("---------where------------");
            var filter = ogrenciListesi.Where(x => x.Sira == 7);
            foreach (var item in filter)
            {
                Console.WriteLine(item.OgrenciAdi);
            }
            Console.WriteLine("-------------");
            var tFiltre = ogrenciListesi.Where(x => x.Sira == 7).Where(x => x.OgrenciSoyadi.StartsWith("Te"));
            foreach (var item in tFiltre)
            {
                Console.WriteLine(item.OgrenciAdi+" "+item.OgrenciSoyadi);
            }

            Console.WriteLine("------ToUpper------");
            //buyuk harfle yazsin.
            var buyukHarfFiltre=ogrenciListesi.Where(x => x.Sira == 7).Select(y => y.OgrenciAdi.ToUpper());
            foreach (var item in buyukHarfFiltre)
            {
                Console.WriteLine(item);
            }

            //ref - out.
           
        }
    }
    public class Ogrenci
    {
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public int Sira { get; set; }
    }
}
