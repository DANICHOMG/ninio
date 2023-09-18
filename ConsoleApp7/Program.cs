
static void FirstTask()
{
    static bool compare(string a, string b)
    {
        if (a.Length != b.Length)
        {
            return false;
        }
        if (a == null || b == null)
        {
            return false;
        }
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i])
            {

                return false;
            }
        }

        return true;
    }
}

//Друга частина 
static void Analyze()
{
    Console.WriteLine("Write you sentence: ");
    string aaaa = Console.ReadLine();

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

static void ThirdTask()
{

    Console.WriteLine("Write you word: ");
    string abaa = Console.ReadLine();
    char[] characters = abaa.ToCharArray();
    Array.Sort(characters);
    string sortedString = new string(characters);
    Console.WriteLine(sortedString);
}

//Четверта частина

static void FourTask()
{
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
}
