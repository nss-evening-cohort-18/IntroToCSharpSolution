//////dynamic typed language - JavaScript, Python, Ruby
//////strongly typed language - C#, Java, Go, Typescript

//////string name = "Brian";
//////Console.WriteLine(name);
//////name = "okay";
//////Console.WriteLine(name);
//////name = "This is" + name;
//////Console.WriteLine(name);
//////Console.ReadLine();
//////name = 4;


//////default values depends on whether it's a reference type or value type
//////value
//////int val1 = 1;
//////int val2 = val1;
//////val1 = 2;
//////Console.WriteLine(val1);
//////Console.WriteLine(val2);
//////Console.ReadLine();

//////string name = "Brian";
//////string word = name;
//////name = "Jameka";
//////Console.WriteLine(name);
//////Console.WriteLine(word);
//////Console.ReadLine();
////string text; //instantiate
////bool myBoolean = false;
////bool myBoolean2 = true;

////string name = "Brian";
////char firstLetter = 'B';
////char secondLetter = name[1];

//////Math.Pow(number, 99);
//////int newNumber = number + 1;
//////int remainder = 5 % 2;
////int intvalue = 5/2;
////double doubleValue = 5.0 / 2.0;
////decimal decimalValue = 5 / 2m;
////float floatValue = 5f / 2f;
////int value = 5;
////int zero = 0;
////string poem = @"First Line of Text
////Second Line of Text";
////string author = @"    -Author of Quote";
////text = $"{poem} written by {author}"; //initializing
////Console.WriteLine(text);


////if (zero == 0)
////{
////    //do something to handle division by zero
////    zero = 1;
////}

////// C#(or F#/VB) -> compiled (changed into another language) into Common Runtime Language CLR -> Assembly Language


//////compile time error - when the code is building/compiling
//////runtime error - when the code is technically correct, so it builds and runs, but then something breaks
////dynamic dynamicVar;
////object objVar; //POCO - plain old C# object


////int newValue = value / zero; 
//////Console.WriteLine(intvalue);
//////Console.WriteLine(doubleValue);
//////Console.WriteLine(decimalValue);
//////Console.WriteLine(floatValue);
Console.WriteLine("Hello");


//type  variable name          Classes need to be instantiated with the 'new' keyword
Random randomNumberGenerator = new Random();
int numberToGuess = randomNumberGenerator
                        .Next(
                              1
                              ,
                              11
                              )

                        ;


bool stillGuessing = false;

do
{
    Console.Write("Pick a number between 1 and 10: ");
    string input = Console.ReadLine();
    int inputAsInt = int.Parse(input);
    if (numberToGuess == inputAsInt)
    {
        stillGuessing = false;
    }
} while (stillGuessing);

Console.WriteLine($"You finally guessed the number. It was {numberToGuess}.");


//ternary - syntactic sugar
//string responseText = correctGuess ?
//    $"That's right, the number I was thinking of was {numberToGuess}!" :
//    $"Wow, you're bad this.  I was thinking of {numberToGuess} but you guessed {input}.";

////string correctResponse = ;
////string incorrectResponse = ;

//Console.WriteLine(responseText);

//////if (correctGuess)
//////{
//////    Console.WriteLine(responseText);
//////}
//////else
//////{
//////    Console.WriteLine(responseText);
//////}

//using System.Text;

//DateTime timeStarted = DateTime.Now;

////immutable
//StringBuilder sb = new StringBuilder(); //abstraction
//for (int counter = 0; counter < 100_000_000; counter++)
//{
//    //text += counter.ToString();
//    sb.Append(counter);
//}

//StringBuilder builder;
////? turns a non-nullable type (can't ever be null) into a nullable type (can be null)
//int? timesWon = null;
////complex process here
//bool? verified = null;

//if (timesWon == null || timesWon is null)
//{
//    //do something else that should happen when they don't even attempt to play
//}
//else if (timesWon == 0)
//{
//    //do something else
//}
//else if (timesWon > 0)
//{
//    //do some stuff if they played and won at least once
//}

//switch (timesWon)
//{
//    case 0:
//        //do some stuff when it's 0
//        break;
//    case 1:
//    //do some 1 stuff

//    default:
//        break;
//}

//for (int i = 0; i < 10; i++)
//{

//}

//foreach (char letter in "Brian")
//{
//    Console.WriteLine(letter);
//}


//bool stillGuessing = true;
//while (stillGuessing)
//{
//    //check if they guessed right
//    if (guessedRight)
//    {
//        stillGuessing = false;
//    }
//}




//DateTime timeEnded = DateTime.Now;
//Console.WriteLine($"Started: {timeStarted}  Ended: {timeEnded}");

Console.ReadLine();