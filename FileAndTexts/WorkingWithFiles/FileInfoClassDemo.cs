using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileAndTexts.WorkingWithFiles
{
    public class FileInfoClassDemo
    {
        public void FileInfoCreateFile()
        {
            try
            {
                // Specifying file location  
                string floc = @"C:\Users\siddh\source\repos\WorkingWithFileAndTexts\FileAndTexts\WorkingWithFiles\fileInfoTextFile.txt";
                // Creating FileInfo instance  
                FileInfo file = new FileInfo(floc);
                // Creating an empty file  
                file.Create();
                Console.WriteLine("File is created Successfuly");
            }
            catch (IOException e)
            {
                Console.WriteLine("Something went wrong: " + e);
            }
        }
        public void FileInfoWriteFile()
        {
            try
            {
                // Specifying file location  
                string floc = @"C:\Users\siddh\source\repos\WorkingWithFileAndTexts\FileAndTexts\WorkingWithFiles\fileInfo.txt";
                // Creating FileInfo instance  
                FileInfo file = new FileInfo(floc);
                // Creating an file instance to write  
                StreamWriter sw = file.CreateText();
                // Writing to the file  
                sw.WriteLine("This text is written to the file by using StreamWriter class.");
                sw.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("Something went wrong: " + e);
            }
        }

        public void FileInfoReadFile()
        {
            try
            {
                // Specifying file to read  
                string floc = @"C:\Users\siddh\source\repos\WorkingWithFileAndTexts\FileAndTexts\WorkingWithFiles\Output.txt";
                // Creating FileInfo instance  
                FileInfo file = new FileInfo(floc);
                // Opening file to read  
                StreamReader sr = file.OpenText();
                string data = "";
                while ((data = sr.ReadLine()) != null)
                {
                    Console.WriteLine(data);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Something went wrong: " + e);
            }
        }
    }
}
