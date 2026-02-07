namespace ResourceryWorkflow.SaaS;

public static class SaaSDbProperties
{
    public const string ConnectionStringName = "ResourceryWorkflowSaaSDb";
    public static string DbTablePrefix { get; set; } = "SaaS";

    public static string DbSchema { get; set; } = null;
}
