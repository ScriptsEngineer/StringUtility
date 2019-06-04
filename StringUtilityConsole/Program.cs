using System;

namespace StringUtilityConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("'Hello' init with upper? ");
            bool isUpper = StringUtility.StringUtils.StartWithUpper("Hello");
            Console.WriteLine("Result = "+isUpper);

        }
    }
}
