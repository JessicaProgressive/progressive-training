
//namespace StringCalculator;

//public class StringCalculatorTests
//{

//    [Theory]
//    [InlineData("1", 1)]
//    [InlineData("9", 9)]
//    public void OneNumber(string str, int expectedOutput)
//    {
//        var calculator = new StringCalculator();

//        var actualOutput = calculator.Add(str);

//        Assert.Equal(expectedOutput, actualOutput);
//    }

//    [Theory]
//    [InlineData("1, 5", 6)]
//    [InlineData("9, 20", 29)]
//    [InlineData("11, 99", 110)]
//    [InlineData("56, 20", 76)]
//    public void TwoNumbers(string str, int expectedOutput)
//    {
//        var calculator = new StringCalculator();

//        var actualOutput = calculator.Add(str);

//        Assert.Equal(expectedOutput, actualOutput);
//    }

//    [Theory]
//    [InlineData("", 0)]
//    public void EmptyStringReturnsZero(string str, int expectedOutput)
//    {
//        var calculator = new StringCalculator();

//        var actualOutput = calculator.Add(str);

//        Assert.Equal(expectedOutput, actualOutput);
//    }

//    [Theory]
//    [InlineData("12,3,5", 20)]
//    [InlineData("12,3,5,100", 120)]
//    [InlineData("12,3,5,100,230", 350)]
//    public void CalculatesMoreThan2Numbers(string str, int expectedOutput)
//    {
//        var calculator = new StringCalculator();

//        var actualOutput = calculator.Add(str);

//        Assert.Equal(expectedOutput, actualOutput);
//    }

//    [Theory]
//    [InlineData("12\n,5", 17)]
//    public void HandlesNewLinesAsDelimiters(string str, int expectedOutput)
//    {
//        var calculator = new StringCalculator();

//        var actualOutput = calculator.Add(str);

//        Assert.Equal(expectedOutput, actualOutput);
//    }

//    [Theory]
//    [InlineData("12\n,5", 17)]
//    public void HandlesOtherDelimiters(string str, int expectedOutput)
//    {
//        var calculator = new StringCalculator();

//        var actualOutput = calculator.Add(str);

//        Assert.Equal(expectedOutput, actualOutput);
//    }
//}


using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator;

public class StringCalculatPartTwo
{



    [Theory]
    [InlineData("1,2", "3")]
    [InlineData("1,2,3,4,5,6,7,8,9", "45")]
    [InlineData("", "0")]

    public void ResultsAreLogged(string numbers, string message)
    {
        var mockedLogger = new Mock<ILogger>();
        var calculator = new StringCalculator(new Mock<IWebService>().Object, mockedLogger.Object);

        calculator.Add(numbers);

        // Was the logger's write method called with "3"?
        // Hey Logger? How was it in there? Can you verify that your Write method was called with "3"?
        mockedLogger.Verify(m => m.Write(message), Times.Once());
    }

    [Theory]
    [InlineData("1,2", "3")]
    public void LoggerThrows(string number, string message)
    {
        var stubbedLogger = new Mock<ILogger>();
        var mockedWebService = new Mock<IWebService>();
        var calculator = new StringCalculator(mockedWebService.Object, stubbedLogger.Object);
        stubbedLogger.Setup(s => s.Write(It.IsAny<string>())).Throws(new LoggerException(message));

        calculator.Add(number);

        mockedWebService.Verify(m => m.Notify(message), Times.Once());
    }
}
