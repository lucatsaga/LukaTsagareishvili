// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

////Task1
//int[] myArray = new int[] { 254, 123, 532 };
//int index = -1;

//int result = CalculateDigitSum(myArray, index);

//Console.WriteLine($"elmentebis jami, index # {index} aris: {result}");


//int CalculateDigitSum(int[] array, int index)
//{
//    if (index >= 0 && index < array.Length)
//    {
//        int element = array[index];
//        int sum = 0;

//        while (element > 0)
//        {
//            int digit = element % 10;
//            sum += digit;
//            element /= 10;
//        }

//        return sum;
//    }
//    else
//    {
//        throw new IndexOutOfRangeException("Araswori Index");
//    }
//}




//task 2

    char[] userCharArray = GetCharArray();
    
    char[] GetCharArray()
{
    Console.WriteLine("Sheiyvanet masivis zoma: ");
    int size = int.Parse(Console.ReadLine());

    if (size <= 0)
    {
        Console.WriteLine("Masivis zoma unda iyos 0-ze meti");
        return null;
    }

    char[] charArray = new char[size];

    Console.WriteLine("Sheiyvanet symboloebi charis shesavsebad");

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Char {i + 1}: ");
        charArray[i] = Console.ReadKey().KeyChar;
        Console.WriteLine();
    }

    return charArray;
}

string originalString = new string(userCharArray);

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
