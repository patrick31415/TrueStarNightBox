using UnityEditor;
using UnityEngine;
using System.Collections;

public class StarNightMakerWindow : EditorWindow 
{
	[MenuItem(@"SkyboxMaker/Starnight Setting")]
	public static void ShowSettingWindow() 
	{
		EditorWindow.GetWindow(typeof(StarNightMakerWindow));
	}

	[MenuItem(@"SkyboxMaker/Generate as resources")]
	public static void Generate()
	{

	}

	void OnGUI()
	{

	}
}
