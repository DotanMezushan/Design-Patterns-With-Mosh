using Memento_Exercises;
{
    Document document = new Document();
    History history = new History();

    document.SetContent("A");
    document.SetFontName("AA");
    document.SetFontSize(1.1f);

    history.Push(document.CreateState());

    Console.WriteLine(document.ToString());

    document.SetContent("B");
    document.SetFontName("BB");
    document.SetFontSize(2.2f);

    history.Push(document.CreateState());

    Console.WriteLine(document.ToString());

    document.SetContent("C");
    document.SetFontName("CC");
    document.SetFontSize(3.3f);

    history.Push(document.CreateState());

    Console.WriteLine(document.ToString());

    document.SetContent("E");

    history.Push(document.CreateState());

    Console.WriteLine(document.ToString());

    if (history.HasStates)
    {
        document.Restore(history.Pop());
        Console.WriteLine(document.ToString());
    }

    if (history.HasStates)
    {
        document.Restore(history.Pop());
        Console.WriteLine(document.ToString());
    }
    if (history.HasStates)
    {
        document.Restore(history.Pop());
        Console.WriteLine(document.ToString());
    }

}
