namespace ResourceryWorkflow.Documentation;

public static class DocumentationDbProperties
{
    public const string ConnectionStringName = "ResourceryDocumentationDb";
    public static string DbTablePrefix { get; set; } = "Documentation";

    public static string DbSchema { get; set; } = null;
}
