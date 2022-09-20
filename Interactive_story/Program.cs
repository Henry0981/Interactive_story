Console.WriteLine("hej äventyrare vad är ditt namn?");

string name = Console.ReadLine();

Console.WriteLine($"trevligt att träffas {name} vi behöver din hjälp att rädda byns bagare! vill du hjälpa oss? ");

Console.WriteLine("a= ja, b= nej");
string bra = "";
while (bra !="a" && bra != "b")
{
 bra = Console.ReadLine();
 if (bra != "a" && bra != "b")
 {
    Console.WriteLine(" du måste välja mellan a eller b");
 }

}
if (bra == "a")
{
    Console.WriteLine("wow vad modigt, bagaren har blivit kidnappad av den onda kungen. Det finns två vägar till kungens slott.");
    Console.WriteLine("vilken väg vill du ta? vill du gå genom den mörka skogen eller segla över sjön? ");
    Console.WriteLine(" a= skogen, b= sjön");

    string väg= "";
    while (väg !="a" && väg != "b" && väg !="c")
    {
        väg = Console.ReadLine(); 
     if (väg != "a" && väg!= "b")
     {
        Console.WriteLine("du måste välja mellan a eller b");
     }
    }

    if (väg == "a")

    {
        Console.WriteLine("du fortsätter genom den mörka skogen. något lyser från marken, Det är ett svärd! du tar med det ifall.");
        Console.WriteLine("du kommer fram till slottet, vad gör du nu?");
        Console.WriteLine("a= försök hitta bagaren, b= attackera den onda kungen, c= spring härifrån");
         string kung = "";
           while (kung !="a" && kung !="b" && kung !="c")
           {
             kung=Console.ReadLine();
             if (väg!="a" && väg!="b" && väg!="c")
             {
                Console.WriteLine();

             }
             

           }

         if (kung == "a")
         {
            Console.WriteLine($"du letar runt lite och till slut hittar du bagaren i en fängelsecell. Verkar som att vakten som ska hålla koll på bagaren är på sin lunchrast!");
            Console.WriteLine("du räddar bagaren! the end");
         }
        
          else if (kung == "b")
          {
           Console.WriteLine("du hittar den onda kungen och använder ditt svärd för att attackera honnom."); 
           Console.WriteLine("du letar runt lite men kan inte hitta bagaren. Någon måste ha tagit honnom");
           Console.WriteLine("the end");
          }
          else if (kung == "c")
          {
            Console.WriteLine("du försöker springa men ramlar och landar på ditt svärd");
            Console.WriteLine("the end");
          }
    }
    else if (väg == "b")
    {
        Console.WriteLine($"{name} går ner mot stranden och dar upp den rostiga båten. i båten hittar du en gammal croissant ");
        Console.WriteLine("efter en lång resa kommer du fram till slottet");
        Console.WriteLine("inuti slotter hittar du bagaren i en fängelsecell. framför bagaren ser du en vakt. vill du attackera vackten eller övertala honnom att låta bagaren gå? ");
        Console.WriteLine("a= attackera vakten, b= övertala vackten");
        string val= Console.ReadLine();
        if (val=="a")   
    {
     Console.WriteLine("du försöker attackera vakten, men du har inget vapen så du förlorar.");
     Console.WriteLine("the end");
    }

     else if (val == "b")
     {
     Console.WriteLine("du försöker övertala vakten men han är hungrig och vägrar lyssna. Vakten tar dig till kungen");
    Console.WriteLine("the end");

     } 
     else if (val=="c")
     {
     Console.WriteLine("du ger vakten din croissant! vakten blir jätteglad och låter dig gå! hur visste du att c skulle funka?");
     Console.WriteLine("secret end");
     }
    
    }
}

  else if (bra == "b")
{
    Console.WriteLine("wow vilken bra äventyrare du är! aja antar att spelet är klart här då......");
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

