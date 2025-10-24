using UnrealBuildTool;

public class FPSRogueLikeTarget : TargetRules
{
	public FPSRogueLikeTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("FPSRogueLike");
	}
}
