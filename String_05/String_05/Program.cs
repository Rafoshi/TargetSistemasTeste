Console.WriteLine("Digite uma string para ser revertida:\n");
string inputString = Console.ReadLine();

char[] charArray = inputString.ToCharArray();

char[] charArrayReversed = new char[charArray.Length]; 

for (int i = 0, j = inputString.Length - 1; i < inputString.Length; i++, j--)
{
    
    charArrayReversed[i] = charArray[j];
}

Console.WriteLine(charArrayReversed);