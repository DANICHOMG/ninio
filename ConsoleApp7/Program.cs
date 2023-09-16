﻿using System;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Hello, type first message: ");
string first = Console.ReadLine();
Console.WriteLine("Hello, type second message: ");
string second = Console.ReadLine();

bool oi = true;

while (oi)
{
    if (string.Compare(first, second) == 0)
    {
        Console.WriteLine("Similar!");
        oi = false;

    }
    else
    {
        Console.WriteLine("No, they are not similar");
        break;
    }
}

//Друга частина 

Console.WriteLine("Write you sentence: ");
string aaaa = Console.ReadLine();
Analyze(aaaa);
static void Analyze(string aaaa)
{

    int letters = 0;
    int digits = 0;
    int specials = 0;

    foreach (char c in aaaa)
    {
        if (char.IsLetter(c))
        {
            letters++;
        }
        else if (char.IsDigit(c))
        {
            digits++;
        }
        else
        {
            specials++;
        }
    }

    Console.WriteLine($"In your sentence ({aaaa}) there are {letters} letters, {digits} digits, {specials} special symbols.");


}

//Третя частина

Console.WriteLine("Write you word: ");
string abaa = Console.ReadLine();
char[] characters = abaa.ToCharArray();
Array.Sort(characters);
string sortedString = new string(characters);
Console.WriteLine(sortedString);

//Четверта частина
Console.WriteLine("Введите текст:");
string text = Console.ReadLine();

char[] result = new char[text.Length];
int resultIndex = 0;

for (int i = 0; i < text.Length - 1; i++)
{
    for (int j = i + 1; j < text.Length; j++)
    {
        if (text[i] == text[j])
        {
            result[resultIndex] = text[i];
            resultIndex++;
        }
    }
}


Console.WriteLine("Похожие символы:");
for (int i = 0; i < resultIndex; i++)
{
    Console.Write(result[i] + " ");
}




