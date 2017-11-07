using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCrm.Classes
{
    public class Address
    {
        //public ObjectId Id { get; set; }
        public string Street { get; set; }
        public string StreetNo { get; set; }
        public string Region { get; set; }
        public int PostalCode { get; set; }

        //public Address()
        //{
        //    Id = new ObjectId();
        //}
    }
}
