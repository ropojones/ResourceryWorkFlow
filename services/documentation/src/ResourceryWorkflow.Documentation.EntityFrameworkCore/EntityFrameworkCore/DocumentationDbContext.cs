using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ResourceryWorkflow.Documentation.EntityFrameworkCore;

[ConnectionStringName(ResourceryNames.DocumentationDb)]
public class DocumentationDbContext(DbContextOptions<DocumentationDbContext> options)
    : AbpDbContext<DocumentationDbContext>(options),
        IDocumentationDbContext
{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureDocumentation();
    }
}
