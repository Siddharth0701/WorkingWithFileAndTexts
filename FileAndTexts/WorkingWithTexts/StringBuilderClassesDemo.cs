using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileAndTexts.WorkingWithTexts
{
   public class StringBuilderClassesDemo
    {
        public void StringBuilderDemo()
        {
            var builder = new StringBuilder("Siddharth Singh");
            builder.Append('-',10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            builder.Replace('-', '+');
            builder.Remove(0, 10);
            builder.Insert(0, new string('-', 10));
            Console.WriteLine(builder);

        }

    }
}
