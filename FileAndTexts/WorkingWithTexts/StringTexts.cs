using System;
using System.Collections.Generic;
using System.Text;

namespace FileAndTexts.WorkingWithTexts
{
    public class StringTexts
    {
        string s1 = "Hello";
        string s2 = "hello";
        string fullname = "Siddharth Singh";

        public void ToUpperAndLower()
        {
            Console.WriteLine("Formattion of strings.......");
            Console.WriteLine("Lower case : " + s1.ToLower());
            Console.WriteLine("Upper case : " + s1.ToUpper());
            Console.WriteLine("Trim '{0}'",fullname.Trim());
        }
        public void CompareString( string s1, string s2)
        {
            Console.WriteLine("If both strings are equal, it returns 0. If first string is greater than second string, it returns 1 else it returns -1.");
            Console.WriteLine("Compare two variable is: " + string.Compare(s1, s2));
        }
        public void Compare2String()
        {
            Console.WriteLine("Compare using ComapreTo method : "+s1.CompareTo(s2));
          }
        
        public void Concatenate()
        {
            Console.WriteLine("using Concat method");
            Console.WriteLine("concatenate of two string"+string.Concat(s1,s2));
            Console.WriteLine("using plus operator ");
            Console.WriteLine("concatenate of two string: " +s1 +""+s2);
        }
        public void Contain(string s1, string s2)
        {
            Console.WriteLine("Contain method : "+s1.Contains(s2));
        }

        public void CopyMethod()
        {
            Console.WriteLine("Copy method");
            string m1 = "hello";
            string m2 = string.Copy(m1);
            Console.WriteLine("Original texts"+m1);
            Console.WriteLine( "Copy texts"+m2);
        }
        public void getTypeMethod()
        {
            Console.WriteLine("GetType method : "+s1.GetType());
        }
        public void GetIndexOf()
        {
            int index = s1.IndexOf('l');
            Console.WriteLine("index of texts l is : "+index);
        }
        public void insertMethod()
        {
            string str = "Hello C#";
            string str1 = s1.Insert(5, "-");
            Console.WriteLine(str1);
        }


    }
}
