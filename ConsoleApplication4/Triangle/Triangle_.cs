using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Triangle
{
    /*2.	В класс Triangle добавить:
o	Индексатор, позволяющий по индексу 0 обращаться к полю a, по индексу 1 - к полю b,
по индексу 2 - к полю c, при других значениях индекса выдается сообщение об ошибке.
o	Перегрузку:
	операции ++ ( -- ): одновременно увеличивает (уменьшает) значение полей a, b и c на 1 ;
	констант true и false: обращение к экземпляру класса дает значение true, если треугольник
с заданными длинами сторон существует, иначе false ;
	операции *: одновременно домножает поля a, b и c на скаляр;
	преобразования типа Triangle в string (и наоборот).
*/
    class Triangle_
    {
        int a, b, c;
        public Triangle_():this(0,0,0){ }
        public Triangle_(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public static Triangle_ operator++(Triangle_ tr)
        {
            tr.a++;
            tr.b++;
            tr.c++;
            return tr;
        }
        public static Triangle_ operator --(Triangle_ tr)
        {
            tr.a--;
            tr.b--;
            tr.c--;
            return tr;
        }
        public static bool operator true( Triangle_ tr)
        {
            if (tr != null)
                return true;
            else
                return false;
        }
        public static bool operator false(Triangle_ tr)
        {
            if (tr == null)
                return true;
            else
                return false;
        }

        public static Triangle_ operator *(Triangle_ tr, int s)
        {
            tr.a=tr.a*s;
            tr.b=tr.b*s;
            tr.c=tr.c*s;
            return tr;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", a, b,c);
        }

        public static explicit operator Triangle_(string x)
        {
            string[] val = x.Split('.');
            return new Triangle_(Int32.Parse(val[0]), Int32.Parse(val[1]), Int32.Parse(val[2]));
        }
    }
}
