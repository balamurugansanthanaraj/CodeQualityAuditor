namespace Github.Webhook.Handler.Strategy
{
    public interface IEventProcessStrategy
    {
        void Process(object data);
    }
}
