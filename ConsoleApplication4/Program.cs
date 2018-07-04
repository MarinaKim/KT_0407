using ConsoleApplication4.Point;
using ConsoleApplication4.Triangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Money
    {
        public decimal Amount { get; set; }
        public string Unit { get; set; }

        public Money(decimal amount, string unit)
        {
            Amount = amount;
            Unit = unit;
        }
        public static Money operator +(Money a, Money b)
        {
            if (a.Unit != b.Unit)
                throw new InvalidOperationException("нельзя суммировать деньги в разных валютах.");
            return new Money(a.Amount + b.Amount, a.Unit);
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Amount, Unit);

        }

        public static Money operator ++(Money a)
        {
            return new Money(a.Amount + 2, a.Unit);
        }
    }
    //Explicit
    class Counter
    {
        public int Second { get; set; }

        public static implicit operator Counter(int x)
        {
            return new Counter { Second = x };
        }

        public static explicit operator int(Counter x)
        {
            return x.Second;
        }
    }


    class MyArr
    {
        public int x, y, z;
        public MyArr(int x = 0, int y = 0, int z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static bool operator ==(MyArr a, MyArr b)
        {
            if ((a.x == b.x) || (a.y == b.y))
                return true;
            else
                return false;
        }

        public static bool operator !=(MyArr a, MyArr b)
        {
            if ((a.x != b.x) || (a.y != b.y))
                return true;
            else
                return false;
        }


        public static bool operator true(MyArr a)
        {
            if (a.x < 0)
                return true;
            else
                return false;
        }

        public static bool operator false(MyArr a)
        {
            if (a.x > 0)
                return true;
            else
                return false;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the task num: ");
            int n = Int32.Parse(Console.ReadLine());
            switch (n)
            {
                //Explicit, implicit
                case 1:
                    {
                        Counter c = new Counter() { Second = 666 };
                        Console.WriteLine((int)c);
                    }
                    break;
                //+
                case 2:
                    {
                        Money myMoney = new Money(100, "USD");
                        Money yorMoney = new Money(100, "USD");

                        decimal total = myMoney.Amount + yorMoney.Amount;

                        Money totalSum = myMoney + yorMoney;
                    }
                    break;

                case 3:
                    {
                        Money myMoney = new Money(100, "USD");
                        Money yorMoney = new Money(100, "USD");
                        myMoney++;
                        Console.WriteLine(myMoney);

                    }
                    break;


                //==,!=,true, false
                case 4:
                    {
                        MyArr a = new MyArr(2, 4, 5);
                        MyArr b = new MyArr(2, 4, 5);
                        if (a == b)
                            Console.WriteLine("match");
                        else
                            Console.WriteLine("no match");

                        if (a)
                        {

                        }
                    }
                    break;

                //Point
                case 5:
                    {
                        Point.Point a = new Point.Point(2, 2);
                        a++;
                        Console.WriteLine(a);
                        Console.WriteLine("--------------------------------------");
                        a--;
                        Console.WriteLine(a);
                        Console.WriteLine("--------------------------------------");
                        a = a + 4;
                        Console.WriteLine(a);
                        Console.WriteLine("--------------------------------------");

                        string s = "1.2";
                        a = (Point.Point)s;
                        Console.WriteLine(a);
                        Console.WriteLine("--------------------------------------");
                    }
                    break;

                //Triangle
                case 6:
                    {
                        Triangle_ a = new Triangle_(2, 4,7);
                        a++;
                        Console.WriteLine(a);
                        Console.WriteLine("--------------------------------------");
                        a--;
                        Console.WriteLine(a);
                        Console.WriteLine("--------------------------------------");
                        a = a * 4;
                        Console.WriteLine(a);
                        Console.WriteLine("--------------------------------------");

                        string s = "1.2.5";
                        a = (Triangle_)s;
                        Console.WriteLine(a);
                        Console.WriteLine("--------------------------------------");
                    }
                    break;
            }



        }
    }
}
