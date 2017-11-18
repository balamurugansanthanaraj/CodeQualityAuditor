namespace Github.Webhooks.Handler.Strategy
{
    public interface IEventProcessorStrategy
    {
        void Process(object data);
    }
}
