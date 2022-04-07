using Observer_WeatherORama.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_WeatherORama.Subject
{
    public class WeatherStation : IWeatherStation
    {
        // observers
        private List<IWeatherDisplay> Displays { get; set; } = new List<IWeatherDisplay>();
        //weather props
        public int Temperature { get; private set; } = 0;
        public int Humidity { get; private set; } = 0;
        public int Pressure { get;private set; } = 0;

        public void UpdateMeasurements(int temperature, int humidity, int pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;

            NotifyObservers();
        }
        public void NotifyObservers()
        {
            foreach (var display in Displays)
            {
                display.Update(this);
            }
        }
        public void AddObserver(IWeatherDisplay displayAdd)
        {
            Displays.Add(displayAdd);
        }
        public void RemoveObserver(IWeatherDisplay displayRemove)
        {
            Displays.Remove(displayRemove);
        }
    }
}
