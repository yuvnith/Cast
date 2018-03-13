using System;
using System.Reflection;

namespace Reflection
{
    public class Bike
    {
        public static void Print()
        {
            Console.WriteLine("0 param Bike method ");
        }

         static int Print2(int a )
        {
            Console.WriteLine("one int param Bike method  ");
            return 0;
        }
        public static void Bind()
        {
            Type type = typeof(Bike);

            //t.InvokeMember("SayHello", BindingFlags.InvokeMethod | BindingFlags.Public |
            //                           BindingFlags.Static, null, null, new object[] { });


            type.InvokeMember("Print", BindingFlags.InvokeMethod, null, null, new object[] { });

            type.InvokeMember("Print2", BindingFlags.InvokeMethod | BindingFlags.Public, null, null, new object[] {2 });
        }
    }
}