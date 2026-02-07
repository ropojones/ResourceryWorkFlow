using ResourceryWorkflow.Documentation.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ResourceryWorkflow.Documentation;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(typeof(DocumentationEntityFrameworkCoreTestModule))]
public class DocumentationDomainTestModule : AbpModule { }
