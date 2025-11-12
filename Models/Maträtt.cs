using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models


{
    public class Maträtt
    {
        [BsonId] // Primärnyckel
        
        public int Id { get; set; }
        [BsonElement("Kalorier")]
        public int Kalorier { get; set; }
        [BsonElement("Namn")]
        public string Namn { get; set; }
        public Maträtt(int id,  int kalorier,string namn)
        {

            this.Id = id;
            this.Namn = namn;
            this.Kalorier = kalorier;
        }
        public Maträtt()
        {

        }
       
    }
}
