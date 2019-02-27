using System;
namespace Arithmetic
{

    class Program
    {

        static void Main(string[] args)
        {

            int a = 10, res;

       
            res = a++;

            Console.WriteLine("a is {0} and res is {1}", a, res);


          
            res = a--;

    
            Console.WriteLine("a is {0} and res is {1}", a, res);


        
            res = ++a;


            Console.WriteLine("a is {0} and res is {1}", a, res);


         
            res = --a;

            Console.WriteLine("a is {0} and res is {1}", a, res);

            bool result;
            int x = 5, y = 10;

            result = (x == y);
            Console.WriteLine("Equal to Operator: " + result);

  
            result = (x > y);
            Console.WriteLine("Greater than Operator: " + result);


            result = (x < y);
            Console.WriteLine("Less than Operator: " + result);
 
            result = (x >= y);
            Console.WriteLine("Greater than or Equal to: " + result);

            result = (x <= y);
            Console.WriteLine("Lesser than or Equal to: " + result);

         
            result = (x != y);
            Console.WriteLine("Not Equal to Operator: " + result);
            bool e = true, f = false, result1;

      
            result1 = e && f;
            Console.WriteLine("AND Operator: " + result);

            result1 = e || f;
            Console.WriteLine("OR Operator: " + result);

            result1 = !e;
            Console.WriteLine("NOT Operator: " + result);
            Bitwise();
            Assignment();
        }

        private static void Assignment()
        {
            int x = 15;

            x += 10;
            Console.WriteLine("Add Assignment Operator: " + x);

 
            x = 20;

          
            x -= 5;
            Console.WriteLine("Subtract Assignment Operator: " + x);


            x = 15;

           
            x *= 5;
            Console.WriteLine("Multiply Assignment Operator: " + x);

 
            x = 25;

            x /= 5;
            Console.WriteLine("Division Assignment Operator: " + x);

   
            x = 25;

            x %= 5;
            Console.WriteLine("Modulo Assignment Operator: " + x);

     
            x = 8;

            x <<= 2;
            Console.WriteLine("Left Shift Assignment Operator: " + x);

            x = 8;

            x >>= 2;
            Console.WriteLine("Right Shift Assignment Operator: " + x);

  
            x = 12;

 
            x &= 4;
            Console.WriteLine("Bitwise AND Assignment Operator: " + x);

       
            x = 12;

      
            x ^= 4;
            Console.WriteLine("Bitwise Exclusive OR Assignment Operator: " + x);

          
            x = 12;

            x |= 4;
            Console.WriteLine("Bitwise Inclusive OR Assignment Operator: " + x);
        }

        private static void Bitwise()
        {
            int x = 5, y = 10, result;


            result = x & y;
            Console.WriteLine("Bitwise AND: " + result);


            result = x | y;
            Console.WriteLine("Bitwise OR: " + result);


            result = x ^ y;
            Console.WriteLine("Bitwise XOR: " + result);


            result = ~x;
            Console.WriteLine("Bitwise Complement: " + result);

   
            result = x << 2;
            Console.WriteLine("Bitwise Left Shift: " + result);

        
            result = x >> 2;
            Console.WriteLine("Bitwise Right Shift: " + result);
        }
    }
}