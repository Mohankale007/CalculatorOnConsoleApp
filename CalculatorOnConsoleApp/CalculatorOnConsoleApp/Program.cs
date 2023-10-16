namespace CalculatorOnConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string confirm;

            do
            {
                Console.WriteLine("Enter First Number:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number:");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("enter choice for:(addition,subtraction,Multiplication,division)");
                string choice = Console.ReadLine();


                switch (choice)
                {

                    case "addition":
                        Console.WriteLine("Addition is:" + (num1 + num2));
                        break;
                    case "subtraction":
                        Console.WriteLine("Subtraction is:" + (num1 - num2));
                        break;
                    case "multiplication":
                        Console.WriteLine("Multiplication is:" + (num1 * num2));
                        break;
                    case "division":
                        Console.WriteLine("Division is:" + (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("case not found");
                        break;
                }
                Console.WriteLine("==============================================");
                Console.WriteLine("Do you want to continue(yes or no)");
                confirm = Console.ReadLine().ToLower();

            } while (confirm=="yes");

            Console.WriteLine("Out of the loop "+"-----"+"Good bye!!!");
            Console.ReadLine(); 
        }
    }
}