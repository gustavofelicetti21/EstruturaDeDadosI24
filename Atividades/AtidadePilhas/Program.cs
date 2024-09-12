﻿Console.WriteLine("Digite uma palavra: ");
string? palavra = Console.ReadLine();

Stack<char> caracteres = new Stack<char>();
foreach (char p in palavra)
{
    caracteres.Push(p);
}

string invertido = string.Empty;
while (caracteres.Count > 0)
{
    invertido += caracteres.Pop();
}

if(invertido == palavra) {
    Console.WriteLine("É palindromo");
}
else {
    Console.WriteLine("Não é palindromo");
}