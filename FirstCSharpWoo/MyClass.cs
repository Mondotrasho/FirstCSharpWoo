using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharpWoo
{
    class MyClass
    {
        public int SimpleAdditionFunction(int num1, int num2)
        {
            return num1 + num2;
        }
        public int SimpleSubtractionFunction(int num1, int num2)
        {
            return num1 - num2;
        }
        public int SimpleMultiplicationFunction(int num1, int num2)
        {
            return num1 * num2;
        }
        public int SimpleDivisionFunction(int num1, int num2)
        {
            return num1 / num2;
        }



    }
}
