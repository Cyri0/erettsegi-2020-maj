using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. feladat
namespace playfair_2
{
    // 2. feladat
    class PlayfairKodolo {

        private static char[,] matrix = new char[5, 5];

        // 3. feladat
        public PlayfairKodolo(string forras) {
            StreamReader sr = new StreamReader(forras);
            for (int sor = 0; sor < 5; sor++) {
                string beolvasott_sor = sr.ReadLine();
                for (int oszlop = 0; oszlop < 5; oszlop++)
                {
                    char betu = beolvasott_sor[oszlop];
                    matrix[sor, oszlop] = betu;
                }
            }
        }

        // 5. feladat
        public int sorIndex(char betu) {
            for (int sor = 0; sor < 5; sor++) {
                for (int oszlop = 0; oszlop < 5; oszlop++) {
                    if (betu == matrix[sor, oszlop])
                        return sor;
                }
            }
            return -1;
        }

        // 5. feladat
        public int oszlopIndex(char betu)
        {
            for (int sor = 0; sor < 5; sor++)
            {
                for (int oszlop = 0; oszlop < 5; oszlop++)
                {
                    if (betu == matrix[sor, oszlop])
                        return oszlop;
                }
            }
            return -1;
        }

        public string KodolBetupar(string eredeti) {
            char kar1 = eredeti[0];
            char kar2 = eredeti[1];

            if (this.sorIndex(kar1) == this.sorIndex(kar2)) {
                // egy sorban vannak

                // TO BE CONTINUE

                //int kar1_o = this.oszlopIndex(kar1);
                //int kar2_o = this.oszlopIndex(kar2);
                
                //if (kar1_o != 4) {
                    
                //}
            }
            if (this.oszlopIndex(kar1) == this.oszlopIndex(kar2)) {
            // egy oszlopban vannak
            }

            // a harmadik szabály érvényes


            return "alma";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 4. feladat
            PlayfairKodolo pk = new PlayfairKodolo("kulcstabla.txt");
            // 6. feladat
            Console.Write("6. feladat - Kérek egy nagybetűt: ");
            char valasztott_betu = Console.ReadLine()[0];
            Console.WriteLine("A karakter sorának az indexe: " + pk.sorIndex(valasztott_betu));
            Console.WriteLine("A karakter oszlopának az indexe: " + pk.oszlopIndex(valasztott_betu));
            Console.ReadKey();
        }
    }
}
