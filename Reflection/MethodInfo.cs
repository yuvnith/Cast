using System;
using System.Reflection;

namespace Reflection
{
    public class MethodInfo
    {
        public static void car(string n)
        {
            Console.WriteLine(n +" car");
        }
        public static void bike(string n)
        {
            Console.WriteLine(n + " bike");
        }
        public static void bus(string n)
        {
            Console.WriteLine(n + " bus");
        }



        public static void getinfo()
        {

            MethodInfo obj = new MethodInfo();
            
            Type type = typeof(MethodInfo);

            System.Reflection.MethodInfo[] methods = type.GetMethods();

            foreach (var method  in methods)
            {
                method.Invoke(null, new object[] {"vamshi"});
            }



        }
    }
}