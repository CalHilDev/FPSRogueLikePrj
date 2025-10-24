using UnrealBuildTool;

public class FPSRogueLikeClientTarget : TargetRules
{
	public FPSRogueLikeClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("FPSRogueLike");
	}
}
