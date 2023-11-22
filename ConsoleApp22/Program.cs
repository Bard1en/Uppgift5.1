using System;
namespace uppgift5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in 5 namn");
            string[] namn = new string[5];
            for (int i = 0; i < 5; i++)
            {
                namn[i] = Console.ReadLine();
            }  
            for(int a = 0; a < 5; a++)
            {
                Console.WriteLine(namn[a]);
            }
            
        }
    }
}

