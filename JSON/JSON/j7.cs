using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    class j7
    {
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public IList<string> Roles { get; set; }

        static void Main(string[] args)
        {
            j7 account = new j7
            {
                Email = "janmestar100@gmail.com",
                Active = true,
                CreatedDate = new DateTime(2013, 1, 20, 0, 0, 0, DateTimeKind.Utc),
                Roles = new List<string>
                {
                    "User",
                    "Admin"
                }
            };

            string json = JsonConvert.SerializeObject(account);
            // {"Email":"janmestar100@gmail.com","Active":true,"CreatedDate":"2013-01-20T00:00:00Z","Roles":["User","Admin"]}

            Console.WriteLine(json);
        }
    }
}
