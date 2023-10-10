public class Calculator
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.Clear();
            double firstValue, secondValue;
            string action;


            try
            {
                Console.WriteLine("Введите первое число");
                firstValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите операцию");
                action = Console.ReadLine();

                Console.WriteLine("Введите второе число");
                secondValue = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Было введенно не число");
                Console.ReadLine();
                continue;
            }
            switch (action)
            {
                case "+":
                    Console.WriteLine(firstValue + secondValue);
                    break;

                case "-":
                    Console.WriteLine(firstValue - secondValue);
                    break;

                case "*":
                    Console.WriteLine(firstValue * secondValue);
                    break;

                case "/":

                    if (secondValue == 0)
                    {
                        Console.WriteLine("Нельзя делить на ноль");
                    }
                    else
                    {
                        Console.WriteLine(firstValue / secondValue);
                    }
                    break;

                default:
                    Console.WriteLine("Неизвестное действие");
                    break;
            }
            Console.ReadLine(); 
        }

    }
}




