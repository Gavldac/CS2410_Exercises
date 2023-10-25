using System;
using System.Runtime.Intrinsics.X86;

namespace HorseRace
{
	/// <summary>
	/// Represents a Horse Race.
	/// 
	/// author: Edwin Casady
	/// </summary>
	public class Race
	{
		public List<string> results = new List<string>();
		public Race()
		{
		}

		public void Start()
		{
			Console.CursorVisible = false;

			// paint title
			Console.SetCursorPosition(8, 2);
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.Write("H O R S E  R A C E ");

			//use an array for the lanes to reduce repeting lines of code
			Lane[] lanes = new Lane[4];
			int lanePlacement = 4; //Console row placement for where the first lane will go
			for (int i = 0; i < lanes.Length; i++)
			{
				lanes[i] = new Lane(8, lanePlacement, 40, ConsoleColor.Blue);
				lanePlacement += 2;
			}

			foreach (Lane l in lanes)
			{
				l.Paint();
			}

			//use an array for the RaceHorses
			int lanePosition = 0;
			RaceHorse[] horses =
			{
			new RaceHorse("Maple", ConsoleColor.Yellow, lanes[lanePosition++]),
			new RaceHorse("Alpo", ConsoleColor.Cyan,    lanes[lanePosition++]),
			new RaceHorse("Moss", ConsoleColor.Magenta, lanes[lanePosition++]),
			new RaceHorse("Apple", ConsoleColor.Red,    lanes[lanePosition++])
			};

			

			//setup the horses to race
			foreach (RaceHorse h in horses)
			{
				h.StartPosition();
			}

			//Start the race
			while (!Done(horses))
			{
				foreach (RaceHorse h in horses)
				{
					h.Move();
					if (h.Finished())
						results.Add(h.Name);
				}
				Thread.Sleep(200);
			}

			Console.SetCursorPosition(8, 11); 
			Console.ResetColor();
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.Write("F I N I S H E D ! ! !");

			Console.ResetColor();
			Console.CursorTop = 12;
		
			//The end of the race
			foreach (RaceHorse h in horses)
			{
				Console.CursorLeft = 8;
				Console.WriteLine(
					$"{h.Name} {(h.Finished() ? "is" : "is not")} Finished");
			}
			Console.CursorLeft = 8;
			Console.WriteLine($"{results.First()} is the winner!!!");

		}

		private bool Done(RaceHorse[] horses)
		{
			foreach (RaceHorse h in horses)
			{
				if (!h.Finished())
					return false;
			}
			return true;
		}
	}
}

