using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GhostNetwork.Publications.MongoDb
{
    public class PublicationEntity
    {
        public ObjectId Id { get; set; }

        [BsonElement("content")]
        public string Content { get; set; }
    }
}