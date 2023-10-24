﻿namespace HR.LeaveManagement.Domain;

public class LeaveType : BaseEntity
{
    public string Name { get; set; } = default!;
    public int DefaultDays { get; set; }

}