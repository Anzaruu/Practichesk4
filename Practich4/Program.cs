namespace Practich4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data2();
        }

        static void Strelka(out int position)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            position = 2;
            if ((key.Key == ConsoleKey.UpArrow) && (position != 2))
            {
                position--;
            }

            if ((key.Key == ConsoleKey.DownArrow) && (position < 3))
            {
                position++;
            }
            if (position == 2)
            {
                Console.SetCursorPosition(0, position + 1);
            }
            if (position > 3)
            {
                Console.SetCursorPosition(0, position - 1);
            }
        }
        static void Data1()
        {
            Console.Clear();
            Console.WriteLine("Нажмите стрелку вниз, чтобы посмотреть дату");
            DateTime date = new DateTime(2022, 9, 22);
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {
                Strelka(out int position);
                Console.Clear();
                Console.WriteLine(date);
                Console.WriteLine("-------------------------");
                Console.WriteLine("  1. Завтрак");
                Console.WriteLine("  2. Сделать домашнюю работу");
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                key = Console.ReadKey();
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    Data3();
                }

                if (key.Key == ConsoleKey.RightArrow)
                {
                    Data2();
                }
            }
            Sametka1();
        }

        static void Sametka1()
        {
            DateTime date = new DateTime(2022, 9, 22);
            Strelka(out int position);
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Escape)
            {
                if (position == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Завтрак");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Описание: приготовить себе завтрак и покормить кошку");
                    Console.WriteLine("Дата: ", date);
                    key = Console.ReadKey();
                }

                if (position == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Сделать домашнюю работу");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Описание: нарисовать план эвакуации по БЖД");
                    Console.WriteLine("Дата: ", date);
                    key = Console.ReadKey();
                }
            }
            Data1();
        }

        static void Data2()
        {
            Console.Clear();
            Console.WriteLine("Нажмите стрелку вниз, чтобы посмотреть дату");
            DateTime date = new DateTime(2022, 10, 22);
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {
                Strelka(out int position);
                Console.Clear();
                Console.WriteLine(date);
                Console.WriteLine("-------------------------");
                Console.WriteLine("  1. Сходить в магазин");
                Console.WriteLine("  2. Сделать дела по дому");
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                key = Console.ReadKey();
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    Data1();
                }

                if (key.Key == ConsoleKey.RightArrow)
                {
                    Data3();
                }
            }
            Sametka2();
        }
        static void Sametka2()
        {
            DateTime date = new DateTime(2022, 10, 22);
            ConsoleKeyInfo key = Console.ReadKey();
            Strelka(out int position);
            while (key.Key != ConsoleKey.Escape)
            {
                if (position == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Сходить в магазин");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Описание: купить молока и хлеба");
                    Console.WriteLine("Дата: ", date);
                    key = Console.ReadKey();
                }

                if (position == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Сделать дела по дому");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Описание: помыть полы и пропылесосить");
                    Console.WriteLine("Дата: ", date);
                    key = Console.ReadKey();
                }
            }
            Data2();
        }

        static void Data3()
        {
            Console.Clear();
            Console.WriteLine("Нажмите стрелку вниз, чтобы посмотреть дату");
            DateTime date = new DateTime(2022, 9, 22);
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {
                Strelka(out int position);
                Console.Clear();
                Console.WriteLine(date);
                Console.WriteLine("-------------------------");
                Console.WriteLine("  1. Сделать практическую работу");
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                key = Console.ReadKey();
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    Data2();
                }

                if (key.Key == ConsoleKey.RightArrow)
                {
                    Data1();
                }
            }
            Sametka3();
        }

        static void Sametka3()
        {
            DateTime date = new DateTime(2022, 9, 22);
            Strelka(out int position);
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Escape)
            {
                if (position == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Сделать практическую работу");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Описание: Практическая работа 3 по спискам, кортежаи и словарям");
                    Console.WriteLine("Дата: ", date);
                    key = Console.ReadKey();
                }
            }
            Data3();
        }
    }
}