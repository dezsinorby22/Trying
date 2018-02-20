using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negyszogek
{
    public class Negyszog
    {
        private int a;
        public int A
        {
            get { return a; }
            set
            {
                if (value > 0) a = value;
            }
        }
        private int b;
        public int B
        {
            get { return b; }
            set
            {
                if (value > 0) b = value;
            }
        }
        private int c;
        public int C
        {
            get { return c; }
            set
            {
                if (value > 0) c = value;
            }
        }
        private int d;
        public int D
        {
            get { return d; }
            set
            {
                if (value > 0) d = value;
            }
        }
        public int Kerulet
        {
            get
            {
                return A + B + C + D;
            }
        }
       

        public Negyszog (int a, int b, int c, int d)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;

        }
        public Negyszog () { }
        
      

    }

}
