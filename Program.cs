using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables 
            int side1, side2;
            //prompts user for lengths
            Console.WriteLine("Please enter a length for the first side: ");
            //captures and converts type string user input to type int
            side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a length for the second side: ");
            side2 = Convert.ToInt32(Console.ReadLine());
            Hypotenuse hypo = new Hypotenuse(side1, side2); //instantiate
            hypo.CalculateHypotenuse(side1, side2); //call function
            //displays hypotenuse rounded off to two decimal places  
            Console.WriteLine("The hypotenuse = " + hypo.side3);
            Console.ReadLine();
        }
    }
}
