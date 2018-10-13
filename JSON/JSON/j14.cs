using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    public class Person1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }

    public class Employee1 : Person1
    {
        public string Department { get; set; }
        public string JobTitle { get; set; }
    }

    public class PersonConverter : CustomCreationConverter<Person1>
    {
        public override Person1 Create(Type objectType)
        {
            return new Employee1();
        }

        static void Main(string[] args)
        {
            string json = @"{
                              'Department': 'Furniture',
                              'JobTitle': 'Carpenter',
                              'FirstName': 'John',
                              'LastName': 'Joinery',
                              'BirthDate': '1983-02-02T00:00:00'
                            }";

            Person1 person = JsonConvert.DeserializeObject<Person1>(json, new PersonConverter());

            Console.WriteLine(person.GetType().Name);
            // Employee

            Employee1 employee = (Employee1)person;

            Console.WriteLine(employee.JobTitle);
            // Carpenter
            Console.Read();
        }
    }
}
