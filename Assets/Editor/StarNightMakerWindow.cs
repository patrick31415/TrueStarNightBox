using UnityEditor;
using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using ImportAndCalculate;

public class StarNightMakerWindow : EditorWindow 
{
	private bool isLoaded = false;
	static Dictionary<int, Star> dicStar = new Dictionary<int, Star>();



	public static Star ReadFromLine(string line)
	{
		Star star = new Star();

		int[] data_length = { 4, 10, 11, 6, 6, 4, 1, 1, 1, 5, 2, 9, 2, 2, 4, 1, 2, 2, 2, 2, 2, 4, 1, 2, 2, 2, 6, 6, 5, 1, 1, 5, 1, 5, 1, 5, 1, 20, 1, 6, 6, 1, 5, 4, 4, 2, 3, 1, 4, 6, 4, 2, 1 };
		string s;
		int i = 0;
		int index = 0;
		s = line.Substring(0, data_length[i++]);
		star.HR = int.Parse(s);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.Name = s;
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.DM = s;
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.HD = int.Parse(s);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.SAO = int.Parse(s);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		int.TryParse(s, out star.FK5);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.IRflag = s;
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.r_IRflag = s;
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.Multiple = s;
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.ADS = s;
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.ADScomp = s;
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.VarID = s;
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.RAh1900 = int.Parse(s);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.RAm1900 = int.Parse(s);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.RAs1900 = float.Parse(s);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.DEsigned1900 = s;
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.DEd1900 = int.Parse(s);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.DEm1900 = int.Parse(s);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.DEs1900 = float.Parse(s);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.RAh = int.Parse(s);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.RAm = int.Parse(s);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.RAs = float.Parse(s);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.DEsigned = s;
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.DEd = int.Parse(s);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.DEm = int.Parse(s);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.DEs = float.Parse(s);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.GLON = float.Parse(s);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.GLAT = float.Parse(s);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.Vmag = float.Parse(s);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.n_Vmag = s;
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.u_Vmag = s;
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.BV = float.Parse(s);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.uBV = s;
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		float.TryParse(s, out star.UB);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.uUb = s;
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		float.TryParse(s, out star.RI);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.nRI = s;
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.SpType = s;
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.nSpType = s;
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.pmRA = float.Parse(s);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.pmDE = float.Parse(s);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.nParallax = s;
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.Parallax = s;
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.RadVel = int.Parse(s);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.nRadVel = s;
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.lRotVel = s;
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.RotVel = int.Parse(s);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.uRotVel = s;
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.Dmag = float.Parse(s);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.Sep = float.Parse(s);
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.MultID = s;
		s = line.Substring(index += data_length[i - 1], data_length[i++]);
		star.MultCnt = int.Parse(s);
		Debug.Log(index);
		Debug.Log(i);
		Debug.Log(data_length[i]);

		Debug.Log(line.Length);
		s = line.Substring(index += data_length[i - 1], data_length[i]);
		star.NoteFlag = s;
		return star;
	}

	[MenuItem(@"SkyboxMaker/Starnight Setting")]
	public static void ShowSettingWindow() 
	{
		EditorWindow.GetWindow(typeof(StarNightMakerWindow));
	}

	[MenuItem(@"SkyboxMaker/Generate as resources")]
	public static void Generate()
	{
		TextAsset text = Resources.Load("bsc5.dat", typeof(TextAsset)) as TextAsset;
		string[] sa = text.text.Split('\n');
		Star star;
		foreach (string s in sa)
		{
			star = ReadFromLine(s);
			dicStar.Add(star.HR, star);
		}
	}

	void OnGUI()
	{
		if (GUILayout.Button("Generate"))
		{

			Generate();
		}
	}
}
