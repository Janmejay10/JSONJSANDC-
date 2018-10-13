using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    public class Employee
    {
        public string Name { get; set; }
        public Employee Manager { get; set; }

        public bool ShouldSerializeManager()
        {
            // don't serialize the Manager property if an employee is their own manager
            return (Manager != this);
        }

        static void Main(string[] args)
        {
            Employee joe = new Employee();
            joe.Name = "Joe Employee";
            Employee mike = new Employee();
            mike.Name = "Mike Manager";

            joe.Manager = mike;

            // mike is his own manager
            // ShouldSerialize will skip this property
            mike.Manager = mike;

            string json = JsonConvert.SerializeObject(new[] { joe, mike }, Formatting.Indented);

            Console.WriteLine(json);
            Console.Read();
            // [
            //   {
            //     "Name": "Joe Employee",
            //     "Manager": {
            //       "Name": "Mike Manager"
            //     }
            //   },
            //   {
            //     "Name": "Mike Manager"
            //   }
            // ]
        }
    }
}
