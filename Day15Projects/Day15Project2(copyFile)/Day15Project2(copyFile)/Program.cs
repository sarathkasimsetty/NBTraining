using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
// WACP to copy files from one folder to other folder.
// Schedule this job to be executed at daily some time.

namespace Day15Project2_copyFile_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // string filesourcepath =@"F:\File data\quiz data.txt";
           //  string filedestpath = @"D:\Backup data\taskschedular.txt";
            

            File.Copy("F:\\File data\\quiz data.txt", "D:\\Backup data\\taskschedular.txt");

            Console.WriteLine("Backup success");

            Console.ReadLine();
        }
    }
}
