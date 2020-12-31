using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYolum
{
   public class Servis
    {
        public Servis()
        {
            Ogrenciler=new List<Ogrenci>();
        }
        public string ServisSurucu { get; set; }
        public string ServisPlaka { get; set; }
        public string ServisMarka { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }
  

    }
}
