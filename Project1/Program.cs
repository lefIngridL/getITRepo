// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hei, hva heter du?");
string userInput = Console.ReadLine();
Console.WriteLine($"Velkommen {userInput}");
int tall = 1;
string text = "Hei på deg";
float desi1 = 0.01F;
double desi2 = 0.01;
decimal desi3 = 0.01M;
long desi4 = 100L;
char letter = 'A';
bool isTrue = true;
int[] tallArray = { 1, 2, 3 };
string[] textArray = { "en", "to", "tre" };
List<int> mineTall = new List<int>();

static int NumberFive() => 5;

int a = 5;
decimal b = 3.0M;
decimal sum = a + b;
Console.WriteLine(sum);


Console.WriteLine("skriv et heltall");
var nr1 =  Console.ReadLine();
Console.WriteLine("skriv et nytt heltall");
var nr2 =  Console.ReadLine();
Console.WriteLine(nr2.GetType());

int int1 = int.Parse(nr1);
int int2 = int.Parse(nr2);
Console.WriteLine(int1.GetType());
Console.WriteLine(int2.GetType());
Console.WriteLine($"du skrev {int1} og {int2}");

int summer = AddInts(int1, int2);
static int AddInts(int input1, int input2) => (int)(input1 + input2);
Console.WriteLine($"summen av tallene er {summer}");

static void returnNone()
{
    Console.WriteLine("Denne metoden returnerer ingenting");
    return;
}

Random random = new Random();
var randomNumber = random.Next(0, 3);
if( randomNumber == 0)
{
    Console.WriteLine("tallet ble 0");
}
else if( randomNumber == 1)
{
    Console.WriteLine("tallet ble 1");
}
else 
{
    Console.WriteLine("tallet ble 2");
}
