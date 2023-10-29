// See https://aka.ms/new-console-template for more information
using Day05;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");
//Triangle myTriangle = new Triangle(25,22,20);
//myTriangle.Perimeter();
//myTriangle.Area();

//Rectangle myRectangle = new Rectangle(25, 32);
//myRectangle.Perimeter();
//myRectangle.Area();

//Circle myCircle = new Circle(22);
//myCircle.Perimeter();
//myCircle.Area();




while (true)
{
    Console.WriteLine("airchiet figura:");
    Console.WriteLine("1. Triangle");
    Console.WriteLine("2. Rectangle");
    Console.WriteLine("3. Circle");
    Console.WriteLine("4. Exit");
    Console.Write("sheiyvanet figura (1/2/3/4): ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("sheiyvanet samkutxedis gverdebi");
            Triangle myTriangle = new Triangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            myTriangle.Perimeter();
            myTriangle.Area();
            break;
        case "2":
            Console.WriteLine("sheiyvanet otkutxedis gverdebi");
            Rectangle myRectangle = new Rectangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            myRectangle.Perimeter();
            myRectangle.Area();
            break;
        case "3":
            Console.WriteLine("sheiyvanet wrewiris radiusi");
            Circle myCircle = new Circle(int.Parse(Console.ReadLine()));
            myCircle.Perimeter();
            myCircle.Area();
            break;
        case "4":
            Console.WriteLine("sheiyvanet samkutxedis gverdebi");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("araswori cda. Gtxovt tavidan cadot");
            break;
    }




}



//Console.WriteLine("Sheiyvanet samkutxedis gverdebi");
//Console.WriteLine("gverdi1");
//int gverdi1 = int.Parse(Console.ReadLine());
//Console.WriteLine("gverdi2");
//int gverdi2= int.Parse(Console.ReadLine());
//Console.WriteLine("gverdi3");
//int gverdi3 = int.Parse(Console.ReadLine());
//Triangle myTriangle = new Triangle(gverdi1, gverdi2, gverdi3);
//myTriangle.Perimeter();
//myTriangle.Area();