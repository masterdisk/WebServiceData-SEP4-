using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceData.Models
{
    public class PlantProfile
    {
        private  String plantName { get; set; }
        private int plantID { get; set; }
        private List<Reading> readings;

        public PlantProfile(int plantID, String plantName)
        {
            this.plantID = plantID;
            this.plantName = plantName;
            readings = new List<Reading>();

        }

        public String getPlantName()
        {
            return plantName;
        }

        public void setPlantName()
        {
            this.plantName = plantName;
        }

        public int getPlantID()
        {
            return plantID;
        }

        public void setPlantID()
        {
            this.plantID = plantID;
        }

        public void addReading(Reading reading)
        {
            readings.Add(reading);
        }

        public Reading getAllReadings()
        {
            for (int i = 0; i < readings.Count; i++)
            {
                return readings[i];
            }
            return null;
        }
        
    }
}
