using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("How many times?");
            
            int? times = null;
            do {
                string line = Console.ReadLine();    
                times = new Parser().Parse(line);
                if(times == null) {
                    Console.WriteLine("Please enter a valid int");
                }
            }while(times ==null);
        
            for(var i=0;i<times;i++){
                Console.WriteLine("Hello, world!");
            }
        }
    }
}
