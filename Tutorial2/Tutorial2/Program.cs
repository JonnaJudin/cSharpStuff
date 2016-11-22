using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial2
{
    class Spoj1
    {
        static void Main(string[] args)
        {
            // Not great programming, but the problem description does not
            // require us to cast them as numbers, just to compare if it's "42"

            string rawInput = "";
            rawInput = Console.ReadLine();
            while (!rawInput.Equals("42"))
            {
                Console.WriteLine("You Typed: {0}", rawInput);
                rawInput=Console.ReadLine();
            };
        }
    }
}
