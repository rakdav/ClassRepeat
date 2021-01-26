using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRepeat
{
    class Person
    {
        private string name;
        private int age;

        public string getName()
        {
            return name;
        }

        public int getAge()
        {
            return age;
        }

        public void setName(string n)
        {
            this.name = n;
        }

        public void setAge(int a)
        {
            this.age = a;
        }
        public Person():this("Untitled")
        {
            //this.name = "Untitled";
            //this.age = 0;
        }

        public Person(string name):this(name,18)
        {
            //this.name = name;
            //this.age = 18;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void GetInfo()
        {
            Console.WriteLine("Имя:"+name+" Возраст:"+age);
        }
    }
}
