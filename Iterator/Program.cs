using Iterator;

BrowserHistory history = new BrowserHistory();

history.AddUrl("https://www.example.com");
history.AddUrl("https://www.google.com");
history.AddUrl("https://www.github.com");

IIterator<string> iterator = history.CreateIterator();

while (iterator.MoveNext())
{
    Console.WriteLine(iterator.Current);
}