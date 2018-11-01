using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCOREMONGO2.Models
{
    public class Customer
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement]
        public int productId { get; set; }
        [BsonElement]
        public string productName { get; set; }
        [BsonElement]
        public string price { get; set; }
        [BsonElement]
        public string image { get; set; }
        public string description { get; set; }
    }
}
