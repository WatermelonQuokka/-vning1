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
string name = "Bjorn";
int age = 36;
double height = 1.75;
bool isDeveloper = true;
// Alternative to string interpolation
//string concatenation with + :
// Console.WriteLine("Jag heter " + name + "!");
Console.WriteLine($"Jag heter {name} och är {age} år gammal!");
Console.WriteLine($"Jag är {height} meter lång.");

// if and a condition within parenthesis that is true
// for example the boolean value true
// makes the code in the program block {...}
// if the if-statement execute
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