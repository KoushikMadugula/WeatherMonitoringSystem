using WeatherObserver;
using WeatherObserver.Factory;
using WeatherObserver.Interface;

namespace WeatherObserver.Observer
{
    /// <summary>
    /// This class describes the forecast display and implements the IDisplay interface. It provides methods to show the forecast based on temperature conditions.
    /// </summary>

public sealed class ForecastDisplay : IDisplay
{
    private static readonly ForecastDisplay instance = new ForecastDisplay();
    private WeatherData weatherData;

    private ForecastDisplay() {}

    public static ForecastDisplay Instance
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
        if(weatherData.Temperature > 80)
        {
           Console.WriteLine("Forecast : Temperature is slightly higher today");
        }
        else if(weatherData.Temperature <60)
        {
            Console.WriteLine("Forecast : Temperature is very cold today");
        }
        else{
            Console.WriteLine("Forecast : Temperature is mild today");
        }
    }
}
}
