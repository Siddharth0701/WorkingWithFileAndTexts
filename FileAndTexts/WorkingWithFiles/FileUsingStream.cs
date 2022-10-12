using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace FileAndTexts.WorkingWithFiles
{
    public class FileUsingStream
    {
        
        public void FileCreateAndWrite()
        {
          string  path = @"C:\Users\siddh\source\repos\WorkingWithFileAndTexts\FileAndTexts\WorkingWithFiles\myFile.txt";//verbatim literal
            FileStream f = new FileStream(path, FileMode.OpenOrCreate);//creating file stream  
            for (int i = 65; i <= 90; i++)
            {
                f.WriteByte((byte)i);
            }
            f.Close();
        }
        public void readFileStream()
        {
            string path = @"C:\Users\siddh\source\repos\WorkingWithFileAndTexts\FileAndTexts\WorkingWithFiles\myFile.txt";//verbatim literal
            FileStream f = new FileStream(path, FileMode.Open);
            int i = 0;
            while ((i = f.ReadByte()) != -1)
            {
                Console.Write((char)i);
            }
            f.Close();
        }






    }
}
