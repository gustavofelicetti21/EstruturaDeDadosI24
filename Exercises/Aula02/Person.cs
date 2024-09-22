using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula02
{
    public class Person
    {
        public string _location = string.Empty;
        public string Name { get; set; }
        public int Age { get; set; }

        // Método Construtor
        public Person(string name, int age) 
        {
            this.Name = name;
            this.Age = age;
        }

        public Person()
        {
            Name = "------";
        }

        public void Realocate(string location) 
        {
            if(!string.IsNullOrEmpty(location)) 
            {
                this._location = location;
            }
        }

        public float GetDistance(string location)
        {
            return 0;
        }
    }
}