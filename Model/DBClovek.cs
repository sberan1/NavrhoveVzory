using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NavrhoveVzoryUkol.Interface;

namespace NavrhoveVzoryUkol.Model
{
    public class DBClovek
    {
        static DBClovek instance = null;
        public Dictionary<string, Clovek> dbClovek;
        public DBClovek()
        {
            dbClovek = new Dictionary<string, Clovek>();
        }
        public static DBClovek ClovekDatabase
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBClovek();
                }

                return instance;
            }
        }
    }
}
