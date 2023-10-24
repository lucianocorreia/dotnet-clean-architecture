using AutoMapper;
using HR.LeaveManagement.Application.Dtos;
using HR.LeaveManagement.Application.Features.LeaveTypes.Requests;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Queries;

public class GetLeaveTypeDetailRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper) : IRequestHandler<GetLeaveTypeDetailRequest, LeaveTypeDto>
{
    private readonly ILeaveTypeRepository leaveTypeRepository = leaveTypeRepository;
    private readonly IMapper mapper = mapper;

    public async Task<LeaveTypeDto> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
    {
        var leaveType = await leaveTypeRepository.GetByIdAsync(request.Id);
        return mapper.Map<LeaveTypeDto>(leaveType);
    }
}
