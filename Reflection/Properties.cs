using System;
using System.Reflection;

namespace Reflection
{
    public class Properties
    {
        public int Age { get; set; }
        public String Name { get; set; }




        public static void DisplayDetails()
        {
            Properties properties = new Properties();
            properties.Age = 20;
            properties.Name = "abc";

            Type type = typeof(Properties);

            PropertyInfo[] infos = type.GetProperties();


            foreach (PropertyInfo info in infos)
            {
                object value = info.GetValue(properties, null);
                if (value is int)
                {
                    Console.WriteLine("int value :" +value );
                }
                else
                {
                    Console.WriteLine("string value :" +value);
                }
            }
        }
    }
}