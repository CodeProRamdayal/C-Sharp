using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.Methods
{
    internal class WeatherStationSimulator
    {
        internal void WaatherCondition()
        {
            Console.WriteLine("Enter the number of days:");
            int days = int.Parse(Console.ReadLine());
            int[] temperature = new int[days];
            string[] conditions = {"Sunny", "Cloudy", "Rainy", "Snowy", "Windy" };
            string[] weatherConditons = new string[days];

            Random random = new Random();
            for(int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40);
                weatherConditons[i] = conditions[random.Next(conditions.Length)];
            }
            Console.WriteLine("Weather Conditions:");
            for(int i = 0; i < days; i++)
            {
                Console.WriteLine($"Day {i + 1}: Temperature: {temperature[i]}°C, Condition: {weatherConditons[i]}");
            }
            double averageTemperature = CalculateAvarageTemperature(temperature);
            Console.WriteLine($"Average Temperature: {averageTemperature:F2}°C");
            string mostFrequentCondition = FindFrequenceofWeatherCOnditoon(weatherConditons);
            Console.WriteLine($"Most Frequent Condition: {mostFrequentCondition}");

        }
   
        private double CalculateAvarageTemperature(int[] tempatures)
        {
            
            int sum = 0;
            for(int i = 0; i < tempatures.Length; i++)
            {
                sum += tempatures[i];
            }
            double avarage = (double)sum / tempatures.Length;
            return avarage;
        }
    
        private string FindFrequenceofWeatherCOnditoon(string[] weatherConditions)
        {
            int count = 0;
            string commonCondition = weatherConditions[0];
            for(int i = 0; i < weatherConditions.Length; i++)
            {
                int tempCount = 0;
                for(int j = 0; j < weatherConditions.Length; j++)
                {
                    if(weatherConditions[j] == commonCondition)
                    {
                        tempCount++;
                    }
                }
                if(tempCount > count)
                {
                    count = tempCount;
                    commonCondition = weatherConditions[i];
                }
            }
            return commonCondition;

        }
   
    
    }
}
