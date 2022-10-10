using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace FileAndTexts.WorkingWithFiles
{
    public class FileUsingStream
    {
        FileStream file = null;
        public string path;

        public void CommonMethodOfFileCreation()
        {
            Console.WriteLine("******************************************************************File Creation**************************");
            path = @"C:\Users\siddh\source\repos\WorkingWithFileAndTexts\FileAndTexts\WorkingWithFiles\myfile.txt";//verbatim literal
            file = new FileStream(path, FileMode.OpenOrCreate);
            Console.WriteLine("File is created...");
        }
        public void WriteFile()
        {
           
            for (int i = 65; i <= 90; i++)
            {
                file.WriteByte((byte)i);
            }
        //    file.Close();
            Console.WriteLine("Writed file");
        }

        public void ReadFile()
        {
            //file read

            int j = 0;
            while ((j = file.ReadByte()) != -1)
            {
                Console.Write((char)j);
            }
            file.Close();

            Console.WriteLine("\n read,");
        }

       


    }
}
