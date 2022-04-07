using Observer_WeatherORama.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_WeatherORama.Observer
{
    public  interface IWeatherDisplay
    {
        public abstract void Update(in WeatherStation weatherStation);
    }
}
