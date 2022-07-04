using System;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Practice
{
   public class Street
    {
        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElementAttribute("Id")]
        public int Id { get; set; }

        [BsonElementAttribute("STREETNM")]
        public string StreetName { get; set; }

        public override string ToString()
        {
            return StreetName;
        }
    }
}
