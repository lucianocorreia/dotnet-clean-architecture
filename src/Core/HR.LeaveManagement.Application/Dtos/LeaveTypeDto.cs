using HR.LeaveManagement.Application.Dtos.Common;

namespace HR.LeaveManagement.Application.Dtos;

public class LeaveTypeDto : BaseDto
{
    public string Name { get; set; } = default!;
    public int DefaultDays { get; set; }
}
