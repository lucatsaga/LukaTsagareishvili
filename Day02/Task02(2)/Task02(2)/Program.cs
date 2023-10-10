// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string n1 = "Giorgi";
string n2 = "Nino";
string n3 = "Avtandili";
string n4 = "Fridoni";
string n5 = "Maia";

string[]Names = new string[5] {n1,n2, n3, n4, n5};

Console.WriteLine("Ramden elementiania masivi?");
var ArraySize = Convert.ToInt32(Console.ReadLine());
string[]LastName = new string[ArraySize];

for (int i = 0; i < LastName.Length; i++)
{
    int c = i + 1;
    Console.WriteLine("Gvari #" + c);
    var input = Console.ReadLine();
    LastName[i] = input;
}

string[]CombinedArray = new string[Names.Length];
for (int j = 0; j < Names.Length; j++)
{
    CombinedArray[j] = $"{Names[j]} {LastName[j]}";
    Console.WriteLine(CombinedArray[j]);
}


