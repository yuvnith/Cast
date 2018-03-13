using System;
using System.Reflection;

namespace Reflection
{
    public class FieldsRetrieval
    {
        public static int a=1;
        public static string name="abcd";
        
        public static void GetFields()
        {
            Type type = typeof(FieldsRetrieval);
            FieldInfo[] fields = type.GetFields();
            
            foreach (var field in fields) 
            {
                string name = field.Name; 
                object temp = field.GetValue(null); 
                if (temp is int) 
                {
                    int value = (int)temp;
                    Console.Write(name+" ");
                    Console.Write(temp.GetType());
                    Console.Write(" (int) = ");
                    Console.WriteLine(value);
                }
                else if (temp is string) 
                {
                    string value = temp as string;
                    Console.Write(name + " ");
                    Console.Write(temp.GetType());
                    Console.Write(" (string) = ");
                    Console.WriteLine(value);
                }
            }
        }
        
    }
}