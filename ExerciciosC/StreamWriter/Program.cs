using System;
using System.IO;

namespace StreamWriterC
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Adolfo\source\repos\ExerciciosC\texto.txt";
            string targetPath = @"C:\Users\Adolfo\source\repos\ExerciciosC\texto2.txt";

            try
            {

                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(" "+line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Houve um erro não esperado "+e.Message);
            }
        }
    }
}
