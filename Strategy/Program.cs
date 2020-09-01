using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();
            Console.WriteLine("Client: Strategy is set to normal sorting.");
            context.Algorithm = new CountingSort();
            context.ExecuteAlgorithm();

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
