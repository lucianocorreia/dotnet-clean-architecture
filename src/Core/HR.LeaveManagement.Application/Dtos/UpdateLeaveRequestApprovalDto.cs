using HR.LeaveManagement.Application.Dtos.Common;

namespace HR.LeaveManagement.Application.Dtos;

public class UpdateLeaveRequestApprovalDto : BaseDto
{
    public bool? Approved { get; set; }
}
