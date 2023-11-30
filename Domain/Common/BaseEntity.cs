using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        private readonly IList<BaseEvent> _domanEvents = [];

        [NotMapped]
        public IReadOnlyCollection<BaseEvent> DomanEvents => _domanEvents.AsReadOnly();

        public void AddDomainEvent(BaseEvent domainEvent)
        {
            _domanEvents.Add(domainEvent);
        }
        public void RemoveDomainEvent(BaseEvent domainEvent)
        {
            _domanEvents.Remove(domainEvent);
        }
        public void ClearDomainEvent()
        {
            _domanEvents.Clear();
        }
    }
}