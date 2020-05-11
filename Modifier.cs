using System;
using System.Collections.Generic;
using System.Text;

namespace AspTest
{


    static class test
    {
       static int e = 20;
        static int g=10;
        public static void Div()
        {
           double d = e / g;
            Console.WriteLine($"Divide ={d}");

        }
    }
     class Sum
    {
       public static int x1 = 10;
        static int y1 = 20;

        public static void add2()
        {
            int ad = x1+y1;
            Console.WriteLine($"add ={ad}");
        }
        public void mul()
        {
            int ad = x1 * y1;
            Console.WriteLine($"Multiplication={ad}");
        }
    }
    public class Modifier
    {
        #region Fields
        private  int x = 10;
        static int y = 20;
        int n = 40;
        //private int p = 30;
        public int u =90;
        #endregion
        static void add()
        {
            Modifier m = new Modifier();
            int ad = m.x + y;
            Console.WriteLine($"add={ad}");
        }

        protected void print2()
        {
            //int d = 80;
            Console.WriteLine("this is protected method " );
        }
        

        static void Main2(string[] args)
        {

            Console.WriteLine("Static Variable Y = "+y );
            Console.WriteLine("Static Variable Y = " + Modifier.y);
            Console.WriteLine("Static Variable Y = " + Sum.x1);
            Console.WriteLine("Static Variable Y = "  );

           // Add b = new Add();

            add();
            Modifier.add();

            Sum s = new Sum();
            s.mul();
            Sum.add2();

            test.Div();

            Modifier m = new Modifier();
            m.test2();

            Access ac = new Access();
            ac.print();

   
            // e.salary = int.Parse(Console.ReadLine());
           // Console.WriteLine($"object1 x = {e.name}  object2 x = {e.name}");
           // Console.WriteLine("Employe Namn={0}", e.name);
           // Console.WriteLine("Employe salary={0}", e.salary);
        }
       
        private void test2()
        {
            Console.WriteLine("Static Variable Y = " + this.n);
            Console.WriteLine("Static Variable Y = " + n);
            Console.WriteLine("Static Variable Y = {0}", n);
        }
    }
    public class Access : Modifier
    {

        public void print()
        {
            Access ac = new Access();
            Console.WriteLine("..." + ac.u);
            Console.WriteLine("..." +this.u );
            Console.WriteLine("..." + base.u);
            this.print2();

        }

    }
}
