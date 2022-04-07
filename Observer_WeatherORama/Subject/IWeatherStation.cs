using Observer_WeatherORama.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_WeatherORama.Subject
{
    public interface IWeatherStation
    {
        public void AddObserver(IWeatherDisplay displayAdd);
        public void RemoveObserver(IWeatherDisplay displayRemove);
        public void NotifyObservers();
    }
}
