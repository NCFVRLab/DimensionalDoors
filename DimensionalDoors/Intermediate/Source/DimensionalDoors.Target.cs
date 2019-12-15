using UnrealBuildTool;

public class DimensionalDoorsTarget : TargetRules
{
	public DimensionalDoorsTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("DimensionalDoors");
	}
}
