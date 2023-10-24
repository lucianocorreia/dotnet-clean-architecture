﻿namespace HR.LeaveManagement.Domain;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime DateCreated { get; set; }
    public string CreatedBy { get; set; } = default!;
    public DateTime DateModified { get; set; }
    public string ModifiedBy { get; set; } = default!;

}
