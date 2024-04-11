using WeatherObserver;
using WeatherObserver.Factory;
using WeatherObserver.Interface;

namespace WeatherObserver.Observer
{   
    /// <summary>
    /// This class describes a statistics display for weather data and implements the IDisplay interface. It displays statistics such as average, maximum, and minimum temperatures.
    /// </summary>

public sealed class StatisticsDisplay : IDisplay
{
    private static readonly StatisticsDisplay instance = new StatisticsDisplay();
    private WeatherData weatherData;

    private StatisticsDisplay() {}

    public static StatisticsDisplay Instance
    {
        get { return instance; }
    }

    public void SetWeatherData(WeatherData data)
    {
        weatherData = data;
    }

    public void Update()
    {
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Statistics: Average Temperature - {weatherData.Temperature}, Max Temperature - {weatherData.MaxTemperature}, Min Temperature - {weatherData.MinTemperature}");
    }
}
}
