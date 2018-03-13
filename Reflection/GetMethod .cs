using System;
using System.Reflection;

namespace Reflection
{
    public class GetMethod 
    {
        public static void Print(string name)
        {
            Console.WriteLine(name);
        }

        public static void Getmethod(string value)
        {
            string a = "Print";
            Type type = typeof(GetMethod);
            System.Reflection.MethodInfo info = type.GetMethod(a);

            info.Invoke(null,new object[] { value });

        }


    }
}