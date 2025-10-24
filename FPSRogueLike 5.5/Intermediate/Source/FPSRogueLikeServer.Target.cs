using UnrealBuildTool;

public class FPSRogueLikeServerTarget : TargetRules
{
	public FPSRogueLikeServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("FPSRogueLike");
	}
}
