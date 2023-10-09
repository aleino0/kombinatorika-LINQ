using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kombinatorika_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] brojevi = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            var query =
                from br1 in brojevi
                from br2 in brojevi
                where br2 != br1
                   && (br1 * 10 + br2) % 2 == 0
                from br3 in brojevi
                where br3 != br2 && br3 != br1
                   && (br1 * 100 + br2 * 10 + br3) % 3 == 0
                from br4 in brojevi
                where br4 != br3 && br4 != br2 && br4 != br1
                   && (br1 * 1000 + br2 * 100 + br3 * 10 + br4) % 4 == 0
                from br5 in brojevi
                where br5 != br4 && br5 != br3 && br5 != br2 && br5 != br1
                   && (br1 * 10000 + br2 * 1000 + br3 * 100 + br4 * 10 + br5) % 5 == 0
                from br6 in brojevi
                where br6 != br5 && br6 != br4 && br6 != br3 && br6 != br2 && br6 != br1
                   && (br1 * 100000 + br2 * 10000 + br3 * 1000 + br4 * 100 + br5 * 10 + br6) % 6 == 0
                from br7 in brojevi
                where br7 != br6 && br7 != br5 && br7 != br4 && br7 != br3 && br7 != br2 && br7 != br1
                   && (br1 * 1000000 + br2 * 100000 + br3 * 10000 + br4 * 1000 + br5 * 100 + br6 * 10 + br7) % 7 == 0
                from br8 in brojevi
                where br8 != br7 && br8 != br6 && br8 != br5 && br8 != br4 && br8 != br3 && br8 != br2 && br8 != br1
                   && (br1 * 10000000 + br2 * 1000000 + br3 * 100000 + br4 * 10000 +
                       br5 * 1000 + br6 * 100 + br7 * 10 + br8) % 8 == 0
                from br9 in brojevi
                where br9 != br8 && br9 != br7 && br9 != br6 && br9 != br5 && br9 != br4 && br9 != br3 && br9 != br2 && br9 != br1
                let broj = br1 * 100000000 +
                             br2 * 10000000 +
                             br3 * 1000000 +
                             br4 * 100000 +
                             br5 * 10000 +
                             br6 * 1000 +
                             br7 * 100 +
                             br8 * 10 +
                             br9 * 1
                where broj % 9 == 0
                select broj;

            foreach (int n in query)
                Console.WriteLine(n);

            Console.ReadKey();
        }
    }
}
