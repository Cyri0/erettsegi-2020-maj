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

        public void showMatix() {
            for (int sor = 0; sor < 5; sor++) {
                for (int oszlop = 0; oszlop < 5; oszlop++) {
                
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 4. feladat
            PlayfairKodolo pk = new PlayfairKodolo("kulcstabla.txt");
        }
    }
}
