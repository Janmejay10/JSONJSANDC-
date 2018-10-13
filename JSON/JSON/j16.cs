using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    public class j16
    {
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<string> Roles { get; set; }

        static void Main(string[] args)
        {
            Account account = new Account
            {
                Email = "james@example.com",
                Active = true,
                CreatedDate = new DateTime(2013, 1, 20, 0, 0, 0, DateTimeKind.Utc),
                Roles = new List<string>
                {
                    "User",
                    "Admin"
                }
                        };

            string json = @"{
                              'Active': false,
                              'Roles': [
                                'Expired'
                              ]
                            }";

            JsonConvert.PopulateObject(json, account);

            Console.WriteLine(account.Email);
            // james@example.com

            Console.WriteLine(account.Active);
            // false

            Console.WriteLine(string.Join(", ", account.Roles.ToArray()));
            // User, Admin, Expired
            Console.Read();
        }
    }
}
