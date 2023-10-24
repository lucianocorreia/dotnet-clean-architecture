using AutoMapper;
using HR.LeaveManagement.Application.Dtos;
using HR.LeaveManagement.Application.Features.LeaveTypes.Requests;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Queriesl;

public class GetLeaveTypeListRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper) : IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDto>>
{
    private readonly ILeaveTypeRepository leaveTypeRepository = leaveTypeRepository;
    private readonly IMapper mapper = mapper;

    public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
    {
        var leaveTypes = await leaveTypeRepository.GetAllAsync();
        return mapper.Map<List<LeaveTypeDto>>(leaveTypes);
    }
}
