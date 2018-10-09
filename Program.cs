using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //LINQ (language integrated Query)
            UrunContext context = new UrunContext();

            List<Urun> urunler = new List<Urun>()
            {
                new Urun(){ UrunAdi = "Huaweı Mate 10", Fiyat=3000, StokAdeti=3232 },
                new Urun(){ UrunAdi = "Huaweı Mate 9", Fiyat=3000, StokAdeti=3232 },
                new Urun(){ UrunAdi = "Huaweı Mate 8", Fiyat=3000, StokAdeti=3232 },
                new Urun(){ UrunAdi = "Huaweı Mate 7", Fiyat=3000, StokAdeti=3232 },
                new Urun(){ UrunAdi = "Huaweı Mate 6", Fiyat=3000, StokAdeti=3232 },

            };

            foreach(var urun in urunler)
            {
                context.Urunler.Add(urun); 
            }

            context.SaveChanges();
            Console.WriteLine("Kayıt edildi.");
            Console.ReadLine();

                
           



        }
    }
}
