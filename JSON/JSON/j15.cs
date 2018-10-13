using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    public class Movie1
    {
        public string Name { get; set; }
        public int Year { get; set; }

        static void Main(string[] args)
        {
            // read file into a string and deserialize JSON to a type
            Movie1 movie1 = JsonConvert.DeserializeObject<Movie1>(File.ReadAllText(@"D:\\C#.NET\\JSON\\movie.json"));

            // deserialize JSON directly from a file
            using (StreamReader file = File.OpenText(@"D:\\C#.NET\\JSON\\movie.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                Movie1 movie2 = (Movie1)serializer.Deserialize(file, typeof(Movie1));
            }
            Console.Read();
        }
    }
}
