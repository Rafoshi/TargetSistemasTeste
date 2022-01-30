List<int> fibonacciList = new List<int>();
fibonacciList.Add(0);
fibonacciList.Add(1);

int fibonacciNumber1 = 0;
int fibonacciNumber2 = 1;
int fibonacciNumber3;

//Altera o tamanho da sequência
int fibonacciLength = 10000;

//Numero a ser verificado
int inputNumber = 377;

for (int i = 0; i < fibonacciLength; i++)
{
    fibonacciNumber3 = fibonacciNumber1 + fibonacciNumber2;
    fibonacciList.Add(fibonacciNumber3);
    fibonacciNumber1 = fibonacciNumber2;
    fibonacciNumber2 = fibonacciNumber3;
}

if (fibonacciList.Contains(inputNumber))
{
    Console.WriteLine("Este número contém na sequência fibonacci");
}
else
{
    Console.WriteLine("Este número não contém na sequência fibonacci");
}