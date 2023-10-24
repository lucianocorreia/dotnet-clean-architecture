using HR.LeaveManagement.Application.Dtos;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests;


public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDto>>
{

}
