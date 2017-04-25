using System;

namespace dotnet_deploy
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = string.Empty;
            foreach (string arg in args)
            {
                s += arg + ",";
            }
            Console.WriteLine("Deploy: " + s);
        }
    }
}
