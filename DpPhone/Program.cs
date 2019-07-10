using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DpPhone
{
    class Program
    {
        static void Main(string[] args)
        {
            Samsung samsung = new Samsung();
            Nokia nokia = new Nokia();

            Console.WriteLine(samsung.Accumulator());
            Console.WriteLine(samsung.Display());

            Console.WriteLine(nokia.Accumulator());
            Console.WriteLine(nokia.Display());
        }
    }
     public interface IPhone
    {
        string Display();
        string Accumulator();
    }

    public interface Accumulator
    {
        string AccumulatorInfo();
    }

    public interface Display
    {
        string DisplayInfo();
    }

    public class Samsung : IPhone
    {
        public string Accumulator()
        {
            /////
            return "Samsung Accumulator";
        }

        public string Display() 
        {
            /////
            return "Samsung Display";
        }
    }

    public class Nokia : IPhone
    {
        public string Accumulator()
        {
            /////
            return "Nokia Accumulator";
        }

        public string Display()
        {
            /////
            return "Nokia Display";
        }
    }
}
