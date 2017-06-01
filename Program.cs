using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_Game_Of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counter = 0;
            bool isTrue = true;
            for (int i = secondNum; i >= firstNum; i--)
            {
                for (int j = secondNum; j >= firstNum; j--)
                {
                    counter++;
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {magicNum}");
                       
                        return;
                    }
                 
                 
                }
                
            }
            
            
                Console.Write($"{counter} combinations - neither equals {magicNum}");
            
        }
    }
}
