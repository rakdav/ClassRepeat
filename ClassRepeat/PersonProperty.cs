using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRepeat
{
    class PersonProperty
    {
        private string name;
        private int age;

        public PersonProperty(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //   public string Name => name;
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
            }
        }
        public int Age
        {
            private set
            {
                if(value<18)
                {
                    Console.WriteLine("Возраст меньше 18");
                }
                else
                {
                    age = value;
                }
            }
            get
            {
                return age;
            }
        }
    }
}
