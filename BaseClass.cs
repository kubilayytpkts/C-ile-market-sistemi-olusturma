using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class BaseClass
    {
        public BaseClass()
        {
            _id = sayaç;
            sayaç = sayaç++;
        }
        private int _id;
        public int id 
        {
            get
            {
                return _id;
            }
            private set
            {

            }
                }
        public string barkod 
        {
            get
            {
                return _barkod;
            }
                set
            {
                bool kontrolişlem = sanalDatabase.BarkodKontrol(value);
                {
                    if(!kontrolişlem)
                    {
                        _barkod = value;
                    }
                    else
                    {
                        Console.WriteLine("Bu değer sistemde bulunmaktadır lütfen tekrar giriniz..");
                    }
                }
                

            }
                }
        public DateTime OluşturmaTarih { get; set; }
        public string oluşturanKullanıcı { get; set; }
        public DateTime Güncellemetarih { get; set; }
        public bool silindi { get; set; }
        static private int sayaç = 0;
        private string _barkod;
    }
}
