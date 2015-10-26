using System;

namespace Snake
{
	class MainClass
	{
		public static void Main (string[] args)
		{



			HorizontalLine upLine = new HorizontalLine (0, 78, 0, '#');
			upLine.Drow ();
			VerticalLine leftLine = new VerticalLine (0, 23, 0, '#');
			leftLine.Drow ();
			HorizontalLine downLine = new HorizontalLine (0, 78, 23, '#');
			downLine.Drow ();
			VerticalLine rightLine = new VerticalLine (0, 23, 78, '#');
			rightLine.Drow ();

			Console.ReadLine ();
		}
	}
}
