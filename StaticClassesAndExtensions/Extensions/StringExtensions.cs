using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesAndExtensions.Extensions
{
    static class SecondStaticClass
    {
        /// <summary>
        /// Creating an extension for class String
        /// </summary>
        /// <param name="text">Given text</param>
        /// <param name="textForPrint">Given text for realisation</param>
        public static void PrintStringExtension(this String text, String textForPrint)
        {
            Console.WriteLine(textForPrint);
        }
    }
}
