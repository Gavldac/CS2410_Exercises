using System;
namespace HorseRace
{
	/// <summary>
	/// Represents a Horse Race.
	/// 
	/// author: Edwin Casady
	/// </summary>
	public class Race
	{
		public Race()
		{
		}

		public void Start()
		{
			Lane lane1 = new Lane(8, 4, 40, ConsoleColor.Blue );
			Lane lane2 = new Lane(8, 6, 40);

			lane1.Paint();
			lane2.Paint();

			RaceHorse horse1 = new RaceHorse("Maple", ConsoleColor.Yellow, lane1);
			horse1.StartPosition();

			RaceHorse horse2 = new RaceHorse("Alpo", ConsoleColor.Magenta, lane2);
			horse2.StartPosition();

			//Maple is or is not finished
			Console.CursorTop = 8;
			Console.CursorLeft = 8;
			Console.ResetColor();
			Console.WriteLine($"{horse1.Name} {(horse1.Finished() ?
				"is" : "is not")} finished");

			Console.CursorLeft = 8;
            Console.WriteLine($"{horse2.Name} {(horse2.Finished() ?
				"is" : "is not")} finished");

        }
	}
}

