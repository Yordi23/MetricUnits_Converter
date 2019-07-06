using NUnit.Framework;
using MetricUnits_Converter;
using System.IO;

namespace UnitTests
{
    [TestFixture]
    public class Tests
    {
        Converter converter = new Converter();

        [Test]
        public void Test1()
        {
            Assert.AreEqual(File.ReadAllLines(@"Tests\Test 1\Expected.txt"), converter.Convert(@"Tests\Test 1\Convert.txt"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(File.ReadAllLines(@"Tests\Test 2\Expected.txt"), converter.Convert(@"Tests\Test 2\Convert.txt"));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(File.ReadAllLines(@"Tests\Test 3\Expected.txt"), converter.Convert(@"Tests\Test 3\Convert.txt"));
        }

        [Test]
        public void Test4()
        {
            InvalidFileFormatException exception = Assert.Throws<InvalidFileFormatException>(() => converter.Convert(@"Tests\Test 4\Convert.txt"));
            Assert.AreEqual(exception.Message, "The file with the input data does not have the expected amount of columns");
        }

        [Test]
        public void Test5()
        {
            InvalidFileFormatException exception = Assert.Throws<InvalidFileFormatException>(() => converter.Convert(@"Tests\Test 5\Convert.txt"));
            Assert.AreEqual(exception.Message, "The file with the input data does not have a valid format");
        }

        [Test]
        public void Test6()
        {
            InvalidFileFormatException exception = Assert.Throws<InvalidFileFormatException>(() => converter.Convert(@"Tests\Test 6\Convert.txt"));
            Assert.AreEqual(exception.Message, "The file with the input data contains an invalid Metric Unit");
        }
    }
}
