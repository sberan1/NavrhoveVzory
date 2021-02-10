using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NavrhoveVzoryUkol.Interface;
using NavrhoveVzoryUkol.Model;

namespace NavrhoveVzoryUkol.ViewModel
{

    class ClovekUlozeni
    {
        DBClovek db = new DBClovek();
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());

        }
        public ClovekUlozeni()
        {

        }
        public void ulozitDoDB(Clovek Clovek)
        {
            bool funguje;
            while (funguje = true)
            {
                string klic = RandomString(7);
                if (!db.dbClovek.ContainsKey(klic))
                {
                    db.dbClovek.Add(klic, Clovek);
                    funguje = false;
                }
                else
                {

                }
            }    
        }
    }
}
