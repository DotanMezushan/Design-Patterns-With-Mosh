using Memento_Pattern;

var editor = new Editor();
var history = new History();

// Update and save state "A"
editor.SetContent("A");
history.Push(editor.CreateState());
Console.WriteLine($"Updated content: {editor.GetContent()}");

// Update and save state "B"
editor.SetContent("B");
history.Push(editor.CreateState());
Console.WriteLine($"Updated content: {editor.GetContent()}");

// Update and save state "C"
editor.SetContent("C");
history.Push(editor.CreateState());
Console.WriteLine($"Updated content: {editor.GetContent()}");

// Update and save state "C"
editor.SetContent("D");
history.Push(editor.CreateState());
Console.WriteLine($"Updated content: {editor.GetContent()}");

// Restore to the previous state (should be "B")
if (history.HasStates)
{
    editor.Restore(history.Pop());
    Console.WriteLine($"Restored 1 content: {editor.GetContent()}");
}

if (history.HasStates)
{
    editor.Restore(history.Pop());
    Console.WriteLine($"Restored 2 content: {editor.GetContent()}");
}

if (history.HasStates)
{
    editor.Restore(history.Pop());
    Console.WriteLine($"Restored 3 content: {editor.GetContent()}");
}

if (history.HasStates)
{
    editor.Restore(history.Pop());
    Console.WriteLine($"Restored 3 content: {editor.GetContent()}");
}

else
{
    Console.WriteLine("No state to restore.");
}

Console.ReadLine();
