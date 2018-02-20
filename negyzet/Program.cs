using negyszogek;
using negyzet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negyszogek    
{
    class Program
    {
        static void Main(string[] args)
        {
            Negyszog negyszog1 = new Negyszog(1, 2, 3, 4);
            Console.WriteLine(negyszog1.Kerulet);

            Teglalap teglalap1 = new Teglalap(2,3);
            teglalap1.A = 1;

            Negyzet negyzet1 = new Negyzet(5);
            Console.WriteLine(negyzet1.Kerulet);


            List<Negyszog> negyszogek = new List<Negyszog>();
            negyszogek.Add(negyszog1);
            negyszogek.Add(teglalap1);
            negyszogek.Add(negyzet1);

            int hossz = 0;
            foreach (var elem in negyszogek)
            {
                hossz += elem.Kerulet;

            }
            Console.WriteLine("Összesen {0} fonalra van szükség", hossz);











            Console.ReadKey();
        }
    }
}
