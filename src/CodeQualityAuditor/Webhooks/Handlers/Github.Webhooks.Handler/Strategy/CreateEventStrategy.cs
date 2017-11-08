using Github.Webhook.Handler.Strategy;
using Github.Webhook.Handler.ViewModel.Events;
using Github.Webhooks.Handler.Extensions;
using Webhooks.CrossCutting;

namespace Github.Webhooks.Handler.Strategy
{
    public class CreateEventStrategy : IEventProcessStrategy
    {

        public void Process(object data)
        {
            if (data == null) return;

            var createEvent = ObjectConverter.GetDataOrDefault<CreateEvent>(data);

            if (createEvent == default(CreateEvent)) return;

            var createEventPayload = createEvent.ConvertToCreateEventPayLoad();

            // Call Quality Checker API
        }
    }
}
