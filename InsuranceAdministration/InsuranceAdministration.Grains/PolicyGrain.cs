using System;
using System.Text;
using System.Threading.Tasks;
using EventStore.Client;
using InsuranceAdministration.GrainInterfaces;
using Orleans;
using Orleans.EventSourcing;

namespace InsuranceAdministration.Grains
{
    public class PolicyGrain : JournaledGrain<PolicyState>, IPolicyGrain
    {
        private readonly EventStoreClient esClient;
        private string StreamName => $"{nameof(Policy)}-{this.GetPrimaryKey()}";

        public PolicyGrain()
        {
            var settings = new EventStoreClientSettings
            {
                ConnectivitySettings =
                {
                    Address = new Uri("http://localhost:2113")
                }
            }; 
            
            // For demo, assume we're running EventStoreDB locally
            esClient = new EventStoreClient(settings);
        }

        public override async Task OnActivateAsync()
        {
            var stream = esClient.ReadStreamAsync(Direction.Forwards, StreamName, StreamPosition.Start);

            if (await stream.ReadState == ReadState.StreamNotFound)
            {
                await ConfirmEvents();
            }

            await foreach (var resolvedEvent in stream)
            {
                object eventObj;
                var json = Encoding.UTF8.GetString(resolvedEvent.Event.Data.Span);
                switch (resolvedEvent.Event.EventType)
                {
                    default:
                        throw new InvalidOperationException($"Unknown Event: {resolvedEvent.Event.EventType}");
                }

                base.RaiseEvent(eventObj);
            }

            await ConfirmEvents();
        }
    }

    public class PolicyState
    {
        public IPolicy Policy { get; set; }
    }
}
