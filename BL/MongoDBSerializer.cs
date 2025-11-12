using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using Models;
using System.Web;

namespace BL
{
    public class MongoDBSerializer
    {
        private readonly IMongoCollection<Maträtt> MaträttsKollektion;
        //public static string? UrlEncode(string? value)
        //{
        //    string? retur = value;
        //    return retur;
        //}

        public MongoDBSerializer()
        {   
            
            var klient = new MongoClient("Add keystring");
            var databas = klient.GetDatabase("Kaloriräknarapp");
            MaträttsKollektion = databas.GetCollection<Maträtt>("Maträtt");
            
            try
            {
                var result = klient.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
                Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void AddSingle(Maträtt m)
        {
            MaträttsKollektion.InsertOne(m);
        }

        public void AddMany(List<Maträtt> m)
        {
            MaträttsKollektion.InsertMany(m);
        }

        public Maträtt Open(int id)
        {
            var filter = Builders<Maträtt>.Filter.Eq("Id", id);
            var maträtt = MaträttsKollektion.Find(filter).FirstOrDefault();
            return maträtt;
            
        }
        public bool Update(Maträtt m)
        {
            var Filter = Builders<Maträtt>.Filter.Eq("Id", m.Id);
            MaträttsKollektion.ReplaceOne(Filter, m);
            return true;
        }

        public bool UpdateMany(List<Maträtt> Lista)// Bad Practice, gör ett anrop för varje uppdatering byt ut senare 
        {
            foreach(Maträtt m in Lista)
            {
                var Filter = Builders<Maträtt>.Filter.Eq("Id", m.Id);
                MaträttsKollektion.ReplaceOne(Filter, m);
            }
            return true;
        }

        public bool Delete(Maträtt m)
        {
            var Filter = Builders<Maträtt>.Filter.Eq("Id", m.Id);
            MaträttsKollektion.DeleteOne(Filter);
            return true;
        }



    }
}
