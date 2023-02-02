using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar B1 = new Bilgisayar();
            B1.Alışfiyat = 1000M;
            B1.satışfiyat = 1500M;
            B1.barkod = "12345929";
            B1.ram = "4Gb";
            B1.oluşturanKullanıcı = "Kubilay Topaktaş";
            B1.marka = "Lenova";
            B1.KampanyFiyat = 500M;
            B1.OluşturmaTarih = DateTime.Now;
            
        }
    }
}
