using System;

namespace Snake
{
	class HorizontalLine : Figure
	{

		public HorizontalLine (int xLeft, int xRight, int y, char sym)
		{
			pList = new System.Collections.Generic.List<Point> ();
			for(int x = xLeft; x <= xRight; x++)
			{
				Point p = new Point(x, y, sym);
				pList.Add(p);
			}

		}

	}
}

