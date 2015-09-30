using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YaleConverter
{
	public static class StarFilter
	{
		public delegate bool Filter(Star star, params object[] pars);
		private static List<Filter> filterList = new List<Filter>();
		public static List<Filter> FilterList { get { return filterList; } }

		public static Star[] AfterFilter()
		{
			List<Star> starList = new List<Star>();
			bool isTrue = true;
			foreach (Star star in Star.starDic.Values)
			{
				foreach (Filter filter in filterList)
				{
					isTrue = isTrue && filter(star);
				}
				if (isTrue)
					starList.Add(star);
			}
			return starList.ToArray();
		}

		public static bool FilterByMag(Star star, params string[] pars) {
			try {
				return star.Vmag > double.Parse(pars[0]) && star.Vmag < double.Parse(pars[1]);
			}
			catch (Exception ex) { }
			return true;
		}
	}
}
