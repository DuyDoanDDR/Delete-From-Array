int[] Value = new int[] { 10, 4, 6, 7, 8, 6, 0, 0 };
int n = Value.Length;

Console.WriteLine("Nhap phan tu can xoa: ");

if (int.TryParse(Console.ReadLine(), out int target) && target >= 0)
{
    for (int i = 0; i < n - 1; i++)
    {
        if (target == Value[i])
        {
            for (int j = i; j < n - 1; j++)
            {
                Value[j] = Value[j + 1];
            }
            Value[n - 1] = 0;

            break;
        }
    }
}

Console.WriteLine("Mang moi: ");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(Value[i] + "");
}
