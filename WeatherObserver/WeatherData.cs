using System;

using WeatherObserver;
using WeatherObserver.Factory;
using WeatherObserver.Observer;
using WeatherObserver.Interface;

namespace WeatherObserver
{
    /// <summary>
    /// This class describes weather data and handles observers to inform them of changes in weather conditions.
    /// </summary>
  
public sealed class WeatherData
{
    private static readonly WeatherData instance = new WeatherData();
    private float temperature;
    public float mintemperature;
    public float maxtemperature;
    private float humidity;
    private float pressure;

    private WeatherData() {}

    public static WeatherData Instance
    {
        get { return instance; }
    }

    public float Temperature { get { return temperature; } }
    public float MinTemperature {get {return mintemperature;}}
    public float MaxTemperature {get {return maxtemperature;}}
    public float Humidity { get { return humidity; } }
    public float Pressure { get { return pressure; } }


    public void UpdateData()
    {
        Random rand = new Random();
        temperature = rand.Next(50, 100);
        mintemperature = rand.Next(50,60);
        maxtemperature = rand.Next(80,100);
        humidity = rand.Next(0, 100);
        pressure = rand.Next(980, 1050);
        NotifyObservers();
    }


    private void NotifyObservers()
    {
        CurrentConditionsDisplay.Instance.Update();
        StatisticsDisplay.Instance.Update();
        ForecastDisplay.Instance.Update();
    }
}
}
