using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    class j11
    {
        static void Main(string[] args)
        {
            string json = @"{
                              'href': '/account/login.aspx',
                              'target': '_blank'
                            }";

            Dictionary<string, string> htmlAttributes = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            Console.WriteLine(htmlAttributes["href"]);
            // /account/login.aspx

            Console.WriteLine(htmlAttributes["target"]);
            Console.Read();
            // _blank
        }
    }
}
