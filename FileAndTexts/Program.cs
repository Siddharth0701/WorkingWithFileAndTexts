using FileAndTexts.WorkingWithFiles;
using FileAndTexts.WorkingWithTexts;
using System;

namespace FileAndTexts
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileUsingStream fs = new FileUsingStream();
            ////fs.CommonMethodOfFileCreation();
            //fs.WriteFile();
            //fs.ReadFile();
            

            //StreamWriterClasses streamWriterClasses = new StreamWriterClasses();
            //streamWriterClasses.FileCreateAndWrite();
            //StreamReadClasses streamReadClasses = new StreamReadClasses();
            //streamReadClasses.StreamReads();

            //BinaryWriterClasses binaryWriterClasses = new BinaryWriterClasses();
            //binaryWriterClasses.BinaryWriteOperation();
            //BinaryReadClasses binaryReadClasses = new BinaryReadClasses();
            //binaryReadClasses.BinaryReadOperation();

            Console.WriteLine("Text .......................................");

            StringTexts texts = new StringTexts();
            texts.ToUpperAndLower();
            texts.CompareString("hello","Hello");
            texts.Compare2String();
            texts.ToUpperAndLower();
            texts.Concatenate();
            texts.Contain("Singham", "Singh");

            texts.CopyMethod();
            texts.getTypeMethod();
            texts.GetIndexOf();
            texts.insertMethod();
        }
    }
}
