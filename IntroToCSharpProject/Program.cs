



Random randsomNumberGenerator = new Random();
int numberToGuess =randsomNumberGenerator.Next(1, 101);



Console.Write("Pick a number between 1 and 100:");
string input = Console.ReadLine();
int inputAsInt = int.Parse(input);


bool correctGuess = false;
if (numberToGuess == inputAsInt)
{
    correctGuess = true;
}

string correctResponse = $"That's right, the number I was Thinking of was {numberToGuess}";
string IncorrectGuess = $"Wow you're bad at this. I was thinking of {numberToGuess} but you guessed {input}.";

if (correctGuess)
{
    Console.WriteLine(correctResponse);
}
else
{
    Console.WriteLine(IncorrectGuess);
}

Console.Write("I was thinking of this number but you picked that other number.");



Console.ReadLine();