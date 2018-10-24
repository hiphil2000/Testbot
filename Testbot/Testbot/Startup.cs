using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Testbot
{
    class Startup
    {
        private Startup(string[] args)
        {

        }

        public static async Task RunAsync(string[] args)
        {
            var startup = new Startup(args);
            await startup.RunAsync();
        }

        public async Task RunAsync()
        {

        }
    }
}
