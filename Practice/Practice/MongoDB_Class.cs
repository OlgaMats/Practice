using System;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Bson;
using System.Collections.Generic;

namespace Practice
{
    public class MongoDB_Class
    {
        MongoServerSettings Settings_;
        MongoServer server;
        MongoDatabase Database_;
        public static MongoDB_Class _Obj;
        public static MongoDB_Class GetObject()
        {
            if (_Obj == null)
            {
                _Obj = new MongoDB_Class();
            }
            return _Obj;
        }
        public MongoDB_Class()
        {

            Settings_ = new MongoServerSettings();
            Settings_.Server = new MongoServerAddress("localhost", 27017);
            server = new MongoServer(Settings_);
            Database_ = server.GetDatabase("test");
        }
        public SBindingList<Street> Load_Street()
        {
            var collection = Database_.GetCollection<Street>("Street");
            SBindingList<Street> doclist = new SBindingList<Street>();
            foreach (Street stat in collection.FindAll())
            {
                doclist.Add(stat);
            }
            return doclist;
        }
        public void Delete_Street_Infromation(Street _Obj)
        {
            MongoCollection<Street> Collection_ = Database_.GetCollection<Street>("Street");
            IMongoQuery Marker = Query.EQ("Id", _Obj.Id);
            Collection_.Remove(Marker);
        }

        public void Filter_Street_Infromation(Street _Obj)
        {
            MongoCollection<Street> Collection_ = Database_.GetCollection<Street>("Street");
            IMongoQuery Marker = Query.EQ("Id", _Obj.Id);
            Collection_.Find(Marker);
        }
        public void Filter_Abonent_Id(Abonent _Obj)
        {
            MongoCollection<Abonent> Collection_ = Database_.GetCollection<Abonent>("Abonent");
            IMongoQuery Marker = Query.EQ("Id", _Obj.Id);
            Collection_.Find(Marker);
        }
        public void Filter_Abonent_FIO(Abonent _Obj)
        {
            MongoCollection<Abonent> Collection_ = Database_.GetCollection<Abonent>("Abonent");
            IMongoQuery Marker = Query.EQ("FIO", _Obj.FIO);
            Collection_.Find(Marker);
        }

        public void Insert_Street_Information(Street _Obj)
        {
            MongoCollection<Street> Collection_ = Database_.GetCollection<Street>("Street");
            BsonDocument Stu_Doc = new BsonDocument {
                {
                    "Id", _Obj.Id
                },
                {
                    "STREETNM", _Obj.StreetName
                }

            };
            Collection_.Insert(Stu_Doc);
        }

        public void Update_Street_Information(Street _Obj)
        {
            MongoCollection<Street> Collection_ = Database_.GetCollection<Street>("Street");
            IMongoQuery Marker = Query.EQ("Id", _Obj.Id);
            IMongoUpdate Update_ = MongoDB.Driver.Builders.Update.Set("STREETNM", _Obj.StreetName);
            Collection_.Update(Marker, Update_);
        }

        public void Save_Street_Information(Street _Obj)
        {
            MongoCollection<Street> Collection_ = Database_.GetCollection<Street>("Street");
            BsonDocument Stu_Doc = new BsonDocument()
                .Add("_id", _Obj._id)
                .Add("STREETNM", _Obj.StreetName);
            Collection_.Save(Stu_Doc);
        }

        public SBindingList<Abonent> Load_Abonent()
        {
            var collection = Database_.GetCollection<Abonent>("Abonent");
            SBindingList<Abonent> doclist = new SBindingList<Abonent>();
            foreach (Abonent stat in collection.FindAll())
            {
                doclist.Add(stat);
            }
            return doclist;
            
        }

        public void Delete_Abonent_Infromation(Abonent _Obj)
        {
            MongoCollection<Abonent> Collection_ = Database_.GetCollection<Abonent>("Abonent");
            IMongoQuery Marker = Query.EQ("Id", _Obj.Id);
            Collection_.Remove(Marker);
        }

        public void Insert_Abonent_Information(Abonent _Obj)
        {
            MongoCollection<Abonent> Collection_ = Database_.GetCollection<Abonent>("Abonent");
            BsonDocument Stu_Doc = new BsonDocument {
                {
                    "Id", _Obj.Id
                },
                {
                    "StreetCD", _Obj.StreetId
                },
                 {
                    "HouseNo", _Obj.HouseNo
                },
                 {
                    "FlatNo", _Obj.FlatNo
                },
                 {
                    "Fio", _Obj.FIO
                },
                 {
                    "Phone", _Obj.Phone
                }

            };
            Collection_.Insert(Stu_Doc);
        }

        public void Update_Abonent_Information(Abonent _Obj)
        {
            MongoCollection<Abonent> Collection_ = Database_.GetCollection<Abonent>("Abonent");
            IMongoQuery Marker = Query.EQ("Id", _Obj.Id);
            IMongoUpdate Update_ = MongoDB.Driver.Builders.Update
                .Set("StreetCD", _Obj.StreetId)
                .Set("HouseNo", _Obj.HouseNo)
                .Set("FlatNo", _Obj.FlatNo)
                .Set("Fio", _Obj.FIO)
                .Set("Phone", _Obj.Phone);
            
            Collection_.Update(Marker, Update_);
        }

        public void Save_Abonent_Information(Abonent _Obj)
        {
            MongoCollection<Abonent> Collection_ = Database_.GetCollection<Abonent>("Abonent");
            BsonDocument Stu_Doc = new BsonDocument()
                .Add("_id", _Obj._id)
                .Add("StreetCD", _Obj.StreetId)
                .Add("HouseNo", _Obj.HouseNo)
                .Add("FlatNo", _Obj.FlatNo)
                .Add("Fio", _Obj.FIO)
                .Add("Phone", _Obj.Phone); ;
            Collection_.Save(Stu_Doc);
        }
    }
}
