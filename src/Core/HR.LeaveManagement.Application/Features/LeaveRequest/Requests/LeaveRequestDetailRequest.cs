using HR.LeaveManagement.Application.Dtos;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Requests;

public class LeaveRequestDetailRequest : IRequest<LeaveRequestDto>
{
    public int Id { get; set; }
}
