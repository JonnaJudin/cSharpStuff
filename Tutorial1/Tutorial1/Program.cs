using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1){
                Console.WriteLine("Usage: {0} <1> [2] .. [n] ", System.AppDomain.CurrentDomain.FriendlyName);
                Console.WriteLine("Prints out argument(s) 1(..n)");
            }
            else {
                Console.WriteLine("You gave {0} argument(s):",args.Length);
                for(int i = 0; i < args.Length; i++){
                    Console.WriteLine("Argument {0}: {1}",i+1,args[i]);
                };
            };
        }
    }
}
