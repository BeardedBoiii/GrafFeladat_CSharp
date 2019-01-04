using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafFeladat_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var graf = new Graf(6);


            graf.Hozzaad(0, 1);
            graf.Hozzaad(1, 2);
            graf.Hozzaad(0, 2);
            graf.Hozzaad(2, 3);
            graf.Hozzaad(3, 4);
            graf.Hozzaad(4, 5);
            graf.Hozzaad(2, 4);

            Console.WriteLine(graf);
            Console.WriteLine("Szélesség Bejárasa 0. kezdőponttól");
            graf.SzelessegiBejar(0);
            Console.WriteLine("Mélyeségi Bejárasa 0. kezdőponttól");
            graf.MelysegiBejar(0);
            Console.WriteLine("Összefüggő-e a gráf: {0}", graf.osszefuggo());
            var feszitofa = graf.FeszitoFa();
            Console.WriteLine(feszitofa);


            Console.ReadLine();


        }


    }
}
