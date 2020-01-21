using OtoparOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparOtomasyon.MyModels
{
    class ParkYeriModel
    {
        public int ParkYeriID { get; set; }
        public bool ParkDurumu { get; set; }
        public int AboneID { get; set; }
        public Nullable<System.DateTime> TarihGiriş { get; set; }
        public Nullable<System.DateTime> TarihÇıkış { get; set; }
        public virtual Aboneler Aboneler
        {
            get; set;
        }
    }
}