using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace ResourceryWorkflow.Workflow.Services;

public class Service : FullAuditedAggregateRoot<Guid>
{
    public Guid DepartmentId { get; private set; }

    public string Name { get; private set; }

    public string Code { get; private set; }

    public string Description { get; private set; }

    public bool IsActive { get; private set; }

    public int? DefaultSlaHours { get; private set; }

    private Service()
    {
    }

    public Service(
        Guid id,
        Guid departmentId,
        string name,
        string code,
        string description,
        int? defaultSlaHours = null,
        bool isActive = true)
        : base(EnsureNotEmpty(id, nameof(id)))
    {
        SetDepartment(departmentId);
        SetName(name);
        SetCode(code);
        SetDescription(description);
        SetDefaultSlaHours(defaultSlaHours);
        IsActive = isActive;
    }

    public void SetDepartment(Guid departmentId)
    {
        DepartmentId = EnsureNotEmpty(departmentId, nameof(departmentId));
    }

    public void SetName(string name)
    {
        Name = Check.NotNullOrWhiteSpace(name, nameof(name), ServiceConsts.MaxNameLength);
    }

    public void SetCode(string code)
    {
        Code = Check.NotNullOrWhiteSpace(code, nameof(code), ServiceConsts.MaxCodeLength);
    }

    public void SetDescription(string description)
    {
        Description = Check.Length(description, nameof(description), ServiceConsts.MaxDescriptionLength);
    }

    public void SetDefaultSlaHours(int? defaultSlaHours)
    {
        if (defaultSlaHours.HasValue)
        {
            Check.Range(defaultSlaHours.Value, nameof(defaultSlaHours), 1, 24 * 30);
        }

        DefaultSlaHours = defaultSlaHours;
    }

    public void Activate()
    {
        IsActive = true;
    }

    public void Deactivate()
    {
        IsActive = false;
    }

    public static Guid EnsureNotEmpty(Guid id, string paramName)
    {
        if (id == Guid.Empty)
        {
            throw new ArgumentException("The identifier cannot be empty.", paramName);
        }

        return id;
    }
}
