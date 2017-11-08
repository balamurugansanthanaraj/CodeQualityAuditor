using System;
using System.Collections.Generic;

namespace Github.Webhook.Handler.ViewModel
{
    public class Commit
    {
        public string Id { get; set; }
        public string TreeId { get; set; }
        public bool Distinct { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
        public string Url { get; set; }
        public Author Author { get; set; }
        public Committer Committer { get; set; }
        public List<string> Added { get; set; }
        public List<object> Removed { get; set; }
        public List<object> Modified { get; set; }
    }
}