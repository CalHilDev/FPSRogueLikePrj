using UnrealBuildTool;

public class FPSRogueLikeEditorTarget : TargetRules
{
	public FPSRogueLikeEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("FPSRogueLike");
	}
}
