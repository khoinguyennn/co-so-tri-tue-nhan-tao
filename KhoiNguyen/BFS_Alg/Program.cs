using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS_Alg
{
    class Program
    {
        static void Main(string[] args)
        {
            Dothi dt = new Dothi();
            dt.readDothi();
            dt.printDothi();

            BFSAlg bFS = new BFSAlg();
            bFS.BFSsearch();
            bFS.printDuongdi();
            Console.ReadLine();
        }
    }
}
