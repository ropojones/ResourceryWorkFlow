namespace ResourceryWorkflow.IdentityService;

public static class IdentityServiceDbProperties
{
    public const string ConnectionStringName = "ResourceryWorkflowIdentityServiceDb";
    public static string DbTablePrefix { get; set; } = "IdentityService";

    public static string DbSchema { get; set; } = null;
}
