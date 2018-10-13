using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    class j2
    {
        
        public IList<string> Videogames { get; set; }

        static void Main(string[] args)
        {
            List<string> videogames = new List<string>
            {
                "Starcraft",
                "Halo",
                "Legend of Zelda"
            };

            string json = JsonConvert.SerializeObject(videogames);

            Console.WriteLine(json);
            Console.Read();
        }
    }
}
