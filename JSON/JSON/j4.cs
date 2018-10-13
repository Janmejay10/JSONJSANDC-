using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JSON
{
    class j4
    {
        static void Main(string[] args)
        {
            List<StringComparison> stringComparisons = new List<StringComparison>
            {
                StringComparison.CurrentCulture,
                StringComparison.Ordinal
            };

            string jsonWithoutConverter = JsonConvert.SerializeObject(stringComparisons);

            Console.WriteLine(jsonWithoutConverter);
            // [0,4]

            string jsonWithConverter = JsonConvert.SerializeObject(stringComparisons, new StringEnumConverter());

            Console.WriteLine(jsonWithConverter);
            // ["CurrentCulture","Ordinal"]

            List<StringComparison> newStringComparsions = JsonConvert.DeserializeObject<List<StringComparison>>(
                jsonWithConverter,
                new StringEnumConverter());

            Console.WriteLine(string.Join(", ", newStringComparsions.Select(c => c.ToString()).ToArray()));
            // CurrentCulture, Ordinal

            Console.Read();
        }
    }
}
