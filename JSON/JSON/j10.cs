using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    class j10
    {
        static void Main(string[] args)
        {
            string json = @"['Starcraft','Halo','Legend of Zelda']";

            List<string> videogames = JsonConvert.DeserializeObject<List<string>>(json);

            Console.WriteLine(string.Join(", ", videogames.ToArray()));
            Console.Read();
        }
    }
}
