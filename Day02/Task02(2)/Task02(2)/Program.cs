// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string n1 = "Giorgi";
string n2 = "Nino";
string n3 = "Fridoni";
string n4 = "Gela";
string n5 = "Levani";

string[] Name = new string[] { n1, n2, n3, n4, n5 };

Console.WriteLine("Sheiyvanet masivis zoma");
int ArraySize = Convert.ToInt32(Console.ReadLine());
string[] LastName = new string[ArraySize];

for (int i = 0; i < LastName.Length; i++)
{
    int c = i + 1;
    Console.WriteLine("Gvari#" + c);
    var input = Console.ReadLine();
    LastName[i] = input;
        
}

string[] CombinedArray = new string[Name.Length];
for (int j = 0; j < Name.Length; j++)
{

    CombinedArray[j] = $"{Name[j]} {LastName[j]}";
    Console.WriteLine(CombinedArray[j]);
}


