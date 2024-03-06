using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (string value in values)
{
    decimal numericValue;

    if (decimal.TryParse(value, out numericValue))
        total += numericValue;
    else
        message += value;
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");