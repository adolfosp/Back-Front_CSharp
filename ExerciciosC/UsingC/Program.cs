using System;
using System.IO;

namespace UsingC
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\Users\Adolfo\source\repos\ExerciciosC\texto.txt";

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Houve um erro" + e.Message);
            }



        }
    }
}
