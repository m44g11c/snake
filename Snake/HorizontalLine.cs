using System;

namespace Snake
{
	class HorizontalLine
	{
		System.Collections.Generic.List<Point> pList;

		public HorizontalLine (int xLeft, int xRight, int y, char sym)
		{
			pList = new System.Collections.Generic.List<Point> ();
			for(int x = xLeft; x <= xRight; x++)
			{
				Point p = new Point(x, y, sym);
				pList.Add(p);
			}

		}

		public void Drow ()
		{
			foreach (Point p in pList)
			{
				p.Draw ();
			}
		}

	}
}

