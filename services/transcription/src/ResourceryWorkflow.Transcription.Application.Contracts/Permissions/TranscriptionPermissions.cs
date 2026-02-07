using Volo.Abp.Reflection;

namespace ResourceryWorkflow.Transcription.Permissions;

public class TranscriptionPermissions
{
    public const string GroupName = "Transcription";

    public static class Transcripts
    {
        public const string Default = GroupName + ".Issues";
        public const string Create = Default + ".Create";
        public const string Update = Default + ".Update";
        public const string Delete = Default + ".Delete";
    }

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(TranscriptionPermissions));
    }
}
