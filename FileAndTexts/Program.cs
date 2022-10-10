using FileAndTexts.WorkingWithFiles;
using System;

namespace FileAndTexts
{
    class Program
    {
        static void Main(string[] args)
        {
            FileUsingStream fs = new FileUsingStream();
            fs.CommonMethodOfFileCreation();
            fs.ReadFile();
            fs.ReadFile();
            //Console.WriteLine("Hello World!");
        }
    }
}
