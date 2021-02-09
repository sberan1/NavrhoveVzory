using System;
using System.Collections.Generic;
using System.Text;
using NavrhoveVzoryUkol.Model;

namespace NavrhoveVzoryUkol.Model
{
    class Clovek
    {
        NameValidator nameValidator = new NameValidator();
        AgeValidator ageValidator = new AgeValidator();
        RodneCisloValidator rodneCisloValidator = new RodneCisloValidator();

        public Clovek(string jmeno, string prijmeni, DateTime datumNarozeni, string rodneCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            DatumNarozeni = datumNarozeni;
            RodneCislo = rodneCislo;
        }
        public Clovek() { }

        private string jmeno;

        public string Jmeno
        {
            get { return jmeno; }
            set {
                if (nameValidator.IsValid(value))
                {
                    jmeno = value;
                }
                else
                {
                    throw new Exception("Jmeno neni ve spravnem formatu");
                }
            
            }
        }
        private string prijmeni;
        public string Prijmeni
        {
            get { return prijmeni; }
            set
            {
                if (nameValidator.IsValid(value))
                {
                    prijmeni = value;
                }
                else
                {
                    throw new Exception("Prijmeni neni ve spravnem formatu");
                }

            }
        }
        private DateTime datumNarozeni;

        public DateTime DatumNarozeni
        {
            get { return datumNarozeni; }
            set
            {
                if (ageValidator.IsValid(value))
                {
                    datumNarozeni = value;
                }
                else
                {
                    throw new Exception("Datum Narozeni neni ve spravnem formatu");
                }
            }
        }

        private string rodneCislo;

        public string RodneCislo
        {
            get { return rodneCislo; }
            set
            {
                if (rodneCisloValidator.IsValid(value, Convert.ToInt32(datumNarozeni)))
                {
                    rodneCislo = value;
                }
                else
                {
                    throw new Exception("Rodne cislo neni ve spravnem formatu");
                }
            }
        }


    }
}
