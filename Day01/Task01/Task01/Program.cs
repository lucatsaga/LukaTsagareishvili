// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

//{
//    string input;
//    int res;
//    Console.WriteLine("Input from User:");
//    input = Console.ReadLine();
//    res = Convert.ToInt32(input);
//    Console.WriteLine("Input = {0}", res);

//    Random random = new Random();
//    int randNumber = random.Next(0, 10);

//    Console.WriteLine(randNumber);

//    if (randNumber == res)
//    {
//        Console.WriteLine("cifri gamoicanit");
//    }
//}


//{
//    string input;
//    int res;
//    Console.WriteLine("Input from User:");
//    input = Console.ReadLine();
//    res = Convert.ToInt32(input);
//    Console.WriteLine("Input = {0}", res);

//    Random random = new Random();
//    int randNumber = random.Next(0, 10);
//    Console.WriteLine(randNumber);

//    if (randNumber == res)
//    {
//        Console.WriteLine("cifri gamoicanit");
//    }
//}


//{
//    string input;
//    int res;
//    Console.WriteLine("Input from User:");
//    input = Console.ReadLine();
//    res = Convert.ToInt32(input);
//    Console.WriteLine("Input = {0}", res);

//    Random random = new Random();
//    int randNumber = random.Next(0, 10);
//    Console.WriteLine(randNumber);

//    if (randNumber == res)
//    {
//        Console.WriteLine("cifri gamoicanit");
//    }
//    else
//    {
//        Console.WriteLine("cifri ver gamoicanit da tamashi waaget");
//    }
//}




//    Random random = new Random();
//    int randNumber = random.Next(0, 10);

//Console.Write(randNumber);

//string text = Console.ReadLine();
//    int myInt = Convert.ToInt32(text);
//    Console.WriteLine(myInt);


//int numberOfLoops = 4;
//int loopCounter = 0;

//while (loopCounter < numberOfLoops)
//{
//    string text = Console.ReadLine();
//    int myInt = Convert.ToInt32(text);
//    Console.WriteLine(myInt);

//    if (randNumber == myInt)
//    {
//        Console.WriteLine("Great");
//        break;
//    }
//    else
//    {
//        Console.WriteLine("False");
//    }
//}






//    if (randNumber == myInt)

//{
//    Console.WriteLine("Great");
//}
//else
//{
//    Console.WriteLine("False");
//}

//randNumber = myInt
//} 

//    if (randNumber == myInt)
//    {
//        Console.WriteLine("Great");


//    }
//    else
//    {

//       Console.WriteLine("False");
//    }


//}






Random random = new Random();
int randomNumber = random.Next(1, 10); // vagenerirebt Random cifrs 1-10shualedshi

int numberOfTries = 3;  //cdebis max raodenobistvis shemogvaqvs cvladi
bool Winner = false;

Console.WriteLine("mogesalmebit tamasshi, (gamoicani random cifri) ");
Console.WriteLine($"tqven gakvt {numberOfTries} cda.");

for (int tries = 1; tries <= numberOfTries; tries++)
{
    Console.Write($"Cda {tries}: Sheiyvanet sasurveli cifri (1-10): ");
    int userNumber = Convert.ToInt32(Console.ReadLine());

    if (userNumber == randomNumber)
    {
        Winner = true;
        break; // Tamashi gaitisheba rodesac user gamoicnobs random cifrs
    }
    else
    {
        Console.WriteLine("araswori cifri. kidev scadet.");
    }
}

if (Winner)
{
    Console.WriteLine($"Gilocavt! Tkven sworad gamoicanit Random cifri - ({randomNumber}). ");
}
else
{
    Console.WriteLine($"Samwuxarod tqven amowuret yvela cda. Swori Random cifri iyo - {randomNumber}.");
}