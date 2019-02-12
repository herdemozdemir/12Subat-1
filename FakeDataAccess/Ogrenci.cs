using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//MODEL.. POCO objects (POCO nesneleri) - Plain Old CLR objects
namespace FakeDataAccess
{
    public class Ogrenci
    {
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public int Sira { get; set; }
    }
}
