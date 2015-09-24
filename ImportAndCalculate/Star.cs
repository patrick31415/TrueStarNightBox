using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ImportAndCalculate
{
    public class Star
    {
		public int HR;
		public string Name;
		public string DM;
		public int HD;
		public int SAO;
		public int FK5;
		public string IRflag;
		public string r_IRflag;
		public string Multiple;
		public string ADS;
		public string ADScomp;
		public string VarID;
		public int RAh1900;
		public int RAm1900;
		public float RAs1900;
		public string DEsigned1900;
		public int DEd1900;
		public int DEm1900;
		public float DEs1900;
		public int RAh;
		public int RAm;
		public float RAs;
		public string DEsigned;
		public int DEd;
		public int DEm;
		public float DEs;
		public float GLON;
		public float GLAT;
		public float Vmag;
		public string n_Vmag;
		public string u_Vmag;
		public float BV;
		public string uBV;
		public float UB;
		public string uUb;
		public float RI;
		public string nRI;
		public string SpType;
		public string nSpType;
		public float pmRA;
		public float pmDE;
		public string nParallax;
		public string Parallax;
		public int RadVel;
		public string nRadVel;
		public string lRotVel;
		public int RotVel;
		public string uRotVel;
		public float Dmag;
		public float Sep;
		public string MultID;
		public int MultCnt;
		public string NoteFlag;

		public static Dictionary<int, Star> LoadYaleStarTable(string path)
		{
			try
			{
				FileStream yaleStarTable = new FileStream(path, FileMode.Open);
				StreamReader reader = new StreamReader(yaleStarTable);
				Dictionary<int, Star> starDic = new Dictionary<int, Star>();
				Star star;
				string line;
				while (true)
				{
					line = reader.ReadLine();
					Debug.Print(line);
					if (string.IsNullOrEmpty(line))
						break;
					star = new Star();
					if (star.ReadFromLine(line))
						starDic.Add(star.HR, star);
					else
						return null;
				}
				return starDic;
			}
			catch (FileNotFoundException fnfe)
			{
				Debug.Print(fnfe.Message);
			}
			return null;
		}
    }
}
