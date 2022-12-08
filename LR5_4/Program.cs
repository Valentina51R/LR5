using System.Text.RegularExpressions;

string text = "машина, очки, телефон, трубка." +
    " Черепаха Тартила сидела на берегу пруда." +
    "Три сороки - тараторки тараторили на горке.";

// регулярка для выявления слов начинающихся на "т"
// Regex regex = new Regex(@"[т,Т]\w+");
Regex regex = new Regex(@"[т]\w+", RegexOptions.IgnoreCase);

// Применение регулярки к text
MatchCollection words = regex.Matches(text);

// Вывод совпадений
foreach (var i in words)
{
    Console.WriteLine(i);
}
