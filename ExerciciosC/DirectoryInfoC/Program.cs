using System;
using System.Collections.Generic;
using System.IO;

namespace DirectoryInfoC
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Adolfo\source\repos\ExerciciosC\doc\";

            try
            {
               IEnumerable<string> folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                foreach(string s in folder)
                {
                    Console.WriteLine(s);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + "newFolder");
            }
            catch (IOException e)
            {

                Console.WriteLine("Houve um erro não esperado "+e.Message);
            }
        }
    }
}
