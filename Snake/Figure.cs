using System;

namespace Snake
{
	class Figure
	{
		
		protected System.Collections.Generic.List<Point> pList;

		public void Drow ()
		{
			foreach (Point p in pList)
			{
				p.Draw ();
			}
		}
	}
}

