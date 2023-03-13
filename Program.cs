using System;
using System.Collections;   // for ArrayList, List<>, HashTable

/* 
[ foreach / class inherit ]
namespace Chapter3
{
    class Unit
    {
        public virtual void Attack()
        {

        }
    }

    class Zerg : Unit
    {
        public override void Attack()
        {
            Console.WriteLine("Zerg Attack!");
        }
    }

    class Protoss : Unit
    {
        public override void Attack()
        {
            Console.WriteLine("Protoss Attack!");
        }
    }

    class Program
    {
        static ArrayList al = new ArrayList();

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                al.Add(i);
            }
            for (int i = 0; i < 5; i++)
            {
                al.Add(new Zerg());
            }
            for (int i = 0; i < 5; i++)
            {
                al.Add(new Protoss());
            }

            foreach (object i in al)
            {
                Console.WriteLine(i);
            }
        }
    }
}

[ for ]
namespace CalculationProj
{
    class GuGuDan
    {
        public void Print()
        {
            int start = Int32.Parse(Console.ReadLine());
            int end = Int32.Parse(Console.ReadLine());

            for (int i = start; i < end; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                }
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            GuGuDan myGu = new GuGuDan();
            myGu.Print();
        }
    }
}

[ enum / switch ~ case ]
namespace MyConsole
{
    class Calculation
    {
        enum CAL { SUM, SUB, MUL, DIV}

        public void Calc()
        {
            int a = Int32.Parse(Console.ReadLine());    // Int32.Parse(TextBox1.text)
            int b = Int32.Parse(Console.ReadLine());

            int op = Int32.Parse(Console.ReadLine());

            switch ((CAL)op)
            {
                case CAL.SUM :
                    Console.WriteLine(a + b);
                    break;
                case CAL.SUB :
                    Console.WriteLine(a - b);
                    break;
                case CAL.MUL :
                    Console.WriteLine(a * b);
                    break;
                case CAL.DIV :
                    Console.WriteLine(a / b);
                    break;
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Calculation myCal = new Calculation();
            myCal.Calc();   
        }
    }
}
*/