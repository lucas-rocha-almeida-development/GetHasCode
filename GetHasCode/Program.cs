using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GetHasCode.Entitites;

namespace GetHasCode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Client a = new Client { Name = "Lucas", Email = "lucalmr@gmail.com" };
            Client b = new Client { Name = "Lucas", Email = "lucalmr@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
         

        }
    }
}
