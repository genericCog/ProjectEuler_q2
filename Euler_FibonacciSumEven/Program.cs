using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//By considering the terms in the Fibonacci sequence 
//whose values do not exceed four million, 
//find the sum of the even-valued terms. (collect all even nums in array to be summed)
/*
	REFERENCE
	if-else					https://msdn.microsoft.com/en-us/library/5011f09h.aspx
	While Loop				http://www.tutorialspoint.com/csharp/csharp_while_loop.htm
	for-loop				http://www.dotnetperls.com/for	
	modulus operator		https://www.tradingcode.net/csharp/operators/modulus-operator/
	newline					http://www.dotnetperls.com/newline
	sum an array of ints 	http://stackoverflow.com/questions/2419343/how-to-sum-up-an-array-of-integers-in-c-sharp
    keep open console       http://stackoverflow.com/questions/16952846/how-to-keep-console-window-open
    Comment and Uncomment Code  https://blogs.msdn.microsoft.com/zainnab/2010/04/13/comment-and-uncomment-code/
    Enhance & Improve Code  http://www.mathblog.dk/project-euler-problem-2/
 */

namespace Euler_FibonacciSumEven
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            int fibonacci_Left = 1;
            int fibonacci_Right = 1;
            int sum = 0;
            int fibonacci_result = 0;

            while (fibonacci_result < 4000000)
            {
                if ((fibonacci_result % 2) == 0)
                {
                    sum += fibonacci_result;
                    list.Add(fibonacci_result);
                    //Console.WriteLine("Array Contents: ");
                    //list.ForEach(item => Console.Write(item + ","));
                    //Console.WriteLine(Environment.NewLine);
                   // Console.WriteLine(Environment.NewLine);
                }
                fibonacci_result = fibonacci_Left + fibonacci_Right;
                fibonacci_Right = fibonacci_Left;
                fibonacci_Left = fibonacci_result;
            }
            Console.WriteLine("##############################" + Environment.NewLine);
            Console.WriteLine("     Fibonacci Even Number Sum" + Environment.NewLine);
            Console.WriteLine("##############################");

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("______________________________");
            Console.WriteLine("Array Contents: ");
            list.ForEach(item => Console.Write(item + ","));
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("______________________________");    
            Console.WriteLine("The sum of even-valued terms: " + Environment.NewLine + fibonacci_result);

            if (System.Diagnostics.Debugger.IsAttached) Console.ReadLine();

        }//end Main
    }//end class Program
}//end namespace Euler_FibonacciSumEven
