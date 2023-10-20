// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

////Task1
//SumNumbers([3], -213123);
////int[] myArray = new int[] { 251, 115, 332 };
////int index = 425;

////int result = SumNumbers(myArray, index);



//int SumNumbers(int[] myArray, int index)
//{
//    index = Math.Abs(index); //Checking a variable to be in positive state
//    string NumberStr = index.ToString(); //Converting int to String

//    int sum = 0;

//    foreach (char digitChar in NumberStr)
//    {
//        if (char.IsDigit(digitChar)) //Checking that each char is digit
//        {
//            int digit = digitChar - '0';
//            sum += digit;
//        }
//    }
//    Console.WriteLine(sum);
//    return sum;

//}






//Task2
Console.WriteLine("Sheiyvanet masivis zoma: ");
int size = int.Parse(Console.ReadLine());

if (size <= 0)
{
    Console.WriteLine("Masivis zoma unda iyos 0-ze meti");
    return;
}

char[] charArray = new char[size];

Console.WriteLine("Sheiyvanet symboloebi charis shesavsebad");

for (int i = 0; i < size; i++)
{
    Console.Write($"Char {i + 1}: ");
    charArray[i] = Console.ReadKey().KeyChar;
    Console.WriteLine();
}

string originalString = new string(charArray);

Console.WriteLine("String: " + originalString);

char randomChar = GetRandomChar();
Console.WriteLine($"Random character: {randomChar}");

int charCount = CountCharacter(originalString, randomChar);
Console.WriteLine($"Symbolo '{randomChar}' gvxvdeba {charCount} -jer stringshi.");


// Method #1: Random charis dagenerireba
char GetRandomChar()
{
    Random random = new Random();
    char randomChar = (char)random.Next(97, 123);
    return randomChar;
}

// Method #2: Ramdenjer gxvdeba Random char stringshi
int CountCharacter(string str, char targetChar)
{
    int count = 0;

    foreach (char c in str)
    {
        if (c == targetChar)
        {
            count++;
        }
    }

    return count;
}