using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public class Program
    {
        
    static void Main(string[] args)
        {
            calcWeight W_Male = new calcWeight
            {
                hight = 170,
                gender = 'M'
            };
            double weightOfMale = W_Male.claculationWeight();
            Console.WriteLine($"Weight Of Male = {weightOfMale}");
            if (weightOfMale == 65)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Test Of Male Succeeded");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Test Of Male failed");
            }

            calcWeight W_Female = new calcWeight
            {
                hight = 176,
                gender = 'F'
            };
            double weightOfFemale = W_Female.claculationWeight();
            Console.WriteLine($"Weight Of Female ={weightOfFemale}");


            calcWeight W_AnyChar = new calcWeight
            {
                hight = 176,
                gender = 'Z'
            };
            double clacAnyWeight = W_AnyChar.claculationWeight();
            Console.WriteLine($"Weight for Zero ={clacAnyWeight}");

            Console.ReadKey();


        }
    }
}
