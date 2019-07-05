using System;

namespace MetricUnits_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter();
            Console.WriteLine("Please, type the path of the file that contains the input data");
            converter.Convert(Console.ReadLine());
            converter.WriteOutput();
        }
    }
}
