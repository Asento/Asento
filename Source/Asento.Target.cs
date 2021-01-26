

using UnrealBuildTool;
using System.Collections.Generic;

public class AsentoTarget : TargetRules
{
	public AsentoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "Asento" } );
	}
}
