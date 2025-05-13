using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCS
{
    class Element
    {
        private int tendinh;
        private int g;
        private int pre;

        public int Tendinh
        {
            get
            {
                return tendinh;
            }

            set
            {
                tendinh = value;
            }
        }

        public int G
        {
            get
            {
                return g;
            }

            set
            {
                g = value;
            }
        }

        public int Pre
        {
            get
            {
                return pre;
            }

            set
            {
                pre = value;
            }
        }

        public Element()
        {
            Tendinh = -1;
            G = 0;
            Pre = -2;
        }

        public Element(int dinh, int cp, int dt)
        {
            Tendinh = dinh;
            G = cp;
            Pre = dt;
        }

        public void printElmt()
        {
            Console.Write("\n ({0}, {1}, {2}", Tendinh, G, Pre);
        }
    }
}
