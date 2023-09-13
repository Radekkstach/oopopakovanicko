using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopopakovani13092023
{
    class Zamestnanec
    {
        private string titul;
        private string jmeno;
        private double plat;
        private DateTime datum;
        private double hodnoceni = 0;
        private string pozice;
        private int odpracovaneHodiny;

        public Zamestnanec(string titul,string jmeno, double plat, DateTime datum)
        {
            this.titul = titul;
            this.jmeno = jmeno;
            this.plat = plat;
            this.datum = datum;
        }

        string Jmeno
        {
            get { return jmeno; }
            set
            {
                string[] pomoc = jmeno.Split(' ');

                string jmenicko = pomoc[0];
                string prijmeni = pomoc[1];

                jmenicko.Replace(jmenicko.First(), Convert.ToChar(jmenicko.ToUpper()));
                prijmeni.ToUpper();


                Titul = jmenicko + " " + prijmeni;
            }
        }

        string Titul
        {
            get { return titul; }
            set
            {
                titul.Trim();
                titul.Replace(titul.First(), Convert.ToChar(titul.ToUpper()));
                titul.Insert(titul.Length, ".");

                Titul = titul;
            }
        }

        public double RocniPlat()
        {
            double platZaRok = plat * 12;
            return platZaRok;
        }

        public int PocetMesicu()
        {
            TimeSpan celkemdnu;
            celkemdnu = DateTime.Now - datum;
            return celkemdnu.Days / 30;
        }

        public double CelkovyPlat()
        {
            double celkem;
            celkem = PocetMesicu() * plat;
            return celkem;
        }

        public void ZvysOsobni(int zvyseni)
        {
            hodnoceni += zvyseni;
            if(hodnoceni > 10000)
            {
                pozice = "Vedouci";
            }
        }

        int relaxace = 0;

        public void PridatOdpracovaneHodiny(int x)
        {
            if (odpracovaneHodiny >= 100)
            {
                if (relaxace >= 76)
                {
                    odpracovaneHodiny = 0;
                    relaxace = 0;
                }
            }
            odpracovaneHodiny += x;
            
        }

        public void RelaxujuJakKokot(int x)
        {
            relaxace += x;
        }

        public override string ToString()
        {
            return "" + Titul +" "+ Jmeno +" "+ plat + PocetMesicu() + hodnoceni + RocniPlat() + CelkovyPlat() + odpracovaneHodiny + pozice;
        }
    }
}
