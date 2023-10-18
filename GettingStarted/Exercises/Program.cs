// See https://aka.ms/new-console-template for more information
Console.CursorTop = 5;

// Save background color
ConsoleColor background = Console.BackgroundColor;
Console.BackgroundColor = ConsoleColor.Blue;

for(int i = 0; i < 5; i++)
{
    Console.CursorLeft = 10;
    Console.WriteLine("                   ");

}

Console.CursorTop = 7;
Console.CursorLeft = 14;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Hello World");



//=========
Console.BackgroundColor = background;
Console.ForegroundColor = ConsoleColor.Black;
Console.CursorTop += 3;

