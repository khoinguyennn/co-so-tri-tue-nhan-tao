using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCBFS_Alg
{
    class Program
    {
        static void Main(string[] args)
        {
            Dothi dt = new Dothi();
            dt.readDothi();
            dt.printDothi();

            LCBFSAlg alg = new LCBFSAlg();
            alg.LCBFSsearch();
            System.Console.WriteLine("In duong di: ");
            alg.printDuongdi();
            alg.printG();
            Console.ReadLine();
        }
    }
}
