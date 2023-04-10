using System.Text.RegularExpressions;

string inputText = "tolstoj_lew_nikolaewich-text_0040.fb2";
string result = "dict.txt";

Dictionary<string, int> dictionary = new Dictionary<string, int>();
Regex regex = new Regex(@"\b[a-zа-яё'-]+\b", RegexOptions.IgnoreCase);

using (StreamReader sr = new StreamReader(inputText))
{
    string line;

    while ((line = sr.ReadLine()) != null)
    {
        line = System.Text.RegularExpressions.Regex.Replace(line, @"<.*?>", "");

        foreach (Match match in regex.Matches(line))
        {
            string word = match.Value.ToLower();

            if (dictionary.ContainsKey(word))
                dictionary[word]++;
            else
                dictionary[word] = 1;
        }
    }
}

using (StreamWriter sw = new StreamWriter(result))
{
    foreach (var item in dictionary.OrderByDescending(k => k.Value))
    {
        sw.WriteLine($"{item.Key}\t{item.Value}");
    }
}