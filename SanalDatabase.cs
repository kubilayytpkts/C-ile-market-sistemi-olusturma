using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public static class sanalDatabase
    {
        private static ArrayList Database = new ArrayList();



        public static void yeniUrunEkle(BaseClass data)
        {
            if (data != null && !string.IsNullOrEmpty(data.barkod))
            {
                Database.Add(data);
            }
        }

        public static bool BarkodKontrol (string barkod)
        {
            bool kontrolİşlem = false;
            if(Database!=null && Database.Count>0)
            {
                for(int i=0; i<Database.Count; i++)
                {
                    BaseClass bc = (BaseClass)Database[i];
                    if(bc.barkod==barkod)
                    {
                        kontrolİşlem = true;
                    }
                    
                }
               
            }
            return kontrolİşlem;
        }

    }
}
