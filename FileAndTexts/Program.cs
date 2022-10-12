using FileAndTexts.WorkingWithFiles;
using FileAndTexts.WorkingWithTexts;
using System;

namespace FileAndTexts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Working With Files................................................................");
            FileUsingStream fs = new FileUsingStream();
            Console.WriteLine("\n Stream File Created Sucessfully.................");
            fs.FileCreateAndWrite();
            Console.WriteLine("Read file data.......");
            fs.readFileStream();
            
            Console.WriteLine("\n...................");


            StreamWriterClasses streamwriterclasses = new StreamWriterClasses();
            Console.WriteLine("Stream Writer File Created...and Written..");
            streamwriterclasses.FileCreateAndWrite();
            Console.WriteLine("Stream Writer Read file...");
            StreamReadClasses streamreadclasses = new StreamReadClasses();
            streamreadclasses.StreamReads();
            Console.WriteLine("...................");

            BinaryWriterClasses binarywriterclasses = new BinaryWriterClasses();
            binarywriterclasses.BinaryWriteOperation();
            BinaryReadClasses binaryreadclasses = new BinaryReadClasses();
            Console.WriteLine("Binary read file...");
            binaryreadclasses.BinaryReadOperation();

            Console.WriteLine("\n .....FileInfo Class ... ");
            FileInfoClassDemo fileInfoClass = new FileInfoClassDemo();
            fileInfoClass.FileInfoCreateFile();
            fileInfoClass.FileInfoWriteFile();
            fileInfoClass.FileInfoReadFile();

            Console.WriteLine("\n.............................. Directoty Creation and delation");
            DirectoryInfoClass directoryInfoClass = new DirectoryInfoClass();
            directoryInfoClass.CreateDirectory();
            directoryInfoClass.DeleteDirectory();

            Console.WriteLine("\n Working With Text ...........................................................");

            StringTexts texts = new StringTexts();
            texts.ToUpperAndLower();
            texts.GetIndexOf();
            texts.StringToNumberAndNumberTostring();
            texts.checkIsNullOrEmptyAndWhiteSpace();
            texts.CompareString("hello", "Hello");
            texts.Compare2String();

            texts.Concatenate();
            texts.Contain("Singham", "Singh");

            texts.CopyMethod();
            texts.getTypeMethod();

            texts.insertMethod();

            Console.WriteLine("\n String Builder class and methods");

            StringBuilderClassesDemo stringBuilderClassesDemo = new StringBuilderClassesDemo();
            stringBuilderClassesDemo.StringBuilderDemo();

            Console.WriteLine("String Immutable Demo...............................................................");
            StringImmtableDemo stringImmtableDemo = new StringImmtableDemo();
        }
    }
}
