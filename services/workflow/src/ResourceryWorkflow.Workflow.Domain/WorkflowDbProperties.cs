namespace ResourceryWorkflow.Workflow;

public static class WorkflowDbProperties
{
    public const string ConnectionStringName = "ResourceryWorkflowWorkflowDb";
    public static string DbTablePrefix { get; set; } = "";

    public static string DbSchema { get; set; } = null;
}
