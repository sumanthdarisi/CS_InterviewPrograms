using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of testcases");
            int testCases = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the testcases, 2 letter combo");
            List<string> inputs = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                Console.WriteLine($"Enter {i+1} test case now");
                inputs.Add(Console.ReadLine());
            }
            foreach (string ip in inputs)
            {
                Console.Write(ip + " ");
            }
            Console.WriteLine("");
            RPS(inputs);
            Console.ReadKey();
        }


        static public void RPS(List<string> input)
        {
            foreach (string ip in input)
            {
                if (ip.ToUpper() == "RR" || ip.ToUpper() == "SS" || ip.ToUpper() == "PP")
                {
                    Console.WriteLine($"{ip.ToUpper()}: Sorry, It's a Draw");
                }
                else
                {
                    switch (ip.ToUpper())
                    {
                        case "RP":
                            Console.WriteLine($"{ip.ToUpper()}: paper WON");
                            break;
                        case "RS":
                            Console.WriteLine($"{ip.ToUpper()}: Rock won");
                            break;
                        case "PS":
                            Console.WriteLine($"{ip.ToUpper()} :Scissors Won");
                            break;
                        case "PR":
                            Console.WriteLine($"{ip.ToUpper()}: paper WON");
                            break;
                        case "SP":
                            Console.WriteLine($"{ip.ToUpper()} :Scissors Won");
                            break;
                        case "SR":
                            Console.WriteLine($"{ip.ToUpper()}: Rock won");
                            break;
                        default:
                            Console.WriteLine("Invalid entry, give 2 letter combination from R,P,S only");
                            break;
                    }
                }
            }
        }
    }
}
