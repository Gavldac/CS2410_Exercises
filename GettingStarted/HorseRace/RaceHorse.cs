using System;
namespace HorseRace
{
	/// <summary>
	/// Represents a Race Horse.
	///
	/// author Edwin Casady
	/// </summary>
	public class RaceHorse
	{
		public string Name { get; }
		public ConsoleColor Color { get; }

		private int stride;//Length of the horses stride
		private Lane lane;
		private int left; //Current left position

		public RaceHorse(string name, ConsoleColor color, Lane lane  )
		{
			Name = name;
			Color = color;
			this.lane = lane;

			Random rand = new Random();
			stride = rand.Next(1, 7);// random numbr - upper bound exclusive

			left = lane.StartLeft;
		}


		public void StartPosition()
		{
			Console.CursorTop = lane.StartTop;
			Console.CursorLeft = left;
			Console.BackgroundColor = Color;

			Console.Write(' ');
		}

		public void Move()
		{

		}

		public bool Finished()
		{
			return (left >= lane.StartLeft + lane.Length);
			
		}
	}
}

