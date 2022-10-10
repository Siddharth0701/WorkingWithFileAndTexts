using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileAndTexts.WorkingWithFiles
{
   public class BinaryWriterClasses
    {
        public void BinaryWriteOperation()
        {
            string fileName = @"C:\Users\siddh\source\repos\WorkingWithFileAndTexts\FileAndTexts\WorkingWithFiles\BinaryOutput.txt";
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(2.5);
                writer.Write("this is string data");
                writer.Write(true);
            }
            Console.WriteLine(" Binary Data written successfully...");
        }
    }

    
}
