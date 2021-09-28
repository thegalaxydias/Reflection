using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Type a = typeof(String);           
            PropertyInfo[] prop = a.GetProperties();
            foreach (var p in prop)
            {
            Console.WriteLine(p);
            }


        }
    }
}
