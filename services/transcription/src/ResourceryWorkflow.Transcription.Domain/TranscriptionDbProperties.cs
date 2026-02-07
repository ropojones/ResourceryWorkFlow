namespace ResourceryWorkflow.Transcription;

public static class TranscriptionDbProperties
{
    public const string ConnectionStringName = "ResourceryTranscriptionDb";
    public static string DbTablePrefix { get; set; } = "";

    public static string DbSchema { get; set; } = null;
}
