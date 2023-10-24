using HR.LeaveManagement.Application.Dtos;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Requests;

public class LeaveRequestListRequest : IRequest<List<LeaveRequestDto>>
{

}
