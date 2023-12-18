using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayerFramework
{
    public class EntityOgrenci
    {
        private string ad;
        public string Ad { get => ad; set => ad = value; }
        private string soyad;
        public string Soyad { get => soyad; set => soyad = value; }
        private int id;
        public int Id { get => id; set => id = value; }
        private string numara;
        public string Numara { get => numara; set => numara = value; }
        private string fotograf;
        public string Fotograf { get => fotograf; set => fotograf = value; }
        private double bakiye;
        public double Bakiye { get => bakiye; set => bakiye = value; }
        private string sifre;
        public string Sifre { get => sifre; set => sifre = value; }
    }
}
