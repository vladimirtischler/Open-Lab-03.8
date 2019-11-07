using System;


namespace Open_Lab_03_8
{
    class Program
    {
        public static bool IsPlural(string word)
        {
            return word.EndsWith("s");
        }


        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            Console.WriteLine(IsPlural(a));
        }
    }
}