/// <summary>
/// \details Класс калькулятор являеться макетом для подставления значениий
///     
/// 
/// </summary>
public class Calc{
    /// <summary>
    /// \details Сумма - складывает числа 
    /// </summary>
    /// <param name="firstValue"></param>
    /// <param name="secondValue"></param>
    /// <returns></returns>
        public double Sum(double firstValue, double secondValue){
        return firstValue + secondValue;
    }
    /// <summary>
    /// \details Вычитание - отнимает числа   
    /// </summary>
    /// <param name="firstValue"></param>
    /// <param name="secondValue"></param>
    /// <returns></returns>
            public double Minus(double firstValue, double secondValue){
        return firstValue - secondValue;
    }
    /// <summary>
    /// \details Умножение - умножает числа 
    /// </summary>
    /// <param name="firstValue"></param>
    /// <param name="secondValue"></param>
    /// <returns></returns>
            public double Multpily(double firstValue, double secondValue){
        return firstValue * secondValue;
    }
    /// <summary>
    /// \details Деление - Делит числа
    /// </summary>
    /// <param name="firstValue"></param>
    /// <param name="secondValue"></param>
    /// <returns></returns>
            public double Devid(double firstValue, double secondValue){
        return firstValue / secondValue;
    }
}


/// <summary>
/// \details Класс регвест принимает значение от пользователя и обрабатывает их 
/// </summary>
public class Request
{
    Calc calc;

    public Request(Calc calc){
        this.calc = calc;
    }
    public void Req()
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


/// <summary>
/// \details Класс программа собирает все данные в кучу и запускает программу
/// </summary>
class Prog{
    static void Main(string[] args){
        Calc calc = new Calc();
        Request req = new Request(calc);
        req.Req();
    }
}




