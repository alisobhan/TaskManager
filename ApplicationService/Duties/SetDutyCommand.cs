namespace ApplicationService.Duties;

public class SetDutyCommand
{
    public string Title { get; set; }
    public TaskStatus Status { get; set; }
}