using System;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;


namespace Practice
{

    public class Abonent
    {
        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElementAttribute("Id")]
        public string Id { get; set; }

        [BsonElementAttribute("Fio")]
        public string FIO { get; set; }

        [BsonElementAttribute("StreetCD")]
        public string StreetId { get; set; }

        [BsonElementAttribute("HouseNo")]
        public int HouseNo { get; set; }

        [BsonElementAttribute("FlatNo")]
        public int FlatNo { get; set; }

        [BsonElementAttribute("Phone")]
        public string Phone { get; set; }
    }
}
