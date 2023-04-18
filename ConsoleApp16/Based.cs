using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class Based : Ibased
    {
        public double BasedDouble(double basedouble)
        {
            Console.WriteLine("Введите дробное число - ");
            basedouble = Convert.ToDouble(Console.ReadLine());
            Console.Write(basedouble);
            return basedouble;
        }
        public int BasedInt(int basedint)
        {
            Console.Write(basedint);
            return basedint;
        }
        public char BasedChar(char basedchar)
        {
            Console.WriteLine("Введите букву - ");
            basedchar = Convert.ToChar(Console.ReadLine());
            Console.Write(basedchar);
            return basedchar;
        }
    }
}
