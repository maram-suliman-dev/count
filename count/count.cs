namespace project1_Maram
{
    public class Count
    {

        public static void Calculate()
        {


            Console.WriteLine("write frist number :");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("write secound number:");
            int b = int.Parse(Console.ReadLine());

            Count.Calculate(a, b, "+");
            Count.Calculate(a, b, "-");
            Count.Calculate(a, b, "*");
            Count.Calculate(a, b, "/");
        }

        public static void Calculate(int a, int b, string op)
        {
            int result = 0;

            switch (op)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    if (b != 0)
                        result = a / b;
                    else
                        Console.WriteLine("handle divide by zero");
                    return;

                default:
                    Console.WriteLine("default to " + ");
                    return;

            }

            Console.WriteLine($"{a} {b} {op}= {result}");
        }
    }
}



