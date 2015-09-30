using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace YaleConverter {
	/*
	    _________________________
	   /                        /│
	  /                        / │
	 /                        /  │
	┌────────────────────────┐   │
	│                        │   │
	│                        │   │
	│                        │   │
	│                        │   │
	│                        │   │
	│                        │   │
	│                        │   │
	│                        │   │
	│                        │   │
	│                        │   │
	│                        │  /
	│                        │ /
	│                        │/
	└────────────────────────┘

	*/


	public enum CudeSurface {
		down,
		back,
		right,
		left,
		up,
		down,
	}

	public class SkyPainter {
		private int width;
		public int Width { get { return width; } }

		private int height;
		public int Height { get { return height; } }

		public float standAreaMag = 6.5f;

		private Bitmap bmp;
		private Graphics g;

		public SkyPainter(int w, int h) {
			width = w;
			height = h;
			bmp = new Bitmap(w, h);
			g = Graphics.FromImage(bmp);
		}

		public void DrawStar(Graphics g, Color color, Point[] points) {
			g.FillPolygon(new SolidBrush(Color.White), points);
			g.DrawPolygon(new Pen(color), points);
		}

		public void DrawStar(Graphics g, Color color, PointF[] pointfs) {
			g.FillPolygon(new SolidBrush(Color.White), pointfs);
			g.DrawPolygon(new Pen(color), pointfs);
		}

		public float StarAreaByMagOnSphere(float mag) {
			if (mag > standAreaMag)
				return 1f;
			else
				return mag - standAreaMag + 1f;
		}

		public void Save(string path) {
			bmp.Save(path);
		}
	}
}
