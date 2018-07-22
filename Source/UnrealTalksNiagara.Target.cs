// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class UnrealTalksNiagaraTarget : TargetRules
{
	public UnrealTalksNiagaraTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "UnrealTalksNiagara" } );
	}
}
