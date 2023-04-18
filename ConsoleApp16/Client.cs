using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class Client 
    {
        public double ClientDouble(double clientdouble)
        {
            Console.WriteLine("Введите дробное число - ");
            clientdouble=Convert.ToDouble(Console.ReadLine());
            Console.Write(clientdouble);
            return clientdouble;
            
        }
        public int ClientInt(int clientint)
        {
            Console.WriteLine("Введите целое число число - ");
            clientint = Convert.ToInt32(Console.ReadLine());
            clientint = clientint * 2;
            Console.Write(clientint);
            return clientint;
            
        }
        public char ClientChar(char clientchar)
        {
            Console.WriteLine("Введите букву - ");
            Console.Write(clientchar);
            return clientchar;
        }
    }
}
