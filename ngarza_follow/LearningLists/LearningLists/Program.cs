using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> customers = new List<string>();
            customers.Add("Kevin");
            customers.Add("Kim");
            customers.Add("Kilter");

            Console.WriteLine(customers.Count);

            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine(customers[1]);
        }
    }
}
