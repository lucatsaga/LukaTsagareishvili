using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04_2_
{
    public static class Calculator
    {
       public static int Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
            return result;
        }

        public static int Subtract(int a, int b) 
        { 
            int result = a - b; 
            Console.WriteLine(result);
            return result; 
        }
    
       public static int Multiply(int a, int b)
        {
            int result = a * b;
            Console.WriteLine(result);
            return result;
        }
    
       public static int Divide(int a, int b)
        {
            int result = a / b;
            Console.WriteLine(result);
            return result;        
        }
    }





        

   
}
