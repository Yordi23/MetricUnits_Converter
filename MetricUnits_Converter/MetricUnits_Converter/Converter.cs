using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MetricUnits_Converter
{
    public class InvalidFileFormatException : Exception { public InvalidFileFormatException(string message) : base(message) { } };

    public class Converter
    {
        string[] data;
        string path;

        public string[] Convert(string path)
        {
            data = File.ReadAllLines(path);
            this.path = path;

            for (int i=0; i< data.Length; i++)
            {
                string[] line = data[i].Split('\t');
                if (line.Length != 3) throw new InvalidFileFormatException("The file with the input data does not have the expected amount of columns");
                data[i] += "\t" + Calculate(line);
            }

            return data;
        }

        private double Calculate(string[] line)
        { /*
            Kilometer   =  km
            Hectometer  =  hm
            Decameter   =  dam
            Meter       =  m
            Decimeter   =  dm
            Centimeter  =  cm
            Millimeter  =  mm
          */

            string[] metricUnits = { "km", "hm", "dam", "m", "dm", "cm", "mm"};
            int from = -1, to = -1, remainder = 0;
            double result;
            try {  result = double.Parse(line[0]); }

            catch (Exception e)
            {
                throw new InvalidFileFormatException("The file with the input data does not have a valid format");
            }

            for (int i = 0; i < metricUnits.Length; i++)
            {
                if (line[1] == metricUnits[i]) from = i;
                if (line[2] == metricUnits[i]) to = i;
            }

            if (from == -1 || to == -1 ) throw new InvalidFileFormatException("The file with the input data contains an invalid Metric Unit");

            remainder = from - to;

            if (remainder== 0) return double.Parse(line[0]);

            if (remainder < 0)
            {
                for (int i = 0; i < Math.Abs(remainder); i++)
                    result *= 10;
            }
            else if (remainder > 0)
            {
                for (int i = 0; i < Math.Abs(remainder); i++)
                    result /= 10;
            }

            return result;
        }

        private string TrimPath(string path)
        {
            for (int i = path.Length - 1; ; i--)
                if (path[i] == '\\') return path.Remove(i);         
        }

        public void WriteOutput()
        {
            File.WriteAllLines(TrimPath(this.path) + "\\Output.txt", data);
        }


    }
}
