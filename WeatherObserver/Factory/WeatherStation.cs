using WeatherObserver;
using WeatherObserver.Interface;
using WeatherObserver.Observer;

namespace WeatherObserver.Factory
{
    /// <summary>
    /// This class describes a weather station that manages weather data and displays observers.
    /// </summary>

public class WeatherStation
{
    private WeatherData weatherData;

    public WeatherStation()
    {
        weatherData = WeatherData.Instance;
        CurrentConditionsDisplay.Instance.SetWeatherData(weatherData);
        StatisticsDisplay.Instance.SetWeatherData(weatherData);
        ForecastDisplay.Instance.SetWeatherData(weatherData);
    }

    public IDisplay CreateDisplay(string type)
    {
        switch (type)
        {
            case "CurrentConditions":
                return CurrentConditionsDisplay.Instance;
            case "Statistics":
                return StatisticsDisplay.Instance;
            case "Forecast":
                return ForecastDisplay.Instance;
            default:
                throw new ArgumentException("Invalid display type");
        }
    }
}
}
