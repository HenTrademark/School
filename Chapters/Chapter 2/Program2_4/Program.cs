using System;

namespace Program2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables
            const double fencewidth = 1.5;
            double width;
            double length;
            double peri;
            double panels;
            // Lines of text
            Console.WriteLine("Hello and welcome to the Garden Fence Calculator");
            Console.WriteLine("What is the width of your garden (far edge)?");
            width = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the length of your garden (two side edges)?");
            length = double.Parse(Console.ReadLine());
            // Calculate the perimeter
            peri = width + (length * 2);
            // Calculate the panels needed
            panels = peri / fencewidth;
            // And calculate the panels that you need to buy
            int intpanels = (int)Math.Round(panels);
            /*  If intpanels (panels you need to buy) is rounded down
                it then adds 1 to intpanels as to round it up  */
            if (intpanels < panels) {intpanels++;}
            Console.WriteLine("You will need {0} ({1} full) panels for your garden fence",panels, intpanels);
        }
    }
}
