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
		public Race()
		{
		}

		public void Start()
		{
			Console.CursorVisible = false;

			// paint title
			Console.SetCursorPosition(8,2);
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.Write("H O R S E  R A C E ");

			Lane lane1 = new Lane(8, 4, 40, ConsoleColor.Blue);
			Lane lane2 = new Lane(8, 6, 40, ConsoleColor.Blue);
			Lane lane3 = new Lane(8, 8, 40, ConsoleColor.Blue);

			lane1.Paint();
			lane2.Paint();
			lane3.Paint();

			RaceHorse[] horses =
			{
			new RaceHorse("Maple", ConsoleColor.Yellow, lane1),
			new RaceHorse("Alpo", ConsoleColor.Cyan, lane2),
			new RaceHorse("Moss", ConsoleColor.Magenta, lane3)
			};

        foreach (RaceHorse h in horses)
			{
				h.StartPosition();
			}



            for (int i = 0; i < 15; i++)
			//while ( !Done(horses) )
			{    
                foreach(RaceHorse h in horses)
				{
					h.Move();
				}
                Thread.Sleep(1000);
            }


            
            Console.CursorTop = 8;
			Console.CursorLeft = 8;

			
			Console.ResetColor();

			foreach (RaceHorse h in horses)
			{


			}
           
            Console.SetCursorPosition(8, 2);
			Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("FINISHED!!!");

        }

		private bool Done(RaceHorse[] horses)
		{
			foreach(RaceHorse h in horses)
			{
				if (!h.Finished())
					return false;
			}
			return true;
		}
	}
}

