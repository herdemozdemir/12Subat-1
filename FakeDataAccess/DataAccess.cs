using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDataAccess
{
    public class DataAccess
    {
        List<Ogrenci> ogrenciListesi = new List<Ogrenci>();
        public DataAccess()
        {
            //bir listedeye degerler doldursun
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
        }
        public List<Ogrenci> SelectAll()
        {
            return ogrenciListesi;
        }
        public Ogrenci Sorgula(int id)
        {
            Ogrenci ogr = ogrenciListesi.FirstOrDefault(item => item.Sira == id);
            return ogr;
        }

        public int Update(Ogrenci ogr)
        {
            return 0;
        }

        public int Delete(int id)
        {
            return 0;
        }

        public int Add(Ogrenci ogr)
        {
            ogrenciListesi.Add(ogr);
            return ogr.Sira;
        }
    }
}
