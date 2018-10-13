using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    public class Website
    {
        public string Url { get; set; }

        public Website()
        {
          //  this.Url = Url;
        }

        public Website(Website website)
        {
            if (website == null)
            {
                throw new ArgumentNullException(nameof(website));
            }

            Url = website.Url;
        }

        static void Main(string[] args)
        {
            string json = @"{'Url':'http://www.google.com'}";

            try
            {
                JsonConvert.DeserializeObject<Website>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Value cannot be null.
                // Parameter name: website
            }

            Website website = JsonConvert.DeserializeObject<Website>(json, new JsonSerializerSettings
            {
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
            });

            Console.WriteLine(website.Url);
            Console.Read();
            // http://www.google.com
        }
    }
}
