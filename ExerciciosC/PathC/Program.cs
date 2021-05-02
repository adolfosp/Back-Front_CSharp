using System;
using System.IO;

namespace pathCC
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathC = @"C:\Users\Adolfo\source\repos\ExerciciosC\texto.txt";

            Console.WriteLine("GetDirectoryName " + Path.GetDirectoryName(pathC));
            Console.WriteLine(Path.PathSeparator);
            Console.WriteLine("DirectorySeparatorChar " + Path.DirectorySeparatorChar);
            Console.WriteLine("GetFileName " + Path.GetFileName(pathC));
            Console.WriteLine("GetFileNameWithoutExtension " + Path.GetFileNameWithoutExtension(pathC));
            Console.WriteLine("GetExtension " + Path.GetExtension(pathC));
            Console.WriteLine("GetFullPath " + Path.GetFullPath(pathC));
            Console.WriteLine("GetTempPath " + Path.GetTempPath());


        }
    }
}
