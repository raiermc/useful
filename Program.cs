using System;


namespace Named
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calculator();

        }
        public static void Calculator()
        {
            do
            {
                try
                {
                    Console.WriteLine("Calculator\n\nCtrl + C To Exit\n");
                    Console.WriteLine("1 for addition\n2 for subtraction\n3 for multiplication\n4 for division\n5 for square root\n6 for celsius to fahrenheit\n7 for minutes to seconds");
                    double welcome = Convert.ToDouble(Console.ReadLine());

                    if (welcome == 1)
                    {
                        Console.Write("Enter First Number: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Second Number: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        double results = Convert.ToDouble((num1)) + Convert.ToDouble((num2));

                        Console.Clear();
                        Console.WriteLine("Answer: " + results + "\n");
                    }
                    else if (welcome == 2)
                    {
                        Console.Write("Enter First Number: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Second Number: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        double results = Convert.ToDouble((num1)) - Convert.ToDouble((num2));

                        Console.Clear();
                        Console.WriteLine("Answer: " + results + "\n");
                    }
                    else if (welcome == 3)
                    {
                        Console.Write("Enter First Number: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Second Number: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        double results = Convert.ToDouble((num1)) * Convert.ToDouble((num2));

                        Console.Clear();
                        Console.WriteLine("Answer: " + results + "\n");
                    }
                    else if (welcome == 4)
                    {
                        Console.Write("Enter First Number: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Second Number: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        double results = Convert.ToDouble((num1)) / Convert.ToDouble((num2));

                        Console.Clear();
                        Console.WriteLine("Answer: " + results + "\n");
                    }
                    else if (welcome == 5)
                    {
                        Console.Write("Enter Number: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());

                        Console.Clear();
                        Console.Write("Answer: " + (Math.Sqrt(num1)) + "\n");
                    }
                    else if (welcome == 6)
                    {
                        Console.Write("Enter Celsius: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        double results = ((num1 * 9 / 5 + 32));

                        Console.Clear();
                        Console.Write("Answer: " + results + " F\n");
                    }
                    else if (welcome == 7)
                    {
                        Console.Write("Enter Seconds: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        double results = ((num1 / 60));

                        Console.Clear();
                        Console.Write("Answer: " + results + " Minute(s)\n");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Error 404\n");
                    }
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine("There Was An Error: ");
                    Console.WriteLine(e.Message + "\n");
                }
            } while (0 < 1);
        }

    }
}