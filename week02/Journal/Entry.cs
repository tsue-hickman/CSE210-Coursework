using System;

class Entry
{
    private string _prompt;
    private string _response;
    private string _date;
    private string _mood;

    public Entry(string prompt, string response, string date, string mood)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
        _mood = mood;
    }

    public string Mood { get { return _mood; } }

    public string ToString()
    {
        return $"Date: {_date}\nMood: {_mood}\nPrompt: {_prompt}\nResponse: {_response}\n";
    }

    public string ToFileString()
    {
        return $"{_date}|{_mood}|{_prompt}|{_response}";
    }

    public static Entry FromFileString(string fileLine)
    {
        string[] parts = fileLine.Split('|');
        if (parts.Length == 4)
        {
            return new Entry(parts[2], parts[3], parts[0], parts[1]);
        }
        throw new FormatException("Invalid entry format in file.");
    }
}