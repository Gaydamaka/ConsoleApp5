Console.WriteLine("Введите количество степенек на лестнеце: ");
int stairs = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < stairs; i++)
{
    for (int j = 0; j < i * 2; j++)
    {
        Console.Write(" ");
    }
    Console.WriteLine("***");

    for (int j = 0; j < i * 2; j++)
    {
        Console.Write(" ");
    }
    Console.WriteLine("  *");

}

          