using System;
using System.Threading.Tasks;

namespace Testbot
{
    class Program
    {

        //public static Task Main(string[] args)
        //    => 

        public static async Task Main(string[] args)
        {
            await Startup.RunAsync(args);
        }
            
    }
}
