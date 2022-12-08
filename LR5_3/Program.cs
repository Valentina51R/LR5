using System.Text.RegularExpressions;

// Создание исходного текста
string text = "Иванов И.И. - 175 см - 70 кг, Петров П.П. - 190 см -" +
    " 110 кг, Сидоров С.С. - 186 см - 120 кг, " +
    "Свечкин В.В. - 170 кг - 100,9 кг.";

// Выделяем строки по каждому человеку
Regex regex = new Regex(@"\w* \S+ - \d+ \w+ - \S+ \w+\S");

// Применение регулярки к text
MatchCollection matches = regex.Matches(text);

foreach (Match i in matches)
{

    // Вывод ФИО
    Console.WriteLine(i);

}

// Резделение ФИО - рост - вес
Regex regex1 = new Regex(@" [-] ");

Console.WriteLine("\nФИО людей, у которых вес более 100 кг: ");

// Перебор по строке(человеку)
foreach (Match i in matches)
{
    // Применение разделения по "-" к каждой строке
    string[] matches2 = regex1.Split(i.ToString());

    // Создание регулярки для разделения числа от букв в "175 см"
    Regex regex2 = new Regex(@" ");

    // Применение regex2 к весу т.е. выделение разделение числа и букв
    string[] weight = regex2.Split(matches2[2].ToString());

    // Сравнение веса с 100
    if (Convert.ToSingle(weight[0]) > 100)
    {
        // Вывод ФИО
        Console.WriteLine(matches2[0] + $"- вес {weight[0]}");
    }
}
