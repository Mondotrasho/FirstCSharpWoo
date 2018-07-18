using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FirstCSharpWoo
{
    class Program
    {

        static void Main(string[] args)
        {

            MyClass myClass = new MyClass();

            int answer = myClass.SimpleAdditionFunction(3, 4);

            //|||||||||

            Console.WriteLine("Whats your name");
           
            string  word = Console.ReadLine();
          

            Console.WriteLine("Hello "+ word +" world");
            while (true) ;
        }

       
    }
}
