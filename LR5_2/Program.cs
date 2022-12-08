string text = "Весь сад в дожде! Весь дождь в саду!" +
    " Погибнут дождь и сад друг в друге," +
    " Оставив мне решать судьбу" +
    " Зимы, явившейся на юге.\r\n";

Console.WriteLine(text);

// Выделяем отдельные слова
string[] quote = text.Split(new char[] { '.', '!', ' ', ',', '?' },
    StringSplitOptions.RemoveEmptyEntries);

// Для удаления дублей в наборе используется Distinct
var result = quote.Distinct();

foreach (var s in result)
{
    Console.WriteLine(s);
}
