using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileAndTexts.WorkingWithFiles
{
     public class DirectoryInfoClass
        {
        public void CreateDirectory()
         {
            // Provide directory name with complete location.  
            DirectoryInfo directory = new DirectoryInfo(@"C:\Singh");
            try
            {
                // Check, directory exist or not.  
                if (directory.Exists)
                {
                    Console.WriteLine("Directory already exist.");
                    return;
                }
                // Creating a new directory.  
                directory.Create();
                Console.WriteLine("The directory is created successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Directory not created: {0}", e.ToString());
            }
        }

        public void DeleteDirectory()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Singh");
            try
            {
                // Deleting directory  
                directory.Delete();
                Console.WriteLine("The directory is deleted successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong: {0}", e.ToString());
            }
        }
    }
}
