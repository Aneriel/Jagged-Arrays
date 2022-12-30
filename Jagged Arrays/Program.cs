static char[][] ReadJaggedArrayFromStdInput()
{
    int rows = int.Parse(Console.ReadLine());

    char[][] jagged = new char[rows][];
    for (int i = 0; i < rows; i++)
    {
        string[] parts = Console.ReadLine().Split(' ');
        jagged[i] = new char[parts.Length];
        for (int j = 0; j < parts.Length; j++)
        {
            jagged[i][j] = char.Parse(parts[j]);
        }
    }

    return jagged;
}

static void PrintJaggedArrayToStdOutput(char[][] tab)
{
    for (int i = 0; i < tab.Length; i++)
    {
        for (int j = 0; j < tab[i].Length; j++)
        {
            Console.Write(tab[i][j] == '\x00' ? ' ' : tab[i][j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

static char[][] TransposeJaggedArray(char[][] tab)
{
    int columns = 0;
    for (int i = 0; i < tab.Length; i++)
    {
        columns = Math.Max(columns, tab[i].Length);
    }


    char[][] transposed = new char[columns][];
    for (int i = 0; i < columns; i++)
    {
        transposed[i] = new char[tab.Length];
    }


    for (int i = 0; i < tab.Length; i++)
    {
        for (int j = 0; j < tab[i].Length; j++)
        {
            transposed[j][i] = tab[i][j];
        }
    }

    return transposed;
}
