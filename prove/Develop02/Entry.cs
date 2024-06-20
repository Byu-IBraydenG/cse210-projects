using System;

public class Entry
{
    public string _prompt {get; set;}
    public string _response{get; set;}
    public string _date{get; set;}

    public Entry(string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now.ToString("yyyy-MM-dd");
    }

    public override string ToString()
    {
        return $"{_date} - {_prompt}: {_response}";
    }
}