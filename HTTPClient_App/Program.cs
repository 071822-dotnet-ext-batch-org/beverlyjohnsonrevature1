using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyApplication
{
    class Program
    {
        HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            Program program = new Program();
            await program.ChuckNorrisRandom();

        }         

        private async Task ChuckNorrisRandom()
        {
            string response = await client.GetStringAsync(
                "http://api.icndb.com/jokes/random/3?firstName=Mark&lastName=Moore");//returns three random jokes and replaces name with "Mark Moore"
                //http://api.icndb.com/jokes/15?firstName=John&lastName=Doe");// returns joke #15 and uses name John Doe

            Console.WriteLine(response);
        }
    }                       
}