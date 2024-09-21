namespace FirstCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Welcome to Our First Calculator App *****");
            Console.WriteLine("\n");
            
            //prompts and collects first number from user
            Console.Write("Please enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            //prompts and collects second number from user
            Console.Write("Please enter a second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            //processes first and second number (sum, difference, product, quotient)
            int sum = num1 + num2;
            decimal difference = num1 - num2;
            int product = num1 * num2;
            int quotient = num1 / num2;
            Console.WriteLine("\n");


            //displays the results of the calculations above
            Console.WriteLine("***** RESULTS ******");            
            Console.WriteLine("\n");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {Math.Abs(difference)}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine("\n");
            Console.WriteLine("***** END of Our First Calculator App *****");

            /* 
             * to work with fractional numbers, we can change the data type 
             * of our number variables to decimal, double, or float.
             * then, we can make the necessary changes to our calculative variables 
             * (sum, difference, product, quotient) and change those data types, respectively.
             */

            Console.ReadKey();
        }
    }
}
