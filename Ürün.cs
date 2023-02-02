using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Ürün:BaseClass
    {
        public string marka { get; set; }
        public string model { get; set; }
        public Decimal Alışfiyat 
        { get 
            {
                return _Alışfiyat;
            }
            set
            {
                if(value<0)
                {
                    Console.WriteLine("Alış Fiyatı 0'Dan küçük olamaz");
                }
                else
                {
                    value = _Alışfiyat;
                }
            }
                }
        public Decimal satışfiyat 
        {
            get
            {
                return _SatışFiyat;
            }
                set
            {
                if(value<_Alışfiyat)
                {
                    Console.WriteLine("Satış Fiyatı,alış fiyatından küçük olamaz...");
                }
                else
                {
                    value = _SatışFiyat;
                }
            }
                }

        public Decimal KampanyFiyat
        {
            get
            {
                return _KampanyaFiyat;
            }
            set
            {
                if(value<0)
                {
                    Console.WriteLine("Kampanya Fiyatı 0 dan küçük olamaz...");
                }
                else
                {
                    value = _KampanyaFiyat;
                }
            }
                }

        private decimal _Alışfiyat;

        private decimal _SatışFiyat;

        private decimal _KampanyaFiyat;

    }
}
