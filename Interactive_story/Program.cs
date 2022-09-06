Console.WriteLine("hej äventyrare vad är ditt namn?");

string name = Console.ReadLine();



Console.WriteLine($"trevligt att träffas {name} vi behöver din hjälp att rädda byns bagare! vill du hjälpa oss? ");

string bra = Console.ReadLine();

if (bra == "ja")

{

    Console.WriteLine("wow vad modigt, bagaren har blivit kidnappad av den onda kungen. Det finns två vägar till kungens slott.");

    Console.WriteLine("vilken väg vill du ta? vill du gå genom den mörka skogen eller segla över sjön?");

     string väg = Console.ReadLine();

    if (väg == "skogen")

    {

        Console.WriteLine("du fortsätter genom den mörka skogen. något lyser från marken, Det är ett svärd! du tar med det ifall.");
        Console.WriteLine("du kommer fram till slotts dörren men någon står och väntar framför den.");



    }

    else if ( väg == "sjön")

    { 

        Console.WriteLine("du går ner mot stranden och dar upp den rostiga båten. ");
        Console.WriteLine( "du får klump i magen när du kollar ut över de svarta vattnet");

    }

    else 

    {

     Console.WriteLine( "nu blev det fel, det kanske var ett stavfel eller nåt men du måste börja om nu :(");

    }

}

else if (bra == "nej")

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

