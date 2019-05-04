using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceData.Models
{
    public class Class

    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id
        {
            get; set;
        }
        [BsonRepresentation(BsonType.String)]
        public string Username
        {
            get; set;
        }

        [BsonRepresentation(BsonType.String)]
        public string Password
        {
            get; set;
        }

        public Class(string userName, string password)
        {
            this.Username = userName;
            this.Password = password;
        }

    }
}
