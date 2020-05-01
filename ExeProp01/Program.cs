using System;

namespace ExeProp01
{
    class Program
    {
        static void Main(string[] args)
        {
            int Busy = 0;
            Client[] C = new Client[10];

            while (true)
            {
                Console.WriteLine("Welcome to Learning-Inn");
                Console.WriteLine();

                Console.WriteLine("We have the following rooms avalable");
                Console.WriteLine();

                Busy = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (C[i] == null) Console.Write("Room" + (i + 1) + "[ ] ");
                    else
                    {
                        Console.Write("Room" + (i + 1) + "[|] ");
                        Busy++;
                    }
                }
                Console.WriteLine();

                Console.WriteLine();
                Console.Write("How many rooms will be rented? ");
                int N = int.Parse(Console.ReadLine());
                Console.WriteLine();

                while(N > (10 - Busy))
                {
                    Console.WriteLine("Sorry, but we only have " + (10 - Busy) + " available rooms");
                    Console.Write("Please select other number of rooms: ");
                    N = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }

                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine("Rent #" + (i + 1) + ":");
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Email: ");
                    string email = Console.ReadLine();
                    Console.Write("Room: ");
                    int room = int.Parse(Console.ReadLine());

                    while (C[room - 1] != null)
                    {
                        Console.Write("This room isn't available, please select another one: ");
                        room = int.Parse(Console.ReadLine());
                    }

                    C[room - 1] = new Client { Name = name, Email = email };
                    Console.WriteLine();
                }

                Console.WriteLine("Busy rooms:");

                for (int i = 0; i < 10; i++)
                {
                    if (C[i] != null) Console.WriteLine((i+1) + ":" + C[i]);
                }

                Console.WriteLine();
            }
        }
    }
}
