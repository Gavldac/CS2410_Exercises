using System;
namespace HorseRace
{
	/// <summary>
	/// represents a Lane where the horse races.
	///
	/// author: Edwin Casady
	/// </summary>
	public class Lane
	{
		public int StartTop { get; }
		public int StartLeft { get; }
		public int Length { get; }
		public ConsoleColor Color { get; }

		public Lane(int left, int top, int length,
			ConsoleColor color = ConsoleColor.DarkGray) // Optional argument
		{
			StartLeft = left;
			StartTop = top;
			Length = length;
			Color = color;
		}

		/// <summary>
		/// 
		/// </summary>
		public void Paint()
		{
			Console.BackgroundColor = Color;
			Console.CursorLeft = StartLeft;
			Console.CursorTop = StartTop;
			Console.Write(new String(' ', Length));

			
		}
	}
}

