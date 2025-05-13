using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCS
{
    class Program
    {
        static void Main(string[] args)
        {

             Dothi dt = new Dothi();
             dt.readDothi();
             dt.printDothi();
             UCSAlg ucs = new UCSAlg();
             ucs.UCS_Search();
             ucs.printDuongdi();            
             Console.ReadLine();

        }
    }
}
