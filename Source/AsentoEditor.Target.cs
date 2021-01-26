

using UnrealBuildTool;
using System.Collections.Generic;

public class AsentoEditorTarget : TargetRules
{
	public AsentoEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "Asento" } );
	}
}
