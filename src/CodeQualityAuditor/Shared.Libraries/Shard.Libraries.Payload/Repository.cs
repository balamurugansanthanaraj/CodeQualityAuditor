using System;

namespace Shard.Libraries.Payload
{
    public class Repository
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime PushedAt { get; set; }
    }
}
