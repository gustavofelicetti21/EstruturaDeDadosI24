using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeArvoreBasica
{
    public class Person
    {
        public string? name { get; set; }
        public int age { get; set; }
        public string? role { get; set; }

        public Person(string Name, int Age, string Role)
        {
            name = Name;
            age = Age;
            role = Role;
        }
    }
}