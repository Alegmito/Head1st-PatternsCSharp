using Observer_WeatherORama.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_WeatherORama.Observer
{
    public class StatisticsDisplay : IDisplayElement, IWeatherDisplay
    {
        public int MaxTemp { get; private set; } = 0;
        public int MinTemp { get; private set; } = 0;
        public uint NumberOfMeasurments { get; private set; } = 0;
        public int AvgTemp { get; private set; } = 0;
        public void Display()
        {
            Console.WriteLine("Statistics display:");
            Console.WriteLine($"Max temperature is: {MaxTemp}");
            Console.WriteLine($"Min temperature is: {MinTemp}");
            Console.WriteLine($"Average temperature is: {AvgTemp}");
        }

        public void Update(in WeatherStation weatherStation)
        {
            if(weatherStation.Temperature < MaxTemp)
                MaxTemp = weatherStation.Temperature;

            if(weatherStation.Temperature > MinTemp)
                MinTemp = weatherStation.Temperature;

            NumberOfMeasurments++;

            AvgTemp = (int)(AvgTemp * (NumberOfMeasurments - 1) / NumberOfMeasurments + weatherStation.Temperature / NumberOfMeasurments);

            Display();
        }
    }
}
