using System;
using System.IO;

namespace FileFileInfoIOException
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Adolfo\source\repos\ExerciciosC\texto.txt";
            string targetPath = @"C:\Users\Adolfo\source\repos\ExerciciosC\texto2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);

                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);

                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {

                Console.WriteLine("Um erro ocorreu "+e.Message);
            }
        }
    }
}
