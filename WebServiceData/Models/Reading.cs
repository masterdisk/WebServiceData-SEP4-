using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceData.Models
{
    public class Reading
    {
        [BsonRepresentation(BsonType.Double)]
        private double Temperature { get; set; }
        [BsonRepresentation(BsonType.Double)]
        private double CO2 { get; set; }
        [BsonRepresentation(BsonType.Double)]
        private double Humidity { get; set; }
        [BsonRepresentation(BsonType.Double)]
        private double AmountOfWater { get; set; }
        [BsonRepresentation(BsonType.Double)]
        private double HoursSinceWatering { get; set; }

        public Reading(double temperature, double CO2, double humidity, double amountofWater, double hoursSinceWatering)
        {
            this.Temperature = temperature;
            this.CO2 = CO2;
            this.Humidity = humidity;
            this.AmountOfWater = AmountOfWater;
            this.HoursSinceWatering = hoursSinceWatering;
        }

        public double getTemperature()
        {
            return Temperature;
        }

        public void setTemperature(double temperature)
        {
            this.Temperature = temperature;
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
            return Humidity;
        }

        public void setHumidity(double humidity)
        {
            this.Humidity = humidity;
        }

        public double getAmountOfWater()
        {
            return AmountOfWater;
        }

        public void setAmountOfWater(double amountOfWater)
        {
            this.AmountOfWater = amountOfWater;
        }

        public double getHoursSinceWatering()
        {
            return HoursSinceWatering;
        }

        public void setHoursSinceWatering(double hoursSinceWatering)
        {
            this.HoursSinceWatering = hoursSinceWatering;
        }



    }


}
