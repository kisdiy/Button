using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Button
{
    class Program
    {
        static void Main(string[] args)
        {
            ButtonClass but = new ButtonClass("Button");

            Substract1 sub = new Substract1();

            but.Click += sub.Mess;

            but.ClickButton();
            Console.Read();
        }
    }
}
