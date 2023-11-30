namespace Domain.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        private readonly IList<BaseEvent> _domanEvents = [];
    }
}