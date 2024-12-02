using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakharom
{
    public class Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Age {  get; set; }
        public string DisplayAnimal { get; set; }

        public Animal(string name, string type, string age)
        {
            Name = name;
            Type = type;
            Age = age;
            DisplayAnimal = this.ToString();
        }

        public override string ToString()
        {
            return $"{Name}, {Type}, kor: {Age}";
        }
    }
}
