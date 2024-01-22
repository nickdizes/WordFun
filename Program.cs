//user enters a quote
//how many words
//how many characters
//how many of each letter was used

using OOPFun;

//classes
WordTools wt = new WordTools();

//variables
string quote = "";

//Gathering user input
Console.WriteLine("Please enter a quote to analyze: ");
quote = Console.ReadLine();

Console.WriteLine("Number of Words: " + wt.WordCounter(quote));
Console.WriteLine("Number of Characters: " + wt.CharacterCounter(quote));
Console.WriteLine("Alpahabet: ");
wt.AlphabetCounter(quote);
