using ResourceryWorkflow.Transcription.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ResourceryWorkflow.Transcription.Permissions;

public class TranscriptionPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var transcriptionGroup = context.AddGroup(
            TranscriptionPermissions.GroupName,
            L("Permission:Transcription")
        );
        var transcriptionPermissions = transcriptionGroup.AddPermission(
            TranscriptionPermissions.Transcripts.Default,
            L("Permission:Transcription:Transcripts")
        );
        transcriptionPermissions.AddChild(
            TranscriptionPermissions.Transcripts.Create,
            L("Permission:Transcription:Transcripts:Create")
        );
        transcriptionPermissions.AddChild(
            TranscriptionPermissions.Transcripts.Update,
            L("Permission:Transcription:Transcripts:Update")
        );
        transcriptionPermissions.AddChild(
            TranscriptionPermissions.Transcripts.Delete,
            L("Permission:Transcription:Transcripts:Delete")
        );
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TranscriptionResource>(name);
    }
}
