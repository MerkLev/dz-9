Console.WriteLine("Введите значене N:  ");
int N= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значене M:  ");
int M= Convert.ToInt32(Console.ReadLine());
int sum=0;
void NatSum(int N)
{
    while (N<=M)
    if(N>0)
    {
        sum+=N;
        N+=1;
    }
    else
    {
        N++;
    }
    Console.WriteLine(sum);
}

Console.Write($"Сумма натуральных чисел от ({N}) до ({M}):    ");
NatSum(N);