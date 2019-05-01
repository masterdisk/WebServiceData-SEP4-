using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceData.Models
{
    public class Reading
    {
        private double temperature { get; set; }
        private double CO2 { get; set; }
        private double humidity { get; set; }
        private double amountOfWater { get; set; }
        private double hoursSinceWatering { get; set; }

        public Reading(double temperature, double CO2, double humidity, double amountofWater, double hoursSinceWatering)
        {
            this.temperature = temperature;
            this.CO2 = CO2;
            this.humidity = humidity;
            this.amountOfWater = amountOfWater;
            this.hoursSinceWatering = hoursSinceWatering;
        }

        public double getTemperature()
        {
            return temperature;
        }

        public void setTemperature(double temperature)
        {
            this.temperature = temperature;
        }

        public double getCO2()
        {
            return CO2;
        }

        public void setCO2(double CO2)
        {
            this.CO2 = CO2;
        }

        public double getHumidity()
        {
            return humidity;
        }

        public void setHumidity(double humidity)
        {
            this.humidity = humidity;
        }

        public double getAmountOfWater()
        {
            return amountOfWater;
        }

        public void setAmountOfWater(double amountOfWater)
        {
            this.amountOfWater = amountOfWater;
        }

        public double getHoursSinceWatering()
        {
            return hoursSinceWatering;
        }

        public void setHoursSinceWatering(double hoursSinceWatering)
        {
            this.hoursSinceWatering = hoursSinceWatering;
        }



    }


}
