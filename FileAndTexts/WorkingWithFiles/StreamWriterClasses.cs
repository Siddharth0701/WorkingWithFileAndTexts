using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileAndTexts.WorkingWithFiles
{
   public  class StreamWriterClasses
    {
        public void FileCreateAndWrite()
        {
            FileStream f = new FileStream(@"C:\Users\siddh\source\repos\WorkingWithFileAndTexts\FileAndTexts\WorkingWithFiles\Output.txt", FileMode.Create);
            StreamWriter s = new StreamWriter(f);

            s.WriteLine("hello c#");
            s.Close();
            f.Close();
            Console.WriteLine("File created successfully...");
        }


    }
}
