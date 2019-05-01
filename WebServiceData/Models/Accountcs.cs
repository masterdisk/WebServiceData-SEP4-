using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceData.Models
{
    public class Account
    {
        private String userName;
        private String password;
        private List<PlantProfile> plantProfiles ;

        public Account(String userName, String password)
        {
            this.userName = userName;
            this.password = password;
            plantProfiles = new List<PlantProfile>();
        }

        public String getUserName()
        {
            return userName;
        }

        public void setUserName(String userName)
        {
            this.userName = userName;
        }

        public String getPassword()
        {
            return password;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }

        public void addPlantProfile(PlantProfile profile)
        {
            plantProfiles.Add(profile);
        }

        public PlantProfile getAllPlantProfiless()
        {
            for (int i = 0; i < plantProfiles.Count; i++)
            {
                return plantProfiles[i];
            }
            return null;
        }

        public PlantProfile getPlantByID(int id )
        {
            for (int i = 0; i < plantProfiles.Count; i++)
            {
                if(id == plantProfiles[i].getPlantID())
                    {
                    return plantProfiles[i];
                }

            }

            return null;
        }


    }
}
