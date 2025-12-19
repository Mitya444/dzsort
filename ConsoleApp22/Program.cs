

var random = new Random();
int[,] arrange = new int[5, 5];

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        arrange[i, j] = random.Next(-10, 10);
    }
}

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(arrange[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int[] simarrange = new int[25];
int k = 0;

for (int i = 0; i < 5; i++)
{
    for (int j = 0;j < 5; j++)
    {
        simarrange[k++] = arrange[i, j];
    }
}

for (int i = 0; i < simarrange.Length - 1; i++)

    for (int j = 0; j < simarrange.Length; j++)
    {
        if (j < simarrange.Length - 1)
        {
            if (simarrange[j] > simarrange[j + 1])
            {
                var temp = simarrange[j];
                simarrange[j] = simarrange[j + 1];
                simarrange[j + 1] = temp;
            }
        }
    }



k = 0;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        arrange[i, j] = simarrange[k++];
    }
}

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(arrange[i, j] + " ");
    }
    Console.WriteLine();
}