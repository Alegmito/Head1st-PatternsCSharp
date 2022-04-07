using Observer_WeatherORama.Observer;
using Observer_WeatherORama.Subject;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

WeatherStation ws = new WeatherStation();

CurrentMeasuremtns currMesDisplay = new CurrentMeasuremtns();
StatisticsDisplay statsDisplay = new StatisticsDisplay();

ws.AddObserver(currMesDisplay);
ws.AddObserver(statsDisplay);

ws.UpdateMeasurements(10, 29, 39);

ws.UpdateMeasurements(50, 13, 35);
