// See https://aka.ms/new-console-template for more information
Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("Välj ett program");
Console.WriteLine("program 1) väder");
Console.WriteLine("program 2) summa och differens");
Console.WriteLine("program 3) Nuvarande uppgift");

string nr = Console.ReadLine();
int program;
if(nr == "1" || nr == "2" || nr == "3")
    program = int.Parse(nr);
else
    program = 0;



if(program == 1)
{

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Är det fint väder?");
string väder = Console.ReadLine();
Console.WriteLine("");

bool Ja = väder == "j" || väder == "J" || väder == "Ja" || väder == "ja";
bool Nej = väder == "n" || väder == "N" || väder == "Nej" || väder == "nej";

if(Ja)
    Console.WriteLine("Vi går på picknick!");
else if(Nej)
    Console.WriteLine("Vi stannar inne och läser en bok");
else
    Console.WriteLine("Jag förstår inte");

Console.WriteLine("");
Console.WriteLine("");
}




else if(program == 2)
{
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Skriv två heltal vars summa och differens ska räknas ut");

string strNr = Console.ReadLine();
int tal1 = int.Parse(strNr);

string strNr2 = Console.ReadLine();
int tal2 = int.Parse(strNr2);
int max;
int min;

if (tal1 < tal2) {
	max = tal2;
	min = tal1;
} else {
max = tal1;
min = tal2;
}

int intSum = max + min;
string strSum = intSum.ToString();

int intDif = max - min;
string strDif = intDif.ToString();

string strMax = max.ToString();
string strMin = min.ToString();

Console.WriteLine("");
Console.WriteLine("Svar: summan av {0} och {1} är {2} medans differensen mellan {0} och {1} är {3}", strMax, strMin, strSum, strDif);
}




else if(program == 3)
{
    int räkna = 1;

    while (räkna < 20);
    {
        
    }
    //work in progres
}

else
Console.WriteLine("det programmet fins inte, välj ett program mälla 1 och 2");