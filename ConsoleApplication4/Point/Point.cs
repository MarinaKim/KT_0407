using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Point
{/*1.	В класс Point добавить:
o	Индексатор, позволяющий по индексу 0 обращаться к полю x, по индексу 1 - к полю y,
при других значениях индекса выдается сообщение об ошибке.
o	Перегрузку:
	операции ++ ( -- ): одновременно увеличивает (уменьшает) значение полей х и у на 1 ;
	констант true и false: обращение к экземпляру класса дает значение true, если значение 
полей x и у совпадает, иначе false ;
	операции бинарный +: одновременно добавляет к полям х и у значение скаляра;
	преобразования типа Point в string (и наоборот).
*/
    public class Point
    {
        int x, y;
        public Point() : this(0,0) { }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Point operator ++(Point a)
        {
            Point c = new Point(a.x + 1, a.y + 1);
            return c;
        }

        public static Point operator --(Point a)
        {
            a.x--;
            a.y--;
            return a;
        }

        public static bool operator true(Point a)
        {
            if (a.x == a.y)
                return true;
            else
                return false;
        }
        public static bool operator false(Point a)
        {
            if (a.x != a.y)
                return true;
            else
                return false;
        }
        public static Point operator +(Point a, int z)
        {
            a.x += z;
            a.y += z;
            return a;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", x, y);
        }

        public static explicit operator Point (string x)
        {
            string[] val = x.Split('.');
            return new Point(Int32.Parse(val[0]), Int32.Parse(val[1]));
        }
    }
}
