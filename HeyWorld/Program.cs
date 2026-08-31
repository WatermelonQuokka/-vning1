// Console is an object
// that represents the terminal
// and has a method named WriteLine
// that we can tell
// with a string as argument
// then string will then be written
// to the terminal

/*
Console.WriteLine("Hello, World!");
Console.WriteLine("This is a simple C# program.");
*/

// string is a data type that represents text
// int is a data type that represents whole numbers
// double is a data type that represents decimal numbers
// bool is a data type that represents true or false values

Console.Write("Vad heter du? ");
string? name = Console.ReadLine();
Console.Write("Hur gammal är du? ");
string? ageAsString = Console.ReadLine();


// ! = not reverses true/false in a condition
// int.TryParse to parse a string to a number
// if it succeeds the number will be in the variable
// that we specified after out int

if (!int.TryParse(ageAsString, out int age))
{
    // if we failed
    age = 5;
    Console.WriteLine("Eftersom vi inte uppfattade din ålder räknar vi med att du är 5 år");
}

Console.WriteLine("Hur lång är du i meter? ");
string? heightAsString = Console.ReadLine();


if (!double.TryParse(heightAsString, out double height))
{
    // if we failed
    height = 0.5;
    Console.WriteLine("Eftersom vi inte uppfattade din längd räknar vi med att du är 0,5 m");
}


// only declares boolean isDeveloper
bool isDeveloper = false;


// Alternative to string interpolation
//string concatenation with + :
// Console.WriteLine("Jag heter " + name + "!");

Console.WriteLine($"Jag heter {name} och är {age} år gammal!");
Console.WriteLine($"Om 10 år så är jag {age + 10} år gammal!");
Console.WriteLine($"Jag är {height} meter lång.");

bool answeredYesOrNo = false;

Console.WriteLine("Är du en utvecklare? Ja/Nej ");

string? askIfIsDeveloper = Console.ReadLine();

// set value to isDeveloper

if (askIfIsDeveloper?.ToLower() =="ja")
{
    isDeveloper = true;
    answeredYesOrNo = true;
}
else if (askIfIsDeveloper?.ToLower() =="nej")
{
    isDeveloper = false;
    answeredYesOrNo = false;
}
else
{
    answeredYesOrNo = false;
    Console.WriteLine("Jag förstår inte.");
}

// if and a condition within parenthesis that is true
// for example the boolean value true
// makes the code in the program block {...}
// if the if-statement execute
if(answeredYesOrNo)
{
if(isDeveloper)
{
    Console.WriteLine("Jag är utvecklare.");
    Console.WriteLine("Det är jättekul att utveckla");
}
// else after an if-statement exectues if the condition
// in the if-statement is false
else
{
    Console.WriteLine("Jag är inte utvecklare.");
    Console.WriteLine("Jag kan inget om programmering.");
} 
}
