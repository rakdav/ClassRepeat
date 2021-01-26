using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRepeat
{
    class PersonAuto
    {
        public string Name { get;private set; } = "Tom";
        public int Age { get; set; } = 23;

        public PersonAuto(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
