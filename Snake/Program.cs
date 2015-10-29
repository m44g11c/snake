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

			Point p = new Point (4, 5, '*');
			Snake snake = new Snake (p, 4, Direction.RIGHT);
			snake.Drow ();

			FoodCreator foodCreator = new FoodCreator (77, 22, '$');
			Point food = foodCreator.CreateFood ();
			food.Draw ();

			while (true) {

				if (snake.Eat (food)) {
					food = foodCreator.CreateFood ();
					food.Draw ();
				} else {
					snake.Move ();
				}

				System.Threading.Thread.Sleep(200);

				if(Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey ();
					snake.HandleKey (key.Key);
			
				}

			}

			Console.ReadLine ();
		}
	}
}
