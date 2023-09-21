using System.Diagnostics;

class Program
{
    static void Main()
    {
        while (true)
        {        
            Console.Clear(); 
            Console.WriteLine("Виберіть завдання:");
            Console.WriteLine("1. Завдання номер 1");
            Console.WriteLine("2. Завдання номер 2");
            Console.WriteLine("3. Завдання номер 3");
            Console.WriteLine("4. Завдання номер 4");
            Console.WriteLine("5. Завдання номер 5");
            Console.WriteLine("6. Завдання номер 6");
            Console.WriteLine("7. Завдання номер 7");
            Console.WriteLine("8. Завдання номер 8");
            Console.Write("Номер завдання (або 'n' для виходу): ");
            string input = Console.ReadLine();
            if (input.ToLower() == "n")
            {
                break;
            }

            else if (int.TryParse(input, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        CheckNumber();
                        break;
                    case 2:
                        YearCheck();
                        break;
                    case 3:
                        Taxes();
                        break;
                    case 4:
                        Symbols();
                        break;
                    case 5:
                        ThreeNumbers();
                        break;
                    case 6:
                        Pidlitky();
                            break;
                    case 7:
                        Parnedil3();
                        break;
                    case 8:
                        Triangle();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number or 'n' to exit.");
            }
        }
        static void CheckNumber()
        {
            while (true)
            {
                Console.Write("введіть число для перевірки -  ");
                string input1 = Console.ReadLine();
                if (input1.ToLower() == "n")
                {
                    break;
                }
                else if (int.TryParse(input1, out int num))
                {
                    if (num < 0)
                    {
                        Console.WriteLine($"число {num} є від'ємним");
                    }        
                    else if (num == 0)
                    {
                        Console.WriteLine($"число {num} дорівнює 0");
                    }
                    else if (num > 0)
                    {
                        Console.WriteLine($"число {num} є додатнім");
                    }  
                }              
            }
        }
        static void YearCheck()
        {
            while (true)
            {
                Console.Write("ваш рік (щоб вернутися до вибору завдань впишіть 'n' ) - ");
                string input2 = Console.ReadLine();
                if (input2.ToLower() == "n")
                {
                    break;
                }
                else if (int.TryParse(input2, out int year))
                {
                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    {
                        Console.WriteLine($"{year} є високoсним");
                    }
                    else
                    {
                        Console.WriteLine($"{year} не є високoсним");
                    }
                }
            }
        }
        static void Taxes()
            {
                while (true)
                {
                    Console.Write("ваш річний дохід в грн (щоб вернутися до вибору завдань впишіть 'n' ) - ");
                    string input3 = Console.ReadLine();
                    if (input3.ToLower() == "n")
                    {
                        break;
                    }
                    else if (int.TryParse(input3, out int income))
                    {
                        if (income >= 6700 && income <= 16500)
                        {
                            double tax = income * 1/20;
                        Console.WriteLine($"{tax} - ваш податок");
                        }
                        if (income > 16500 && income <= 36000 )
                        {
                            double tax = income * 3 / 50;
                            Console.WriteLine($"{tax} - ваш податок");

                        }
                        if (income > 36000 && income <= 50000)
                        {
                            double tax = income * 7 / 100;
                            Console.WriteLine($"{tax} - ваш податок");
                        }
                        if (income > 50000)
                        {
                            double tax = income * 1 / 10;
                            Console.WriteLine($"{tax} - ваш податок");
                        }
                    }
                }
            }
        static void Symbols()
        {
            while (true)
            {
                Console.Write("введіть символ (щоб вернутися до вибору завдань впишіть 'n' ) - ");
                string input4 = Console.ReadLine();
                if (input4.ToLower() == "n")
                    {
                        break;
                    }
                else if (input4.Length == 1 && char.IsLetter(input4[0]))
                {
                    char symbol = char.ToLower(input4[0]);
                    if ("aeiou".Contains(symbol))
                    {
                        Console.WriteLine($"{symbol} є голосною");
                    }
                    else
                    {
                        Console.WriteLine($"{symbol} є приголосна");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Помилка!");
                }

            }
            
            
           
        }
        static void ThreeNumbers()
        {
            while (true)
            {
                Console.WriteLine("Введіть три числа (щоб вернутися до вибору завдань впишіть 'n'):");

                Console.Write("Число 1: ");
                string input5 = Console.ReadLine();
                if (input5.ToLower() == "n")
                {
                    break;
                }
                else if (int.TryParse(input5, out int num1)) 
                {
                    Console.Write("Число 2: ");
                    int num2 = int.Parse(Console.ReadLine());

                    Console.Write("Число 3: ");
                    int num3 = int.Parse(Console.ReadLine());
                    int max_int = Math.Max(Math.Max(num1, num2), num3);
                    Console.WriteLine($"{max_int} - найбільше число ");
                }

                    
            }
        }
        static void Pidlitky()
        {
            while (true)
            {
                Console.Write("Введіть кількість років (або 'n' для виходу): ");
                string input6 = Console.ReadLine();

                if (input6.ToLower() == "n")
                {
                    break;
                }
                else if (int.TryParse(input6, out int age))
                {
                    if (age >= 12 && age <= 18)
                    {
                        Console.WriteLine("Це підліток");
                    }
                    else
                    {
                        Console.WriteLine("Це не підліток");
                    }
                }
                else
                {
                    Console.WriteLine("Помилка! Введіть коректні дані або 'n' для виходу.");
                }
            }
        }

        static void Parnedil3()
        {  
            
            while (true)
            {
                Console.Write("Введіть число (або 'n' для виходу) - ");
                string input7 = (Console.ReadLine());

                if (input7.ToLower() == "n")
                {
                    break;
                }
                else if (int.TryParse(input7, out int number))
                {
                    if ((number % 2 == 0) && (number % 3 == 0))
                    {
                        Console.WriteLine($"Число {number} є парним і воно ділиться на 3");
                    }
                    else  
                    {
                        Console.WriteLine($"Число {number} не виконує умови завдання");
                    }
                }
                else
                {
                    Console.WriteLine("Помилка!");
                }
            }
        }
        static void Triangle()
        {
            while (true)
            {
                Console.WriteLine("Введіть три сторони трикутника (щоб вернутися до вибору завдань впишіть 'n'):");

                Console.Write("Сторона 1: ");
                string input8 = Console.ReadLine();
                if (input8.ToLower() == "n")
                {
                    break;
                }
                else if (double.TryParse(input8, out double num1))
                {
                    Console.Write("Сторона 2: ");
                    double num2 = double.Parse((Console.ReadLine()));

                    Console.Write("Сторона 3: ");
                    double num3 = double.Parse(Console.ReadLine());
                    double max_int = Math.Max(Math.Max(num1, num2), num3);
                    Console.WriteLine($"{max_int} - найбільша сторога ");
                }
            }
        }
    }
}
