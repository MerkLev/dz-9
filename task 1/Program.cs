Console.Write("Введите значене N:  ");
int N= Convert.ToInt32(Console.ReadLine());


int NatNumber(int N)
{
    int sum=N;
    if (N!=0)
    {
        sum+=NatNumber(N-1);
    }
    return sum;
}
Console.Write($"Сумма натуральных чисел до числа ({N}) = ");
Console.Write(NatNumber(N));