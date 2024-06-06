using System;

interface IPublication
{
    void DisplayInfo();
    bool IsAuthor(string authorLastName);
}

class Book : IPublication
{
    public string Title { get; set; }
    public string AuthorLastName { get; set; }
    public int Year { get; set; }
    public string Publisher { get; set; }

    public Book(string title, string authorLastName, int year, string publisher)
    {
        Title = title;
        AuthorLastName = authorLastName;
        Year = year;
        Publisher = publisher;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Book Title: {Title}");
        Console.WriteLine($"Author Last Name: {AuthorLastName}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Publisher: {Publisher}");
    }

    public bool IsAuthor(string authorLastName)
    {
        return AuthorLastName.Equals(authorLastName, StringComparison.OrdinalIgnoreCase);
    }
}

class Article : IPublication
{
    public string Title { get; set; }
    public string AuthorLastName { get; set; }
    public string JournalName { get; set; }
    public int IssueNumber { get; set; }
    public int Year { get; set; }

    public Article(string title, string authorLastName, string journalName, int issueNumber, int year)
    {
        Title = title;
        AuthorLastName = authorLastName;
        JournalName = journalName;
        IssueNumber = issueNumber;
        Year = year;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Article Title: {Title}");
        Console.WriteLine($"Author Last Name: {AuthorLastName}");
        Console.WriteLine($"Journal Name: {JournalName}");
        Console.WriteLine($"Issue Number: {IssueNumber}");
        Console.WriteLine($"Year: {Year}");
    }

    public bool IsAuthor(string authorLastName)
    {
        return AuthorLastName.Equals(authorLastName, StringComparison.OrdinalIgnoreCase);
    }
}

class ElectronicResource : IPublication
{
    public string Title { get; set; }
    public string AuthorLastName { get; set; }
    public string URL { get; set; }
    public string Annotation { get; set; }

    public ElectronicResource(string title, string authorLastName, string url, string annotation)
    {
        Title = title;
        AuthorLastName = authorLastName;
        URL = url;
        Annotation = annotation;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Electronic Resource Title: {Title}");
        Console.WriteLine($"Author Last Name: {AuthorLastName}");
        Console.WriteLine($"URL: {URL}");
        Console.WriteLine($"Annotation: {Annotation}");
    }

    public bool IsAuthor(string authorLastName)
    {
        return AuthorLastName.Equals(authorLastName, StringComparison.OrdinalIgnoreCase);
    }
}
