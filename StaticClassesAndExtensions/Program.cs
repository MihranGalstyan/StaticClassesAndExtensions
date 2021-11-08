using System;
using StaticClassesAndExtensions.Extensions;

namespace StaticClassesAndExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // not working creation of static class object
            // StaticClass newStatic = new StaticClass();

            // working call of static method of static slass;
            StaticClass.PrintFunc();
            StaticClass.ModFunc();

            // working value assignment of static variable of static class
            StaticClass.firstVariable = 0;

            // using an extension for "String"
            String longText = "default text";
            longText.PrintStringExtension("Extension text");

        }

        public static class StaticClass
        {
            /// <summary>
            /// static variable
            /// </summary>
            public static int firstVariable;

            /// <summary>
            /// Static void method
            /// </summary>
            public static void PrintFunc()
            {
                Console.WriteLine($"Here is value of static variable: {firstVariable}");
            }

            /// <summary>
            /// Static method
            /// </summary>
            /// <returns>Integer value</returns>
            public static int ModFunc()
            {
                if (firstVariable == 0)
                {
                    return firstVariable;
                }
                return default(int);
            }

            /// <summary>
            /// Static constructor
            /// </summary>
            static StaticClass()
            {
                firstVariable = 15;
            }
        }
    }

}
