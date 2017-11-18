using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumsNET;
using Github.Webhooks.Handler.Strategy;
using Enum = Webhooks.CrossCutting.Enum;

namespace Github.Webhooks.Handler.Services
{
    public class EventProcessorService
    {
        public void Process(ICollection<string> actions, object data)
        {
            var action = actions.FirstOrDefault();
            if (action == default(string)) return;

            var eventProcessStrategy = GetEventProcessorStrategy(action);
            eventProcessStrategy.Process(data);
        }

        private static IEventProcessorStrategy GetEventProcessorStrategy(string action)
        {
            var eventProcessStrategy = default(IEventProcessorStrategy);

            var gitEvents = Enums.Parse<Enum.GitEvents>(action);

            switch (gitEvents)
            {
                case Enum.GitEvents.Create:
                    eventProcessStrategy = new CreateEventStrategy();
                    break;
            }
            return eventProcessStrategy;
        }
    }
}
