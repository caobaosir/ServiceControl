namespace ServiceBus.Management.Infrastructure
{
    using System.Threading.Tasks;
    using NServiceBus;
    using ServiceControl.Infrastructure.DomainEvents;
    using ServiceControl.Operations;

    class BusInstance
    {
        public BusInstance(IEndpointInstance bus, IDomainEvents domainEvents, ImportFailedAudits importFailedAudits, ImportFailedErrors importFailedErrors)
        {
            ImportFailedAudits = importFailedAudits;
            ImportFailedErrors = importFailedErrors;
            Bus = bus;
            DomainEvents = domainEvents;
        }

        public IEndpointInstance Bus { get; }
        public IDomainEvents DomainEvents { get; }
        public ImportFailedAudits ImportFailedAudits { get; }
        public ImportFailedErrors ImportFailedErrors { get; }

        public Task Stop()
        {
            return Bus.Stop();
        }
    }
}