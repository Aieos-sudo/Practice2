using System;

namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double taxrate = 18;
            Console.WriteLine("Pay Check Calculator \n");
            Console.Write("Hours Worked: ");
            string hours = Console.ReadLine();
            double hoursdouble = Double.Parse(hours);
;            Console.Write("Hourly Pay Rate: ");
            string rate = Console.ReadLine();
            double ratedouble = Double.Parse(rate);
            double grosspay = hoursdouble * ratedouble;
            double taxamount = grosspay * (taxrate / 100);
            Console.WriteLine();
            Console.WriteLine("Gross Pay:   " + grosspay);
            Console.WriteLine("Tax Rate:    " + taxrate);
            Console.WriteLine("Tax Amount:  " + taxamount);
            Console.WriteLine("Take Home Pay:   " + (grosspay - taxamount));
        }
    }
}
