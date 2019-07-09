# MetricUnits_Converter

The goal of this program to convert values from a metric unit to another. You'll need an input file with all the data to convert, the program will create an output file with the processed data.

### Instructions
To be able to use the program you will need to compile the Converter.cs file in Visual Studio.
After starting the program, you must introduce the path where the input file is located. The program will create an output file with the processed data on the same path where the input file is located.

### Input file format

The input file must contain three columns separated by tabulations, which are:

- First column: contains the value to convert.

- Second column: contains from which metric unit you want to convert, it is indicated by placing the abbreviation of it.

- Third column: contains the metric unit to which you want to convert, it is indicated by placing the abbreviation of it.

Here is an example of how the data of the input file should look like:

![Example1](https://raw.githubusercontent.com/Yordi23/MetricUnits_Converter/master/Examples/Example1.PNG)

And here is an example of how the output file should look like:

![Example2](https://raw.githubusercontent.com/Yordi23/MetricUnits_Converter/master/Examples/Example2.PNG)
### Supported Metric Units

Kilometer   =  km

Hectometer  =  hm

Decameter   =  dam

Meter       =  m

Decimeter   =  dm

Centimeter  =  cm

Millimeter  =  mm
 
License
----

MIT
