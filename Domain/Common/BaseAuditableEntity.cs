namespace Domain.Common;

public abstract class BaseAuditableEntity : BaseEntity
{
    public DateTime CreatedDateTime { get; set; }
    public string? CreatedByUser { get; set; }
    public DateTime LastModifiedDateTime { get; set; }
    public string? LastModifiedByUser { get; set; }
}
