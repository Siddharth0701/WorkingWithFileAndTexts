using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileAndTexts.WorkingWithFiles
{
    public class BinaryReadClasses
    {
        public void BinaryReadOperation()
        {
            string fileName = @"C:\Users\siddh\source\repos\WorkingWithFileAndTexts\FileAndTexts\WorkingWithFiles\BinaryOutput.txt";
            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                Console.WriteLine("Double Value : " + reader.ReadDouble());
                Console.WriteLine("String Value : " + reader.ReadString());
                Console.WriteLine("Boolean Value : " + reader.ReadBoolean());
            }
        }
    }
}
