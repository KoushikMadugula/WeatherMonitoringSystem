using WeatherObserver;
using WeatherObserver.Factory;
using WeatherObserver.Interface;
using WeatherObserver.Observer;

namespace WeatherMonitorSystem
{
class Program
{
    static void Main(string[] args)
    {
        WeatherStation weatherStation = new WeatherStation();
        
        IDisplay currentConditionsDisplay = weatherStation.CreateDisplay("CurrentConditions");
        IDisplay statisticsDisplay = weatherStation.CreateDisplay("Statistics");
        IDisplay forecastDisplay = weatherStation.CreateDisplay("Forecast");

        // Simulate data updates
        WeatherData.Instance.UpdateData();
    }
}
}