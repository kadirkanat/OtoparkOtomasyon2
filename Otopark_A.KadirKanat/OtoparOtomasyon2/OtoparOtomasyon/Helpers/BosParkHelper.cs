using OtoparOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparOtomasyon.Helpers
{
    class BosParkHelper
    {
        public static ParkYeri ParkBilgiGetirID(int id)
        {
            using (OtoparkOtomasyonEntities db =new OtoparkOtomasyonEntities())
            {
                var parkYeri = db.ParkYeri.Where(x => x.AboneID == id).FirstOrDefault();
                return parkYeri;



            }





        }
        public static bool ParkDurumuGetByAboneID(int AboneID)
        {
            bool durum = false;
            using (OtoparkOtomasyonEntities db = new OtoparkOtomasyonEntities())
            {
                var list = db.ParkYeri.Where(x => x.AboneID == AboneID).ToList();
                foreach (var item in list)
                {
                    if (item.ParkDurumu)
                    {
                        durum = true;
                        break;
                    }
                    else
                    {
                        durum = false;
                        
                    }
                    
                }
                return durum;
            }
        }
        public static bool Bosmu(int ParkYeriID)
        {
            using (OtoparkOtomasyonEntities db = new OtoparkOtomasyonEntities())
            {
                var ParkYeri = db.ParkYeri.Find(ParkYeriID);
                if (ParkYeri.ParkDurumu == false)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool ParkYeriVer(ParkYeri a)
        {
            using (OtoparkOtomasyonEntities db = new OtoparkOtomasyonEntities())
            {
                db.Entry(a).State = System.Data.Entity.EntityState.Modified;
                if (db.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static List<ParkYeri> ParkYeriGetir()
        {
            using (OtoparkOtomasyonEntities db = new OtoparkOtomasyonEntities())
            {

               
                return db.ParkYeri.ToList();

            }



        }
        public static bool ParkYeriUpdate(ParkYeri p)
        {
            using (OtoparkOtomasyonEntities db =new OtoparkOtomasyonEntities())
            {
                db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                if (db.SaveChanges()>0)
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
