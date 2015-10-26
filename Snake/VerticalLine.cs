﻿using System;

namespace Snake
{
	class VerticalLine : Figure
	{

		public VerticalLine (int yTop, int yBot, int x, char sym)
		{
			pList = new System.Collections.Generic.List<Point> ();
			for(int y = yTop; y <= yBot; y++)
			{
				Point p = new Point(x, y, sym);
				pList.Add(p);
			}

		}

	}
}

