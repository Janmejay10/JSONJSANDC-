using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    public class Movie
    {
        public string Name { get; set; }
        public int Year { get; set; }

        static void Main(string[] args)
        {
            Movie movie = new Movie
            {
                Name = "Bad Boys",
                Year = 1995
            };

            // serialize JSON to a string and then write string to a file
            File.WriteAllText(@"D:\\C#.NET\\JSON\\json.txt", JsonConvert.SerializeObject(movie));

            // serialize JSON directly to a file
            using (StreamWriter file = File.CreateText(@"D:\\C#.NET\\JSON\\movie.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, movie);
            }
        }
    }
}

