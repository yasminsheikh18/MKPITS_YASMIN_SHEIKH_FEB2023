using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__program_to_illustrate_the_enum3
{
    enum days
    {
        // enum data members
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday,
        sunday

    }
    // enum declaration
    enum color
    {

        // enum data members
        Red,
        Yellow,
        Blue,

        // assigning value yellow(1) + 5
        Green = Yellow + 5,
        Brown,

        // assigning value Green(6) + 3
        Black = Green + 3

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstrating the difference " + "between Special Initialisation" +
                                "cases and non-initialisation cases\n\n");

            Console.WriteLine("Value of Monday is " + (int)days.monday);

            Console.WriteLine("Value of Tuesday is " + (int)days.tuesday);

            Console.WriteLine("Value of Wednesday is " + (int)days.wednesday);

            Console.WriteLine("Value of Thursday is " + (int)days.thursday);

            Console.WriteLine("Value of Friday is " + (int)days.friday);

            Console.WriteLine("Value of Saturday is " + (int)days.saturday);

            Console.WriteLine("Value of Sunday is " + (int)days.sunday);

            Console.WriteLine("\n\nColor Enum");

            Console.WriteLine("Value of Red Color is " + (int)color.Red);

            Console.WriteLine("Value of Yellow Color is " + (int)color.Yellow);

            Console.WriteLine("Value of Blue Color is " + (int)color.Blue);

            Console.WriteLine("Value of Green Color is "  + (int)color.Green);

            Console.WriteLine("Value of Brown Color is " + (int)color.Brown);

            Console.WriteLine("Value of Black Color is " + (int)color.Black);

        


    }
}
}
