using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //For division, create two integer variables

            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine(a + " / " + b + " is " + quotient + " remainder " + remainder);
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");


            Console.WriteLine("Please enter the radius of your circle:");
            var userInput = Console.ReadLine();
            
            var radius = double.Parse(userInput);

            Console.WriteLine(Methods.AreaOfCircle(radius));

            Methods.AreaOfCircle(radius);

        }   


        
          
        





    } 
}

