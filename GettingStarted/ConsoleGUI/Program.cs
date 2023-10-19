// See https://aka.ms/new-console-template for more information

using System.Drawing;

Console.WriteLine("Console GUI");

//Parameters for the square:
int size = 2; //Number of rows in the square
int topMargin = 5; //Margin to move the squares down from title
int leftMargin = 5; //Margin to push the squares to the right, away from the left edge



// Show a Title
Console.CursorTop = 2;
Console.CursorLeft = 2;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Title");

// Make a series of squares
for (int i = 0; i < size; i++)
{
    Console.BackgroundColor = (Console.BackgroundColor == ConsoleColor.Blue)
        ? ConsoleColor.Cyan : ConsoleColor.Blue;
    MakeSquare(topMargin + i, leftMargin + 2 * i, size - 2 * i,
        Console.BackgroundColor);
}

Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Black;


// Padding
for (int i = 0; i < 2; i++)
{
    Console.WriteLine();
}






//Makes a solid square 
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