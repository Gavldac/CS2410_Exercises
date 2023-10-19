//The program should print a quote of your choice. 
//Additionally, it should either speak the quote or display an ASCII art of your choice.
//Position the quotes to create a margin on top and to the left.
//Use at least three console colors to display the quote in addition to the default colors.
//Change both the foreground and the background color.



///<summary>
/// Small program to display a quote in 3 different combinations of foreground
/// and background colors. Also will display a small ASCII art image at the end.
///
/// Written for CS2410 assignment A03
///
/// author Edwin Casady
/// </summary>


Console.CursorTop = 5;

ColorSetter(ConsoleColor.White, ConsoleColor.DarkMagenta);
Console.WriteLine("\"It's a good thing ");

ColorSetter(ConsoleColor.Gray, ConsoleColor.Red);
Console.WriteLine("that few people are aware ");

ColorSetter(ConsoleColor.DarkGray, ConsoleColor.DarkRed);
Console.WriteLine("of the awesome distructive power of Oragami.\"");

ColorSetter(); 
Console.WriteLine("-Nobody");

//Padding
Console.WriteLine("\n");

DrawGreenExplosion();

//Hide the text at the end of the program
Console.ForegroundColor = ConsoleColor.Black;









///<summary>
/// Method to set the background and foreground colors and cursor position.
/// If arguements are not given, will default to Black background,
/// White foreground, and a cursor position of 5 from the left margin.
///
/// author Edwin Casady
///</summary>
void ColorSetter(
    ConsoleColor background = ConsoleColor.Black,
    ConsoleColor foreGround = ConsoleColor.White,
    int cursor = 5)
{
    Console.CursorLeft = cursor;
    Console.BackgroundColor = background;
    Console.ForegroundColor = foreGround;
}

///<summary>
/// Draws a small green mushroom cloud on a black background.
/// Resets the console colors to default when finished.
///
/// Art from https://www.asciiart.eu/weapons/explosives
/// artist: unattibuted
///
/// author Edwin Casady
///</summary>
void DrawGreenExplosion()
{
    ColorSetter(ConsoleColor.Black, ConsoleColor.Green, 0);
    Console.WriteLine("            _._  _, _ ._          ");
    Console.WriteLine("         (_ '  ( ` )_ .__)        ");
    Console.WriteLine("        (__(_(_._ ) _), __)       ");
    Console.WriteLine("          `~~`\\ ' . /`~~`         ");
    Console.WriteLine("                ; ;               ");
    Console.WriteLine("               /   \\              ");
    Console.WriteLine("_____________ / _ _ \\_____________");
    Console.ResetColor();
}