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
    Console.WriteLine("program 6) Tic - tac -toe");

    string nr = Console.ReadLine();
    int program;
    if(nr == "1" || nr == "2" || nr == "3" || nr == "4" || nr == "5" || nr == "6")
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
        //baklänges räknande
        Console.WriteLine(""); Console.WriteLine("");
        Console.WriteLine("Skrv saker som du vill ha upprepat baklänges");
        string [] n1;
        int i1,j1;
        string input2 = "null";
        n1 = new string[1000];

        for(i1 = 1;input2 != ""; i1++){
            input2 = Console.ReadLine();
            if(input2 != ""){
            n1[i1] = input2;}
            if(i1 == 900){
                Console.WriteLine("Maximalt antal rader");
                break;
            }
        }

        Console.WriteLine("");
        Console.WriteLine("Tryck enter för att se baklänges");
        Console.ReadLine();

        for (j1 = i1 - 2; j1 > 0; j1--){
            Console.WriteLine(n1[j1]);
        }
        

    }




    else if (program == 6) {
        //Tic - tac - toe
        Console.WriteLine(""); Console.WriteLine("");
        Console.WriteLine("Tic - tac - toe");Console.WriteLine();Console.WriteLine("skriv x kordinaten först sedan y");
        int Xpoäng = 0;
        int Opoäng = 0;
        do{
            Console.WriteLine("");

            char[,] bräde1 = new char[,]{   {'-','-','-'},
                                            {'-','-','-'},
                                            {'-','-','-'} };
            
    
            Console.WriteLine("      1   2   3"); Console.WriteLine("     ___________");
            for(int j2 = 0; j2 < bräde1.GetLength(0); j2++)
            { 
                Console.WriteLine("{0}   | {1}   {2}   {3} |", j2+1, bräde1[j2,0], bräde1[j2,1], bräde1[j2,2]);
                if(j2<2)
                    Console.WriteLine("    |           |");
                else
                Console.WriteLine("     ¯¯¯¯¯¯¯¯¯¯¯");
            }

            int binärräknare1 = 1;
            int x1, y1;
            bool Xwin = false;
            bool Owin = false;
            bool draw1 = false;

            while(true)
            {
                binärräknare1 = binärräknare1 - binärräknare1 * 2;
                string xellero;
                while(true){
                    if(binärräknare1 == -1)
                    {
                        xellero = "x";
                    }
                    else 
                    {
                        xellero = "o";
                    }
                    Console.WriteLine("Det är spelare {0}'s tur", xellero);
                    x1 = int.Parse(Console.ReadLine())-1; 
                    y1 = int.Parse(Console.ReadLine())-1;
                    Console.WriteLine();
                    if(bräde1[x1,y1] == '-'){
                        if(binärräknare1 == -1){
                            bräde1[x1,y1] = 'x';
                        }else
                            bräde1[x1,y1] = 'o';
                        Console.WriteLine();
                        break;    
                    }else
                        Console.WriteLine("den rutan är upptagen, välj en annan");
                    
                }

                

                Console.WriteLine("      1   2   3"); Console.WriteLine("     ___________");
                for(int i2 = 0; i2 < bräde1.GetLength(0); i2++)
                {    
                    
                    Console.WriteLine("{0}   | {1}   {2}   {3} |", i2+1, bräde1[0,i2], bräde1[1,i2], bräde1[2,i2]);
                    if(i2<2)
                        Console.WriteLine("    |           |");
                    else
                        Console.WriteLine("     ¯¯¯¯¯¯¯¯¯¯¯");
                                        
                }
                int i = 0;

                for(int i2 = 0; i2 <  bräde1.GetLength(0); i2++){
                    if(bräde1[0,i2] != '-' && bräde1[1,i2] != '-' && bräde1[2,i2] != '-'){
                        i++;
                    }
                    if(i == 3)
                        draw1 = true;
                    

                }

                for(int i2 = 0; i2 < 6; i2++){ 
                    //wincondition X
                    if(i2<3){
                        if(bräde1[0,i2] == 'x' && bräde1[1,i2] == 'x' && bräde1[2,i2] == 'x')
                            Xwin = true;
                    }else{
                        if(bräde1[i2-3,0] == 'x' && bräde1[i2-3,1] == 'x' && bräde1[i2-3,2] == 'x')
                            Xwin = true;
                    }
                for(int j2 = 0; j2 < 6; j2++){
                    //wincondition O
                    if(j2<3){
                        if(bräde1[0,j2] == 'o' && bräde1[1,j2] == 'o' && bräde1[2,j2] == 'o')
                            Owin = true;
                    }else{
                        if(bräde1[j2-3,0] == 'o' && bräde1[j2-3,1] == 'o' && bräde1[j2-3,2] == 'o')
                            Owin = true;
                    }    
                }
                i = 0;

                for(int j2 = 0; j2 < 3; j2++){ 
                    if(bräde1[j2,j2] == 'x')
                        i++;
                    
                    if(i == 3)
                        Xwin = true;
                }
                i = 0;
                for(int j2 = 0; j2 < 3; j2++){
                    if(bräde1[j2,j2] == 'o')
                        i++;
                    if(i == 3)
                        Owin = true;
                }
                i = 0;
                for(int j2 = 0; j2 < 3; j2++){
                    if(bräde1[j2,2-j2] == 'o')
                        i++;
                    if(i == 3)
                        Owin = true;
                }
                i = 0;
                for(int j2 = 0; j2 < 3; j2++){
                    if(bräde1[j2,2-j2] == 'x')
                        i++;
                    if(i == 3)
                        Xwin = true;
                } //jag vet att det här är väldigt ineffektivt, men jag orkar inte optimera det


                }
                if(Xwin == true){
                    Xpoäng++;
                    Console.WriteLine("X har vunnit");
                    Console.WriteLine("X:{0}",Xpoäng);
                    Console.WriteLine("O:{0}",Opoäng);
                    break;
                } else if(Owin == true){
                    Opoäng++;
                    Console.WriteLine("O har vunnit");
                    Console.WriteLine("X:{0}",Xpoäng);
                    Console.WriteLine("O:{0}",Opoäng);
                    break;
                } else if (draw1 == true){
                    Console.WriteLine("ingen har vunnit");
                    Console.WriteLine("X:{0}",Xpoäng);
                    Console.WriteLine("O:{0}",Opoäng);
                    break;
                }
            }
            Console.WriteLine();Console.WriteLine("vill du fortsätta spela tic-tac-toe? ja/nej");
            string slutfråga1 = Console.ReadLine();
            if(slutfråga1 == "nej" || slutfråga1 == "Nej"){
                break;
            } else if(slutfråga1 == "ja" || slutfråga1 == "Ja"){} else{
                Console.WriteLine("det var dessvärre inte ett förväntat komando, så jag kommer att anta att du vill fortsätta spela");
            }
        }while(true);
    }




    else
        Console.WriteLine("det programmet fins inte, välj ett program mella 1 och 6");
    
    Console.WriteLine("");
    Console.WriteLine("Vill du köra något annat program? ja / nej");

    string slutfråga = Console.ReadLine();
    if (slutfråga == "ja" || slutfråga == "Ja"){

    } else if (slutfråga == "nej" || slutfråga == "Nej") {
        break;
    }

}
