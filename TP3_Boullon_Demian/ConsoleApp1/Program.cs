using ClasesInstanciables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Profesor profesor = new Profesor();
            Profesor p2 = new Profesor();
            Profesor p3 = new Profesor();

            Console.WriteLine("1= {0}\n2={1}\n3={2}", (profesor._clasesDelDia.Dequeue()).ToString(),p2._clasesDelDia.Dequeue().ToString(),p3._clasesDelDia.Dequeue().ToString());
            Console.WriteLine("1= {0}\n2={1}\n3={2}", (profesor._clasesDelDia.Dequeue()).ToString(), p2._clasesDelDia.Dequeue().ToString(), p3._clasesDelDia.Dequeue().ToString());
            Console.ReadKey();
        }
    }
}
