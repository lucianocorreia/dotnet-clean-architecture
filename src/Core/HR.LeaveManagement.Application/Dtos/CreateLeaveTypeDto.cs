﻿namespace HR.LeaveManagement.Application.Dtos;

public class CreateLeaveTypeDto : ILeaveTypeDto
{
    public string Name { get; set; } = default!;
    public int DefaultDays { get; set; }
}
