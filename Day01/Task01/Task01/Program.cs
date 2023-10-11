// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

{
    Random random = new Random();
    int randomNumber = random.Next(1, 10); // Random ricxvis dagenerireba 1-10-s shoris
    int numberOfTries = 3;
    bool isWinner = false;

    Console.WriteLine("Mogesalmebit, tamasshi Gamoicani cifri");
    Console.WriteLine($"Tkven gaqvt {numberOfTries} cda rata gamoicnot swori cifri.");

    for (int tries = 1; tries <= numberOfTries; tries++)
    {
        Console.Write($"Cda {tries}: sheiyvanet sasurveli cifri, shualedshi (1-10): ");
        int userGuess = Convert.ToInt32(Console.ReadLine());

        if (userGuess == randomNumber)
        {
            isWinner = true;
            break;
        }
        else 
        {        
            if(tries == numberOfTries)
            {
                Console.WriteLine($"Samwuxarod cdebis raodenoba amoiwura. Swori ricxvi iyo - {randomNumber}");
                break;
            }
            if(tries <=numberOfTries)
            {
                Console.WriteLine("Araswori ricxvi. Kidev scadet.");
            }
        }
    }

    if (isWinner)
    {
        Console.WriteLine($"Gilocavt! Tkven gamoicanit Random cifri - ({randomNumber}).");
    }
}
