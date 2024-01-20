// Copyright Epic Games, Inc. All Rights Reserved.

using System;
using System.IO;
using UnrealBuildTool;

public class UE_sandbox : ModuleRules
{
	public UE_sandbox(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });


		if (Target.Platform == UnrealTargetPlatform.Android)
		{
            deleteAndroidIntermediate("arm64");

        }
    }

	private void deleteAndroidIntermediate(string arch)
	{
		string dirPath = Path.Combine(ModuleDirectory, "../../Intermediate/Android/", arch, "gradle/.gradle");

		if (Directory.Exists(dirPath))
		{
			try
			{
				Directory.Delete(dirPath, true);
				Console.WriteLine(dirPath + "is deleted");
			}
			catch (Exception ex)
			{
				Console.WriteLine("[ERROR]" + dirPath + "cannot be deleted: " + ex.ToString());
			}
		}
	}
}
