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
