using ConsoleApp16;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Claims;
    class Program
    {
        static void Main(string[] args)
        {
            var a = Convert.ToInt32(Console.ReadLine());
            char c;
            int count=0;
            Client h = new Client();
            Ibased m = new ClientAdapter(h);
            m.BasedInt(a);
        }
    }