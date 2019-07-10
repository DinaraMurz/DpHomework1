using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DpHomeWork1
{
    //////////////////////Computer
    class Program
    {
        static void Main(string[] args)
        {
            Dell dell = new Dell();
            Sony sony = new Sony();

            Console.WriteLine(dell.Mainboard());
            Console.WriteLine(dell.Processor());

            Console.WriteLine(sony.Mainboard());
            Console.WriteLine(sony.Processor());
        }
    }
    public interface IComputer
    {
        string Mainboard();
        string Processor();
    }

    public class Dell : IComputer
    {
        public string Mainboard()
        {
            return "Dell Mainboard";
        }

        public string Processor()
        {
            return "Dell Processor";
        }
    }

    public class Sony : IComputer
    {
        public string Mainboard()
        {
            return "Sony Mainboard";
        }

        public string Processor()
        {
            return "Sony Processor";
        }
    }

    ////////////////////////////Car
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Ford ford = new Ford();
    //        Toyota toyota = new Toyota();

    //        Console.WriteLine(ford.Engine());
    //        Console.WriteLine(ford.Boby());

    //        Console.WriteLine(toyota.Engine());
    //        Console.WriteLine(toyota.Boby());
    //    }
    //}
    //public interface ICar
    //{
    //    string Engine();
    //    string Boby();
    //}

    //public class Ford : ICar
    //{
    //    public string Engine()
    //    {
    //        return "Ford Engine";
    //    }

    //    public string Boby()
    //    {
    //        return "Ford Boby";
    //    }
    //}

    //public class Toyota : ICar
    //{
    //    public string Engine()
    //    {
    //        return "Toyota Engine";
    //    }

    //    public string Boby()
    //    {
    //        return "Toyota Boby";
    //    }
    //}

    ////////////////////Phone
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Samsung samsung = new Samsung();
    //        Nokia nokia = new Nokia();

    //        Console.WriteLine(samsung.Accumulator());
    //        Console.WriteLine(samsung.Display());

    //        Console.WriteLine(nokia.Accumulator());
    //        Console.WriteLine(nokia.Display());
    //    }
    //}
    // public interface IPhone
    //{
    //    string Display();
    //    string Accumulator();
    //}


    //public class Samsung : IPhone
    //{
    //    public string Accumulator()
    //    {
    //        return "Samsung Accumulator";
    //    }

    //    public string Display() 
    //    {
    //        return "Samsung Display";
    //    }
    //}

    //public class Nokia : IPhone
    //{
    //    public string Accumulator()
    //    {
    //        return "Nokia Accumulator";
    //    }

    //    public string Display()
    //    {
    //        return "Nokia Display";
    //    }
    //}
}
