﻿/*
 * 14   Skriv ett program som läser ett positivt heltal n (n<20) från konsolen 
 *      och skriver ut på konsolen talen 1…n arrangerade som en spiral
 *      
 *      Exempel för n = 4
 *          1  2  3  4
 *          12 13 14 5
 *          11 16 15 6
 *          10 9  8  7
 */

Console.Write("Ange ett tal: ");
byte n = byte.Parse(Console.ReadLine());

int[,] matrix = new int[n, n];
sbyte row = 0, col = -1;
string direction = "right";

Console.WriteLine();
for (int i = 1; i <= n * n; i++)
{
    if (direction == "right")
    {
        if (matrix[row, ++col] == 0) matrix[row, col] = i;
        if (col + 1 >= n || matrix[row, col + 1] != 0) direction = "down";
    }
    else if (direction == "down")
    {
        if (matrix[++row, col] == 0) matrix[row, col] = i;
        if (row + 1 >= n || matrix[row + 1, col] != 0) direction = "left";
    }
    else if (direction == "left")
    {
        if (matrix[row, --col] == 0) matrix[row, col] = i;
        if (col - 1 < 0 || matrix[row, col - 1] != 0) direction = "up";
    }
    else if (direction == "up")
    {
        if (matrix[--row, col] == 0) matrix[row, col] = i;
        if (row - 1 < 0 || matrix[row - 1, col] != 0) direction = "right";
    }
}

PrintMatrix(matrix);




Console.Write("\n\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();

void PrintMatrix(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLongLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLongLength(1); col++)
        {
            Console.Write("{0,4}", matrix[row, col]);
        }

        Console.WriteLine();
        Console.WriteLine();
    }

    Console.WriteLine();
}
