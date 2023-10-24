using HR.LeaveManagement.Application.Dtos;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocation.Requests;

public class LeaveTypeListRequest : IRequest<List<LeaveAllocationDto>>
{

}
