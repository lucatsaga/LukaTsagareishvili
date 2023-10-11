// See https://aka.ms/new-console-template for more information
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;

//Console.WriteLine("Hello, World!");

//Console.WriteLine("Array1");
//int ArraySize1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Array2");
//int ArraySize2 = Convert.ToInt32(Console.ReadLine());
//int[,] myIntArr = new int[ArraySize1, ArraySize2];
//int firstDem = myIntArr.GetLength(0);
//int secondDem = myIntArr.GetLength(1);
//for (int i = 0; i < firstDem; i++)
//{
//    Console.WriteLine("Sheiyvanet ricxvebi");
//    var input = Console.ReadLine();
//    firstDem[i] = Convert.ToInt32(input);
//}



{
    Console.WriteLine("Sheavset matricis mnishvnelobebi (2x2 or 3x3):");
    Console.Write("Rows: ");
    int rows = int.Parse(Console.ReadLine());
    Console.Write("Columns: ");
    int columns = int.Parse(Console.ReadLine());

    if ((columns == 2 && rows == 2) || (columns == 3 && rows == 3))
    {
        int[,] matrix = new int[rows, columns];

        Console.WriteLine("Sheavset matricis mnishvnelobebi:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Row {i + 1}, column {j + 1}: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("MAtrica romelic sheiyvanet:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int determinant = CalculateDeterminant(matrix);
        Console.WriteLine("Determinant: " + determinant);
    }
    else
    {
        Console.WriteLine("Araswori matrica. Mxolod da mxolod shegidzliat sheiyvanot matricebi : 2x2 an 3x3.");
    }
}

static int CalculateDeterminant(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    if (rows == 2 && columns == 2)
    {
        return (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
    }
    else if (rows == 3 && columns == 3)
    {
        return
            matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) -
            matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) +
            matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
    }
    return 0; 
}



