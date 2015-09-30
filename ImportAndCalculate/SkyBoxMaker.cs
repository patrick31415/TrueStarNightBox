using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YaleConverter {
	public enum CubeSurface {
		forward,
		back,
		right,
		left,
		up,
		down,
	}

	class SkyBoxMaker {
		public void Init(string path) {
			Star.ReadData(path);
		}

		public void AddFilter(StarFilter.Filter filter) {
			StarFilter.FilterList.Add(filter);
		}
	}
}
