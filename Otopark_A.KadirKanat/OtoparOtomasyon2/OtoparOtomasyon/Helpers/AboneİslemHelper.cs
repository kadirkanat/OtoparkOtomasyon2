using OtoparOtomasyon.Models;
using OtoparOtomasyon.MyModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparOtomasyon.Helpers
{
    public static class AboneİslemHelper
    {
        public static AbonelerModel AboneGetirID(int id)
        {
            using (OtoparkOtomasyonEntities db=new OtoparkOtomasyonEntities())
            {
                var ab = db.Aboneler.Where(x => x.AboneID == id).FirstOrDefault();

                AbonelerModel abone = new AbonelerModel();

                abone.AboneID = ab.AboneID;
                abone.TC = ab.TC;
                abone.Ad = ab.Ad;
                abone.Soyad = ab.Soyad;
                abone.Telefon = ab.Telefon;
                abone.Email = ab.Email;
                abone.AracTipiID = ab.AracTipiID;
                abone.AbonelikDurumu = ab.AbonelikDurumu;
                abone.PlakaNo = ab.PlakaNo;

                return abone;




            }
        }

        public static bool AboneVarMI(int id)
        {
            using (OtoparkOtomasyonEntities db = new OtoparkOtomasyonEntities())
            {
                var abone = db.Aboneler.Where(x => x.AboneID == id).FirstOrDefault();

                if (abone==null)
                {
                    return false;

                }
                else
                {
                    return true;
                }

            }

            
        }

        public static AbonelerModel AboneKayıt(Aboneler a)
        {
            using (OtoparkOtomasyonEntities db = new OtoparkOtomasyonEntities())
            {
                var k = db.Aboneler.Add(a);
                db.SaveChanges();
                AbonelerModel ab = new AbonelerModel();
                ab.AboneID = k.AboneID;
                ab.TC = k.TC;
                ab.Ad = k.Ad;
                ab.Soyad = k.Soyad;
                ab.Telefon = k.Telefon;
                ab.Email = k.Email;
                ab.PlakaNo = k.PlakaNo;
                ab.AracTipiID = k.AracTipiID;
                ab.AbonelikDurumu = k.AbonelikDurumu;




                return ab;
            }

        }
        public static bool MusteriAptade(Aboneler a)
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

        public static List<AbonelerModel> AboneleriGetir()
        {
            using (OtoparkOtomasyonEntities db = new OtoparkOtomasyonEntities())
            {

                List<AbonelerModel> abonelermodel = new List<AbonelerModel>();
                var a = db.Aboneler.ToList();
                foreach (Aboneler item in a)
                {
                    AbonelerModel ab = new AbonelerModel();
                    ab.AboneID = item.AboneID;
                    ab.Ad = item.Ad;
                    ab.Soyad = item.Soyad;
                    ab.TC = item.TC;
                    ab.PlakaNo = item.PlakaNo;
                    ab.Telefon = item.Telefon;
                    ab.Email = item.Email;
                    ab.AbonelikDurumu = item.AbonelikDurumu;
                    ab.AracTipiID = item.AracTipiID;
                    abonelermodel.Add(ab);

                }
                return abonelermodel;


            }
        }
    }

}
