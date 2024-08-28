using Template_Method_Exercises_windows;

class Program
{
    static void Main()
    {
        Window saveWindow = new SaveWindow();
        saveWindow.Close();

        Console.WriteLine();

        Window dialogWindow = new DialogWindow();
        dialogWindow.Close();
    }
}
