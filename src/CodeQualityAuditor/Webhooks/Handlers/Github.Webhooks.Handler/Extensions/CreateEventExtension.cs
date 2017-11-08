using Github.Webhook.Handler.ViewModel.Events;

namespace Github.Webhooks.Handler.Extensions
{
    public static class CreateEventExtension
    {
        public static Shard.Libraries.Payload.Events.CreateEvent ConvertToCreateEventPayLoad(this CreateEvent createEvent)
        {
            var createEventPayload = new Shard.Libraries.Payload.Events.CreateEvent
            {
                Reference = createEvent.Ref,
                Repository = new Shard.Libraries.Payload.Repository
                {
                    Id = createEvent.Repository.Id,
                    Name = createEvent.Repository.Name,
                    CreatedAt = createEvent.Repository.CreatedAt,
                    UpdatedAt = createEvent.Repository.UpdatedAt,
                    PushedAt = createEvent.Repository.PushedAt,
                },
                Sender = new Shard.Libraries.Payload.Sender
                {
                    Id = createEvent.Sender.Id,
                    Login = createEvent.Sender.Login
                }
            };

            return createEventPayload;
        }
    }
}