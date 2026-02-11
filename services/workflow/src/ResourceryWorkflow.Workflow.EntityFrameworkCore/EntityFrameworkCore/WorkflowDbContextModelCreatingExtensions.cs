using Microsoft.EntityFrameworkCore;
using ResourceryWorkflow.Workflow.Departments;
using ResourceryWorkflow.Workflow.Requests;
using ResourceryWorkflow.Workflow.Services;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ResourceryWorkflow.Workflow.EntityFrameworkCore;

public static class WorkflowDbContextModelCreatingExtensions
{
    public static void ConfigureWorkflow(this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        builder.Entity<Department>(b =>
        {
            b.ToTable(WorkflowDbProperties.DbTablePrefix + "Departments", WorkflowDbProperties.DbSchema);
            b.ConfigureByConvention();

            b.Property(x => x.Name).IsRequired().HasMaxLength(DepartmentConsts.MaxNameLength);
            b.Property(x => x.Code).IsRequired().HasMaxLength(DepartmentConsts.MaxCodeLength);
            b.Property(x => x.Description).HasMaxLength(DepartmentConsts.MaxDescriptionLength);

            b.HasIndex(x => x.Code).IsUnique();
            b.HasIndex(x => x.Name);
        });

        builder.Entity<Service>(b =>
        {
            b.ToTable(WorkflowDbProperties.DbTablePrefix + "Services", WorkflowDbProperties.DbSchema);
            b.ConfigureByConvention();

            b.Property(x => x.DepartmentId).IsRequired();
            b.Property(x => x.Name).IsRequired().HasMaxLength(ServiceConsts.MaxNameLength);
            b.Property(x => x.Code).IsRequired().HasMaxLength(ServiceConsts.MaxCodeLength);
            b.Property(x => x.Description).HasMaxLength(ServiceConsts.MaxDescriptionLength);

            b.HasIndex(x => new { x.DepartmentId, x.Code }).IsUnique();
            b.HasIndex(x => x.DepartmentId);
            b.HasIndex(x => x.Name);
        });

        builder.Entity<Request>(b =>
        {
            b.ToTable(WorkflowDbProperties.DbTablePrefix + "Requests", WorkflowDbProperties.DbSchema);
            b.ConfigureByConvention();

            b.Property(x => x.DepartmentId).IsRequired();
            b.Property(x => x.ServiceId).IsRequired();
            b.Property(x => x.RequestedByUserId).IsRequired();
            b.Property(x => x.Title).IsRequired().HasMaxLength(RequestConsts.MaxTitleLength);
            b.Property(x => x.Description).HasMaxLength(RequestConsts.MaxDescriptionLength);
            b.Property(x => x.Status).IsRequired();
            b.Property(x => x.Priority).IsRequired();

            b.HasIndex(x => x.ServiceId);
            b.HasIndex(x => x.DepartmentId);
            b.HasIndex(x => x.Status);
            b.HasIndex(x => x.CreationTime);
        });
    }
}
