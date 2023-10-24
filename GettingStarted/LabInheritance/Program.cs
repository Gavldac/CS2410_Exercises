// See https://aka.ms/new-console-template for more information
using LabInheritance;


Pet myPet = new Pet("Furry");
Console.WriteLine($"myPet: {myPet}");
Dog dog = new Dog("Snoopy");
Cat cat = new Cat("Sylvester");
Console.WriteLine($"dog: {dog}");
Console.WriteLine($"cat: {cat}");
Console.WriteLine();

Console.WriteLine("Demonstrate Polymorphism");

Pet[] pets = { myPet, dog, cat };
foreach ( Pet p in pets)
{
    Console.WriteLine(p.Communicate());
}

