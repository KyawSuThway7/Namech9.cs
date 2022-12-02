using System;


namespace Namech9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your name?");
                Console.Write("Name : ");
                string name1 = Console.ReadLine();
                foreach (char a in name1)
                {
                    if (a >= 'a' && a <= 'z' || a >= 'A' && a <= 'Z'||a<=' ')
                    {
                       
                    }               
                    else
                    {
                        throw new ArgumentException("You input must be consonant");
                    }
                    
                }
                Console.Write(" Your name : " + name1);
            }
            catch
            {
                Console.WriteLine("Error !!!Your input must be consonant");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to close the window");
            Console.ReadKey();
        }
    }
}
