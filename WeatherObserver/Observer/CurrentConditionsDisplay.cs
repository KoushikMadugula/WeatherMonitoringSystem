using WeatherObserver;
using WeatherObserver.Factory;
using WeatherObserver.Interface;

namespace WeatherObserver.Observer
{
    /// <summary>
    /// This class describes the current weather conditions display. It implements the IDisplay interface to provide a method for displaying the current temperature, humidity, and pressure.
    /// </summary>

public sealed class CurrentConditionsDisplay : IDisplay
{
    private static readonly CurrentConditionsDisplay instance = new CurrentConditionsDisplay();
    private WeatherData weatherData;

    private CurrentConditionsDisplay() {}

    public static CurrentConditionsDisplay Instance
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

    /// <summary>
    /// Displays the current weather conditions including temperature, humidity, and pressure.
    /// </summary>

    public void Display()
    {
        Console.WriteLine($"Current conditions: Temperature - {weatherData.Temperature}℉, Humidity - {weatherData.Humidity}%, Pressure - {weatherData.Pressure}Pa");
    }
}
}
