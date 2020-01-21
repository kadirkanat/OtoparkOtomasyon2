using OtoparOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparOtomasyon.MyModels
{
    class KullanıcıHelper
    {
       
        public static bool GirisYap(string KullaniciAdi, string Sifre)
        {
            using (OtoparkOtomasyonEntities db = new OtoparkOtomasyonEntities())
            {
                if (db.Kullanıcı.Any(x => x.KullanıcıAdı.ToLower() == KullaniciAdi.ToLower()&& x.KullanıcıSİfre == Sifre))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
