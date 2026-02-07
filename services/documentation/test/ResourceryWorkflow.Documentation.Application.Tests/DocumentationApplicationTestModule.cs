using Volo.Abp.Modularity;

namespace ResourceryWorkflow.Documentation;

[DependsOn(typeof(DocumentationApplicationModule))]
[DependsOn(typeof(DocumentationDomainTestModule))]
public class DocumentationApplicationTestModule : AbpModule { }
