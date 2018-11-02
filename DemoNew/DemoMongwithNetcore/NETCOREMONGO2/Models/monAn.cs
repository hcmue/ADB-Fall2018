using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCOREMONGO2.Models
{
    public class monAn
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement]
        public int maMon { get; set; }
        [BsonElement]
        public string tenMon { get; set; }
        [BsonElement]
        public string gia { get; set; }
        [BsonElement]
        public string image { get; set; }
        [BsonElement]
        public string moTa { get; set; }
        [BsonElement]
        public string loai { get; set; }
        [BsonElement]
        public string dauBep { get; set; }
    }
}
