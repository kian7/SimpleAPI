using SimpleAPI.Controllers;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Test;

public class UnitTest1
{

    [Fact]
    public void Test_TestReturnValue()
    {
        using var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        var logger = loggerFactory.CreateLogger<WeatherForecastController>();

        WeatherForecastController  tcoltroller = new WeatherForecastController(logger);

        var returnValue = tcoltroller.Test();
        //var returnValue = "TempStr";
    
        //Assert.Equal("Hello, World!", returnValue);
        Assert.Equal("test", returnValue);

    }

    [Fact]
    public void Test_GetReturnValue()
    {
        using var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        var logger = loggerFactory.CreateLogger<WeatherForecastController>();

        WeatherForecastController  tcoltroller = new WeatherForecastController(logger);

        IEnumerable<WeatherForecast> returnValues = tcoltroller.Get();
        //var returnValue = "TempStr";

        bool checkOK = false;

        foreach (WeatherForecast cweather in returnValues)
        {
            //Console.WriteLine(cweather.TemperatureC);
            checkOK = cweather.TemperatureC > 10;

        }

        Assert.True(checkOK, "Great!");

    }    


    [Fact]
    public void Test1()
    {

    }
}