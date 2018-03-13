using System;
using System.Reflection;

namespace Reflection
{
    public class SetValue
    {
        public static  int a;

        public static void Set(int aa)
        {
            Type type = typeof(SetValue);

            FieldInfo field = type.GetField("a");

            field.SetValue(null,aa);

           
            Console.WriteLine(a);


        }

        
    }
}