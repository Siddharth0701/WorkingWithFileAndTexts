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
            Console.WriteLine("\n Formattion of strings.......");
            Console.WriteLine("Lower case : " + s1.ToLower());
            Console.WriteLine("Upper case : " + s1.ToUpper());
            Console.WriteLine("Trim '{0}'",fullname.Trim());
        }
        public void GetIndexOf()
        {
            Console.WriteLine("\n Searching ........................... And SubString");
            int index = s1.IndexOf('l');
            Console.WriteLine("index of texts l is : " + index);
            Console.WriteLine("Last index of Hello:"+s1.LastIndexOf('l'));
            string str = fullname.Substring(9);
            Console.WriteLine("Substring of fullname is: "+str);
        }

        public void StringToNumberAndNumberTostring()
        {
            Console.WriteLine("\n String to number and number to string..............");
            string str = "32";
            int i = Convert.ToInt32(str);
            Console.WriteLine("String to Number: " + i);
            Console.WriteLine("Number to String: " + i.ToString());
        }
        public void checkIsNullOrEmptyAndWhiteSpace()
        {
            Console.WriteLine(" \n Is null or white space in string.......");
            bool l1 = string.IsNullOrEmpty(s2);
            Console.WriteLine("Is Null or empty of string"+l1);
            bool l2 = string.IsNullOrWhiteSpace(fullname);
            Console.WriteLine("Is Null or White Space of string" + l2);

        }

 
        public void CompareString( string s1, string s2)
        {
            Console.WriteLine("\n Compare two string");
            Console.WriteLine("If both strings are equal, it returns 0. If first string is greater than second string, it returns 1 else it returns -1.");
            Console.WriteLine("Compare two variable is: " + string.Compare(s1, s2));
        }
        public void Compare2String()
        {
            Console.WriteLine("\n CompareTo Method.");
            Console.WriteLine("Compare using ComapreTo method : "+s1.CompareTo(s2));
          }
        
        public void Concatenate()
        {
            Console.WriteLine("\n String Concat method");
            Console.WriteLine("using Concat method");
            Console.WriteLine("concatenate of two string"+string.Concat(s1,s2));
            Console.WriteLine("using plus operator ");
            Console.WriteLine("concatenate of two string: " +s1 +""+s2);
        }
        public void Contain(string s1, string s2)
        {
            Console.WriteLine("\n Contain Mehod");
            Console.WriteLine("Contain method : "+s1.Contains(s2));
        }

        public void CopyMethod()
        {
            Console.WriteLine("\n Copy method");
            string m1 = "hello";
            string m2 = string.Copy(m1);
            Console.WriteLine("Original texts"+m1);
            Console.WriteLine( "Copy texts"+m2);
        }
        public void getTypeMethod()
        {
            Console.WriteLine("\n Get Type method...");
            Console.WriteLine("GetType method : "+s1.GetType());
        }
        
        public void insertMethod()
        {
            Console.WriteLine("\n Insert method...");
            string str = "Hello C#";
            string str1 = s1.Insert(5, "-");
            Console.WriteLine(str1);
        }


        


    }
}
