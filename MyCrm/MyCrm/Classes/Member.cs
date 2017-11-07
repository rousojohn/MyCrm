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
    public class Member
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public DateTime Birthdate { get; set; }
        public Address[] Addresses { get; set; }


        public Member ()
        {
            Id = new ObjectId();
        }

    }
}
