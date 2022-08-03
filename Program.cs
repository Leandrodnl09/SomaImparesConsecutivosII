// Exercício do site URI "Soma Impares Consecutivos I"
// Leia um valor inteiro N que é a quantidade de casos de teste que vem a seguir. Cada caso de teste consiste de dois inteiros X e Y.
// Você deve apresentar a soma de todos os ímpares existentes entre X e Y.

int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    string[] Num = Console.ReadLine().Split(' ');
    int X = int.Parse(Num[0]);
    int Y = int.Parse(Num[1]);

    if (X > Y)
    {
        int Troca = X;
        X = Y;
        Y = Troca;
    }
    int Soma = 0;
    for (int j = X + 1; j < Y; j++)
    {
        if (j % 2 != 0)
        {
            Soma = Soma + j;
        }        
    }
    Console.WriteLine(Soma);
}
