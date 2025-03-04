using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace IceTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int choice;
            WorkerClass worker = new WorkerClass();
            string sound1 = "1. Wav1";
            string sound2 = "2. Wav2";
            string sound3 = "3. Wav3";
            string end = "4. END";

            do
            {
                Console.WriteLine("Pick a sound to play");
                Console.WriteLine(sound1);
                Console.WriteLine(sound2);
                Console.WriteLine(sound3);
                Console.WriteLine(end);
              
             
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch(choice)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Wav 1 is now playing");
                            Console.ResetColor();
                            worker.Sound1();
                            break;

                        case 2:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Wav 2 is now playing");
                            Console.ResetColor();
                            worker.Sound2();
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Wav 3 is now playing");
                            Console.ResetColor();
                            worker.Sound3();
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Shutting down program");
                            Console.ResetColor();
                            break;
                    }
                }
            }
            while (choice != 4);


        }
    }
}
