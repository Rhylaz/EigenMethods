// Model, Controller en View.
// Core C# behoort tot model. 
// XAML wordt alleen gebruikt binnen UWP, en UI. Dit is de mark-up language voor C#.



// * Methodes

// Methodes voeren pas uit wanneer je de methode aanroept.
// Je moet altijd de return type aangeven om terug te verwachten, of je geeft niks terug (void)

void Greetings(string name)
{
    Console.Write(name);
}

Greetings("Hola, ik ben een waarde in een parameter!");
Console.WriteLine();


//--


string input = Console.ReadLine();
int num = int.Parse(input);

int GetNumber(int number)
{
    //Console.WriteLine(number + num);
    return number + num;
}

float GetMean(int getal)
{
    return GetNumber(getal) / 3;
}

Console.WriteLine(GetNumber(30));
GetNumber(400 - 30);
GetNumber(1 * 5);

Console.WriteLine(GetMean(3));