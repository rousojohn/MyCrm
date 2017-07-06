using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MyCrm.Classes
{
    public class User
    {
        public ObjectId Id { get; set; }

        //[BsonElement("Username")]
        public string Username { get; set; }

        //[BsonElement("Password")]
        public string Password { get; set; }

        //[BsonElement("Name")]
        public string Name { get; set; }

        public User()
        {
            Id = new ObjectId();
        }
    }
}
