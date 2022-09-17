string[] table = {"Вафля", "Кот", "Уксус", "СO2", "-=+", "да", "Крот"};
string[] table2 = new string [table.Length];

{
    int index = 0;
    for (int i = 0; i < table.Length; i += 1)
    {
    if (table[i].Length <= 3)
        {
            table2[index] = table[i];
            index += 1;
        }
    else
        {
            index += 1;
        }
    }
}
void PrintArray(string[] table)
{
    for (int i = 0; i < table.Length; i += 1)
    {
        Console.Write($"{table[i]} ");
    }
    Console.WriteLine();
}
PrintArray(table2);