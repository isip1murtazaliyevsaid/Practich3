using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выбери октаву 1 или 2 (F1 или F2)");


        F1();

        F2();


    }
    static void F1()
    {
        ConsoleKeyInfo k = Console.ReadKey();
        if (k.Key == ConsoleKey.F1)
        {
            Console.WriteLine(" _октава 1");
            int[] FirstOctave = new int[] { 3270, 3465, 3671, 3889, 4120, 4365, 4625, 4900, 5191, 5500, 5827, 6174 };
            Console.WriteLine("нажми на любую клавишу: Й, Ц, У, К, Е, Н, Г, Ш, Щ, З, Ф, Ы");
            Console.WriteLine("чтобы закончить и выбрать другую октаву нажми: Escape");
            while (true)
            {

                ConsoleKeyInfo a = Console.ReadKey();
                if ((a.Key == ConsoleKey.Escape))
                {
                    Console.WriteLine(" ");



                    break;

                }
                if (a.Key == ConsoleKey.Q)
                {
                    Console.Beep(FirstOctave[0], 300);
                }
                if (a.Key == ConsoleKey.W)
                {
                    Console.Beep(FirstOctave[1], 300);
                }
                if (a.Key == ConsoleKey.E)
                {
                    Console.Beep(FirstOctave[2], 300);
                }
                if (a.Key == ConsoleKey.R)
                {
                    Console.Beep(FirstOctave[3], 300);
                }
                if (a.Key == ConsoleKey.T)
                {
                    Console.Beep(FirstOctave[4], 300);
                }
                if (a.Key == ConsoleKey.Y)
                {
                    Console.Beep(FirstOctave[5], 300);
                }
                if (a.Key == ConsoleKey.U)
                {
                    Console.Beep(FirstOctave[6], 300);
                }
                if (a.Key == ConsoleKey.I)
                {
                    Console.Beep(FirstOctave[7], 300);
                }
                if (a.Key == ConsoleKey.O)
                {
                    Console.Beep(FirstOctave[8], 300);
                }
                if (a.Key == ConsoleKey.P)
                {
                    Console.Beep(FirstOctave[9], 300);
                }
                if (a.Key == ConsoleKey.A)
                {
                    Console.Beep(FirstOctave[10], 300);
                }
                if (a.Key == ConsoleKey.S)
                {
                    Console.Beep(FirstOctave[11], 300);
                }
            }
        }
    }

    static void F2()
    {
        ConsoleKeyInfo k = Console.ReadKey();
        if (k.Key == ConsoleKey.F2)
        {
            Console.WriteLine(" _октава 2");
            int[] SecondOctave = new int[] { 6541, 6930, 7342, 7778, 8241, 8731, 9250, 9800, 1038, 1100, 1165, 1235 };
            Console.WriteLine("нажми на любую клавишу: Й, Ц, У, К, Е, Н, Г, Ш, Щ, З, Ф, Ы");
            Console.WriteLine("чтобы закончить и выбрать другую октаву нажми: Escape");
            while (true)
            {

                ConsoleKeyInfo a = Console.ReadKey();
                if ((a.Key == ConsoleKey.Escape))
                {

                    Console.WriteLine(" ");

                    break;

                }
                if (a.Key == ConsoleKey.Q)
                {
                    Console.Beep(SecondOctave[0], 300);
                }
                if (a.Key == ConsoleKey.W)
                {
                    Console.Beep(SecondOctave[1], 300);
                }
                if (a.Key == ConsoleKey.E)
                {
                    Console.Beep(SecondOctave[2], 300);
                }
                if (a.Key == ConsoleKey.R)
                {
                    Console.Beep(SecondOctave[3], 300);
                }
                if (a.Key == ConsoleKey.T)
                {
                    Console.Beep(SecondOctave[4], 300);
                }
                if (a.Key == ConsoleKey.Y)
                {
                    Console.Beep(SecondOctave[5], 300);
                }
                if (a.Key == ConsoleKey.U)
                {
                    Console.Beep(SecondOctave[6], 300);
                }
                if (a.Key == ConsoleKey.I)
                {
                    Console.Beep(SecondOctave[7], 300);
                }
                if (a.Key == ConsoleKey.O)
                {
                    Console.Beep(SecondOctave[8], 300);
                }
                if (a.Key == ConsoleKey.P)
                {
                    Console.Beep(SecondOctave[9], 300);
                }
                if (a.Key == ConsoleKey.A)
                {
                    Console.Beep(SecondOctave[10], 300);
                }
                if (a.Key == ConsoleKey.S)
                {
                    Console.Beep(SecondOctave[11], 300);
                }
            }
        }
    }

}