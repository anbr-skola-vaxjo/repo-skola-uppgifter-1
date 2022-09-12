// See https://aka.ms/new-console-template for more information

// Jag ber om ursäkt i förväg för min förfärliga stavning, jag har dyslexi
while(true)
{
    Console.WriteLine(""); Console.WriteLine("");
    Console.WriteLine("Välj ett program");
    Console.WriteLine("program 1) väder");
    Console.WriteLine("program 2) summa och differens");
    Console.WriteLine("program 3) Loop och for uppgifter");
    Console.WriteLine("program 4) medelvärde");
    Console.WriteLine("program 5) baklänges");

    string nr = Console.ReadLine();
    int program;
    if(nr == "1" || nr == "2" || nr == "3" || nr == "4" || nr == "5")
        program = int.Parse(nr);

    else if(nr == "exit" || nr == "") 
        break;

    else
        program = 0;



    if(program == 1) {
        // väder

        Console.WriteLine(""); Console.WriteLine("");
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

        Console.WriteLine(""); Console.WriteLine("");
    }




    else if(program == 2) {
        // summa och differens

        Console.WriteLine(""); Console.WriteLine("");
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




    else if(program == 3) {
        //loop och for program

    
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("loop kod: 1 till 20");

        for(int i1 = 0; i1 <= 20; i1++)
        {
            Console.WriteLine(i1 + "");
        }

        Console.WriteLine(""); Console.WriteLine("");

        Console.WriteLine("skriv ett heltal mellan 1 och 100");
        int räkna2 = int.Parse(Console.ReadLine());
        Console.WriteLine("");

        if(räkna2 <= 100 || räkna2 >= 1){
            while(räkna2 < 101){
                Console.WriteLine(räkna2);
                räkna2++;
            }
            Console.WriteLine("");
        } else {
            Console.WriteLine("Det är inte ett heltal mellan 1 och 100");
        }
        Console.WriteLine("skriv ett till heltal mellan 1 och 100");
        
        int räkna3 = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        int index1 = 100;
        if(räkna3 <= 100 || räkna3 >= 1){
            while(index1 >= räkna3){
            Console.WriteLine(index1);
            index1--;
            }

        } else {
            Console.WriteLine("skriv ett till heltal mellan 1 och 100");
        }

    }




    else if(program == 4) {
        //Medelvärde
        Console.WriteLine("");
        Console.WriteLine("program 4");
        Console.WriteLine("");
        Console.WriteLine("skriv de tal som du vill besemma medelvärdet av");
        Console.WriteLine("");

        string input1 = Console.ReadLine();
        double antal1 = 1;
        double summa1 = double.Parse(input1);
        double maxtal1 = double.Parse(input1);
        double mintal1 = double.Parse(input1);

        while(true){
            input1 = Console.ReadLine();
            if (input1 == "slut" || input1 == "stopp" || input1 == "sluta" || input1 == "stop" || input1 == "Slut" || input1 == "Stopp" || input1 == "Sluta" || input1 == "Stop" || input1 == "" )
                break;

            else {
                summa1 = summa1 + double.Parse(input1); 
                antal1++; 

                if(maxtal1 < double.Parse(input1)){
                    maxtal1 = double.Parse(input1);}
                if(mintal1 > double.Parse(input1)){
                    mintal1 = double.Parse(input1);}
            }
        }
        Console.WriteLine(""); Console.WriteLine("summan av dina tal");
        Console.WriteLine(summa1); Console.WriteLine("");
        Console.WriteLine("Största talet var {0} och minsta talet var {1}", maxtal1, mintal1); Console.WriteLine("");
        Console.WriteLine("antal tal"); Console.WriteLine(antal1);Console.WriteLine("");
        
        double medelvärde1 = 1;
        if(antal1 != 0) {
            medelvärde1 = summa1 / antal1;
            Console.WriteLine("medelvärdet är: {0}", medelvärde1);
        } else {
            Console.WriteLine("det fins inget medelvärde");
        }
        Console.WriteLine(""); Console.WriteLine("");
    }




    else if(program == 5) {
        //baklänges räknand
        Console.WriteLine(""); Console.WriteLine("");
        string [] n1;
        int i1,j1;
        string input2 = "null";
        n1 = new string[1000];

        for(i1 = 1;input2 != ""; i1++){
            input2 = Console.ReadLine();
            if(input2 != ""){
            n1[i1] = input2;}
            if(i1 == 900){
                Console.WriteLine("Maximalt antal tal");
                break;
            }
        }

        Console.WriteLine("");
        Console.WriteLine("Tryck enter för att se talen baklänges");
        Console.ReadLine();

        for (j1 = i1 - 2; j1 > 0; j1--){
            Console.WriteLine(n1[j1]);
        }
        

    }



    else
        Console.WriteLine("det programmet fins inte, välj ett program mella 1 och 5");
    
    Console.WriteLine("");
    Console.WriteLine("Vill du fortsätta? ja / nej");

    string slutfråga = Console.ReadLine();
    if (slutfråga == "ja" || slutfråga == "Ja"){

    } else if (slutfråga == "nej" || slutfråga == "Nej") {
        break;
    }

}
