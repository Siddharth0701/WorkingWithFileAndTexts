using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileAndTexts.WorkingWithFiles
{
    public class StreamReadClasses
    {
        public  void StreamReads()
        {
            FileStream f = new FileStream(@"C:\Users\siddh\source\repos\WorkingWithFileAndTexts\FileAndTexts\WorkingWithFiles\Output.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);

            string line = s.ReadLine();
            Console.WriteLine(line);

            s.Close();
            f.Close();
        }
    }
}
