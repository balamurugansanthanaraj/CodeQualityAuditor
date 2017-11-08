namespace Shard.Libraries.Payload.Events
{
    public class CreateEvent
    {
        public string Reference { get; set; }
        public Repository Repository { get; set; }
        public Sender Sender { get; set; }
    }
}
