Console.WriteLine("hej äventyrare vad är ditt namn?");

string name = Console.ReadLine();



Console.WriteLine($"trevligt att träffas {name} vi behöver din hjälp att rädda byns bagare! vill du hjälpa oss? ");
Console.WriteLine("a= ja, b= nej");
string bra = Console.ReadLine();

if (bra == "a")

{

    Console.WriteLine("wow vad modigt, bagaren har blivit kidnappad av den onda kungen. Det finns två vägar till kungens slott.");
    Console.WriteLine("vilken väg vill du ta? vill du gå genom den mörka skogen eller segla över sjön? ");
    Console.WriteLine(" a= skogen, b= sjön");

    string väg = Console.ReadLine();

    if (väg == "a")

    {

        Console.WriteLine("du fortsätter genom den mörka skogen. något lyser från marken, Det är ett svärd! du tar med det ifall.");
        Console.WriteLine("du kommer fram till slotts dörren men någon står och väntar framför den.");
        Console.WriteLine("vill du använda ditt svärd för att dräpa vakten eller vill försöka övertala honnom att låta dig gå in i slottet?");
        Console.WriteLine("a= använd svärdet, b= övertala honnom");
        string svärd = Console.ReadLine();
        if (svärd == "a")
        {
            Console.WriteLine("vakten ber om sitt liv, Han har en familj! men du slår ner honnom med ditt svärd");
            Console.WriteLine("du fortsätter in i slottet. Där ser du bagaren, men han värkar göra kakor till invånarna av byn med gift i dem! ");
            Console.WriteLine("vill du döda bakaren eller prata med honnom");
            Console.WriteLine("a=döda, b= prata");
            string potatis = Console.ReadLine();
            if (potatis == "a")
            {
                Console.WriteLine($" {namn} lyfter sitt svärd och tar bagarens liv. byn är räddad men vad kostade det?");

            }

            else if (potatis == "b")

            {
                Console.WriteLine($"du försöker prata med bagaren men du är fylld av bloodlust,")



        }


        }


    }

    else if (väg == "b")

    {

        Console.WriteLine("du går ner mot stranden och dar upp den rostiga båten. ");
        Console.WriteLine("du får klump i magen när du kollar ut över de svarta vattnet");

    }

    else

    {

        Console.WriteLine("nu blev det fel, du måste börja om nu :(");

    }

}

else if (bra == "b")

{

    Console.WriteLine("wow vilken bra äventyrare du är! aja antar att spelet är klart här då......");

}

else

{

    Console.WriteLine("sådär kan man inte skriva, nu får du börja om helt från början! :)");

}

Console.ReadLine();


































// Console.WriteLine("hej, vad heter du?");

// string name = Console.ReadLine();

// Console.WriteLine($" Hej {name}");

// if (name == "Henry")
// {
//     Console.WriteLine("vad fin du är idag!");
// }

// else if (name == " Martin ")
// {
//     Console.WriteLine("uuuussshhhh!");
// }
// else
// {
//     Console.WriteLine("vad ful du är idag!");


//Console.ReadLine();

