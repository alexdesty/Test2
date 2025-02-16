using System.Text;
namespace Test2task2.Extensions;
internal static class IntExtension
{
    public static string IntToStr(this int num)
    {
        var numberDictionary = new Dictionary<char, string>()
        {
            ['-'] = "минус ",
            ['0'] = "ноль ",
            ['1'] = "один ",
            ['2'] = "два ",
            ['3'] = "три ",
            ['4'] = "четыре ",
            ['5'] = "пять ",
            ['6'] = "шесть ",
            ['7'] = "семь ",
            ['8'] = "восемь ",
            ['9'] = "девять ",
        };
        StringBuilder result = new StringBuilder();
        var strNum = num.ToString();
        for (var i = 0; i < strNum.Length; i++)
        {
            result.Append(numberDictionary[strNum[i]]);
        }
        result.Remove(result.Length - 1, 1);
        return result.ToString();
    }
}

