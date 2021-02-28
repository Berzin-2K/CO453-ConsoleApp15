using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject
{
    public static class ConsoleHelper
    {

        public static void OutputHeading(String title)
        {
            Console.WriteLine(" .................................. ");
            Console.WriteLine(title);
            Console.WriteLine(" .................................. ");

        }
        public static void OutputIntroduction(string introduction)
        {
            Console.WriteLine(" ==== Introduction ==== ");
            Console.WriteLine(introduction);
        }
}
