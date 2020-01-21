using OtoparOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparOtomasyon.MyModels
{
    public class AbonelerModel
    {

        public int AboneID { get; set; }
        public string TC { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string PlakaNo { get; set; }
        public Nullable<int> AracTipiID { get; set; }
        public Nullable<bool> AbonelikDurumu { get; set; }

        public AracTipleri AracTipleri = new AracTipleri();
    }
}
