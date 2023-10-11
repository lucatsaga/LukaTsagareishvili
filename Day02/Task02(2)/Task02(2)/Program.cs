// See https://aka.ms/new-console-template for more information
using System;
using System.Transactions;

Console.WriteLine("Hello, World!");

////string n1 = "Giorgi";
////string n2 = "Nino";
////string n3 = "Fridoni";
////string n4 = "Gela";
////string n5 = "Levani";

////string[] Name = new string[] { n1, n2, n3, n4, n5 };

//Console.WriteLine("Sheiyvanet #1 masivis zoma");
//int ArraySize = Convert.ToInt32(Console.ReadLine());
//string[] Name = new string[ArraySize];

//for (int i = 0; i < Name.Length; i++)
//{
//    int c = i + 1;
//    Console.WriteLine("Saxeli#" + c);
//    var input = Console.ReadLine();
//    Name[i] = input;

//}




//Console.WriteLine("Sheiyvanet #2 masivis zoma");
//int ArraySize2 = Convert.ToInt32(Console.ReadLine());
//string[] LastName = new string[ArraySize2];

//for (int j = 0; j < LastName.Length; j++)
//{
//    int c = j + 1;
//    Console.WriteLine("Gvari#" + c);
//    var input = Console.ReadLine();
//    LastName[j] = input;

//}
//int d = Math.Max(Name.Length, LastName.Length);
//string[] CombinedArray = new string[d];

////for (int j = 0; j < Name.Length + LastName.Length; j++)

////{
////    if(Name.Length < LastName.Length)

////        Console.WriteLine(Name[j]);


////    }

//int numberOfTries = d;
//for (int o = 0; o < numberOfTries; o++)
//{
//    if (numberOfTries > Name.Length && LastName.Length)
//    {
//        Console.WriteLine($"({Name[o]};{LastName[o]})");
//    }
//    else if(Name.Length < LastName.Length)
//    {
//        Console.WriteLine($"(-; {LastName[o]}");

//    }
//    else if (Name.Length > LastName.Length)
//    {
//        Console.WriteLine($"({Name[o]}; -;");
//    }






//    //int element1 = o < Name.Length ? Name[o] : -1; // Use -1 as a placeholder
//    //int element2 = o < LastName.Length ? LastName[o] - 1 : ; // Use -1 as a placeholder
//    //Console.WriteLine($"({element1};{element2})");
//    ////Name[o] = o >= Name.Length ? Name[o] : string.Empty;
//    ////LastName[o] = o >= LastName.Length ? LastName[o] : string.Empty;
//    ////Console.WriteLine($"({Name};{LastName}");
//}














////CombinedArray[d] = $"{Name[d]} {LastName[d]}";
////for (int i = 0; d > 0; i++)
////    if (Name.Length <= LastName.Length)
////    {
////        Console.WriteLine(CombinedArray[d]);
////    }
////if (Name.Length >= LastName.Length)
////{
////    Console.WriteLine()
////}
////CombinedArray[d] = $"{Name[i]} {LastName[j]}";
////Console.WriteLine(CombinedArray[j]);





Console.WriteLine("Sheiyvanet #1 masivis zoma");
int ArraySize = Convert.ToInt32(Console.ReadLine());
string[] Name = new string[ArraySize];

for (int i = 0; i < Name.Length; i++)
{
    int c = i + 1;
    Console.WriteLine("Saxeli#" + c);
    var input = Console.ReadLine();
    Name[i] = input;

}

Console.WriteLine("Sheiyvanet #2 masivis zoma");
int ArraySize2 = Convert.ToInt32(Console.ReadLine());
string[] LastName = new string[ArraySize2];

for (int j = 0; j < LastName.Length; j++)
{
    int c = j + 1;
    Console.WriteLine("Gvari#" + c);
    var input = Console.ReadLine();
    LastName[j] = input;
}

    int maxLength = Math.Max(Name.Length, LastName.Length);

    for (int i = 0; i < maxLength; i++)
    {
        string name = i < Name.Length ? Name[i] : "";
        string lastName = i < LastName.Length ? LastName[i] : "";
        Console.WriteLine($"{name}; {lastName}");
    }

    