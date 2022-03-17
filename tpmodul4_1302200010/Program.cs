using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302200010
{
    class HaloGeneric
    {
        public static void SapaUser<T>(T X)
        {
            Console.WriteLine("Halo user " + X);
        }
    }
    class DataGeneric
    {
        static void dataGeneric<T>(T data)
        {
            Console.Write(data);
        }
        public static void printData()
        {
            Console.Write("Data yang tersimpan adalah: ");
            dataGeneric<int>(1302200010);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric.SapaUser<String>("Asyraf");
            DataGeneric.printData();
            Console.ReadKey();
        }
    }
}
