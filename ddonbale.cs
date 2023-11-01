using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace donbale_mosalasaty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lotfan adad ra benevisid ta mohasebeh konam");
            string ADAD=Console.ReadLine();
            int n=Convert.ToInt32(ADAD);
            int donbaleh = (n*(n + 1)) / 2;
            Console.WriteLine(donbaleh);
        }
    }
}
