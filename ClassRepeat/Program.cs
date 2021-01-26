using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using printer = System.Console;
namespace ClassRepeat
{
    class Program
    {       
        static void Main(string[] args)
        {
            //Person Tom=new Person();
            //Tom.name = "Tom";
            //Tom.age = 23;
            //Tom.GetInfo();
            //Console.WriteLine("Введите имя:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Введите возраст:");
            //int age = int.Parse(Console.ReadLine());
            //Person John = new Person(name,age);
            //John.GetInfo();
            //Person Sade = new Person("Sade");
            //Sade.GetInfo();
            //Person tom = new Person { name = "Tom", age = 31 };
            //Drob d1 = new Drob(1, 2);
            //Drob d2 = new Drob(3, 4);
            //Drob d3 = d1.Plus(d2);
            //d3.Print();
            //State state = new State();
            //state.internalVar = 5;
            //state.ProtIntVar = 3;
            //state.publicVar = 2;
            //state.protVar = 2;
            //Person tom = new Person("Tom",19);
            //tom.setAge(23);
            //printer.WriteLine(tom.getAge());

            //PersonProperty p = new PersonProperty("Tom",20);
            //p.Name = "Tom";
            //printer.WriteLine(p.Name);
            //p.Age = 18;
            //printer.WriteLine(p.Age);
            //PersonAuto pa = new PersonAuto("John", 34);
            //pa.Name = "Jerry";
            //Calculator calculator = new Calculator();
            //calculator.Add(3, 7.5,8);
            Account.MinSum = 500;
            Account account = new Account(400, 10);
            decimal res = Account.GetSum(400, 10, 5);
            printer.WriteLine(res);
            printer.ReadKey();
        }
    }
}
