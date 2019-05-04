using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceData.Models
{
    public class Account
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id
        {
            get; set;
        }
        [BsonRepresentation(BsonType.String)]
        private string Username;
        [BsonRepresentation(BsonType.String)]
        private string Password;
        [BsonRepresentation(BsonType.Array)]
        private List<PlantProfile> plantProfiles;

        public Account(string userName, string password)
        {
            this.Username = userName;
            this.Password = password;
            plantProfiles = new List<PlantProfile>();
        }

        public string getUserName()
        {
            return Username;
        }

        public void setUserName(string userName)
        {
            this.Username = userName;
        }

        public string getPassword()
        {
            return Password;
        }

        public void setPassword(string password)
        {
            this.Password = password;
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

    }
}
