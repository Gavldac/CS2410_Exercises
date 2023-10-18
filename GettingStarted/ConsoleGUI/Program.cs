// See https://aka.ms/new-console-template for more information

using System.Drawing;

Console.WriteLine("Console GUI");

int size = 10; //Number of rows in the square
int topMargin = 5; //Margin to move the squares down from title
int leftMargin = 10; //Margin to push the squares to the right, away from the left edge
//ConsoleColor color = ConsoleColor.Blue; //Set the initial background color

//Save background
ConsoleColor background = Console.BackgroundColor;

//Padding
Console.WriteLine();

// Show a Title
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Title");

//MakeSquare(10, 15, 10, ConsoleColor.DarkCyan);

// Make a series of squares
for (int i = 0; i < size; i++)
{
    Console.BackgroundColor = (Console.BackgroundColor == ConsoleColor.Blue) ? ConsoleColor.Cyan : ConsoleColor.Blue;
    MakeSquare(topMargin + i, leftMargin + 2 * i, size - 2 * i, Console.BackgroundColor);
}


// Padding
for (int i = 0; i < 3; i++)
{
    Console.WriteLine();
}

Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Black;
//Console.BackgroundColor = background;




static void MakeSquare(int top, int leftMargin, int size, ConsoleColor color)
{
    Console.BackgroundColor = color;
    Console.CursorTop = top;

    for (int i = 0; i < size; i++)
    {
        Console.CursorLeft = leftMargin;
        Console.WriteLine($"{{0, {size * 2}}}", " ");
    }
}