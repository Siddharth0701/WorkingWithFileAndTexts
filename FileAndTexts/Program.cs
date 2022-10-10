using FileAndTexts.WorkingWithFiles;
using System;

namespace FileAndTexts
{
    class Program
    {
        static void Main(string[] args)
        {
            FileUsingStream fs = new FileUsingStream();
            //fs.CommonMethodOfFileCreation();
            fs.WriteFile();
            fs.ReadFile();
            

            StreamWriterClasses streamWriterClasses = new StreamWriterClasses();
            streamWriterClasses.FileCreateAndWrite();
            StreamReadClasses streamReadClasses = new StreamReadClasses();
            streamReadClasses.StreamReads();

            BinaryWriterClasses binaryWriterClasses = new BinaryWriterClasses();
            binaryWriterClasses.BinaryWriteOperation();
            BinaryReadClasses binaryReadClasses = new BinaryReadClasses();
            binaryReadClasses.BinaryReadOperation();


        }
    }
}
