using System;
using System.Collections.Generic;
using System.Text;

namespace AspTest
{
    class AbstractDemo
    {
        public abstract class Abstract
        {
            protected int id, age;
            protected string name;
            public virtual void getInput()
            {
                Console.WriteLine("ID:::");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("age:::");
                age = int.Parse(Console.ReadLine());
                Console.WriteLine("Name:::");
                name = Console.ReadLine();

            }
            public abstract void TotalSalary();
            public virtual void Display()
            {
                Console.WriteLine("\nID--{0}", id);
                Console.WriteLine("Name--{0}", name);
                Console.WriteLine("age--{0}", this.age);

            }
            public void NonAbsMethod()
            {
                Console.WriteLine("Execute Successfully");

            }
        }
        public class ITdept : Abstract
        {
            int salary, bonus, total;
            public override void getInput()
            {
                base.getInput();
                Console.WriteLine("salary:::");
                salary = int.Parse(Console.ReadLine());
                Console.WriteLine("Bonus:::");
                bonus = int.Parse(Console.ReadLine());

            }

            public override void TotalSalary()
            {
                total = salary + bonus;

            }
            public override void Display()
            {
                base.Display();
                Console.WriteLine("Total salary with Bonus:::{0}", total);

            }

        }
        static void Main2(string[] args)
        {
            ITdept it = new ITdept();
            it.getInput();
            it.TotalSalary();
            it.Display();
            it.NonAbsMethod();
        }
    }
  
}
