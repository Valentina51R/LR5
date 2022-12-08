/*
Console.Write("Введите текс: ");
string text = Console.ReadLine();
Console.WriteLine("\n");

int a = -1;
for (int i = 0; i < text.Length; i++)
{
    if (text[i].Equals('\"'))
    {
        // Console.WriteLine(text[i]);
        if (a == -1)
        {
            a = i;
        }
        else
        {
            int b = i - a + 1;
            Console.WriteLine(text.Substring(a, b));
            a = -1;
        }
    }

}
*/

Console.WriteLine("Дан текст:");
string str = "Жывотные, чюдо, чащя, чаша, щюка, шыло";
Console.WriteLine(str);

// создания массива из текста, чтобы использовать индексацию
char[] b = str.ToCharArray();

// перебор строки str по буквам
for (int i = 0; i < str.Length - 1; i++)
{
    // если первая буква ж, Ж, ш или Ш и после не идёт ы
    if ((str[i] == 'ж' || str[i] == 'Ж' || str[i] == 'ш' || str[i] == 'Ш') && str[i + 1] == 'ы')
    {
        // То заменяем букву ы на и
        b[i + 1] = 'и';
    }

    // если первая буква ч, Ч, щ или Щ и после не идёт я
    else if ((str[i] == 'ч' || str[i] == 'щ' || str[i] == 'Ч' || str[i] == 'Щ') && str[i + 1] == 'я')
    {
        // То заменяем букву я на а
        b[i + 1] = 'а';
    }

    // если первая буква ч, Ч, щ или Щ и после не идёт ю
    else if ((str[i] == 'ч' || str[i] == 'щ' || str[i] == 'Ч' || str[i] == 'Щ') && str[i + 1] == 'ю')
    {
        // То заменяем букву ю на у
        b[i + 1] = 'у';
    }

}

Console.WriteLine("\nИсправленный текст:");
Console.WriteLine(new string(b));

