namespace Github.Webhook.Handler.ViewModel.Events
{
    public class CreateEvent
    {
        public string Ref { get; set; }
        public string RefType { get; set; }
        public string MasterBranch { get; set; }
        public string Description { get; set; }
        public string PusherType { get; set; }
        public Repository Repository { get; set; }
        public Sender Sender { get; set; }
    }
}