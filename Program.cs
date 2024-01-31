using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frazione_con_mcd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FRAZIONE f = new FRAZIONE(24, 12);

            int mcd = f.mcd1();
            int den = f.returnden();
            int num = f.returnnum();


            Console.WriteLine(f.ToString());
            Console.ReadLine();
        }
    }
}
