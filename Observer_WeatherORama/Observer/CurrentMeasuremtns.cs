using Observer_WeatherORama.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_WeatherORama.Observer
{
    public class CurrentMeasuremtns : IWeatherDisplay, IDisplayElement
    {
        public int Temperature { get; private set; }
        public int Pressure { get; private set; }
        public int Humidity { get;private set; }

        public void Update(in WeatherStation weatherStation)
        {
            Temperature = weatherStation.Temperature;
            Pressure = weatherStation.Pressure;
            Humidity = weatherStation.Humidity;

            Display();
        }

        public virtual void Display()
        {
            Console.WriteLine("CurrentMeasurments display:");
            Console.WriteLine($"Current temperature is: {Temperature}");
            Console.WriteLine($"Current Pressure is: {Pressure}");
            Console.WriteLine($"Current Humidity is: {Humidity}");
        }
    }
}
