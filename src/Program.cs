public static class Globals
{
    public static string _currentFileLocation = "foo";
    public static bool _running = true;
    public static Format _format = new Format();
    public static Config _config = new Config();
    public static InputHandler _inputHandler = new InputHandler();
    public static Commands _commands = new Commands();
    public static Stack<Tuple<int, List<string>>> _normalUndoStack = new Stack<Tuple<int, List<string>>>();
    public static List<string> _buffer = new List<string>();
    public static List<string> _booklist = new List<string>();
    public static int[] _originalBooklistIndex = new int[_booklist.Count];
}

public class Program
{
    static void Main(string[] args)
    {
        Globals._commands.ReloadConfig();
        Globals._commands.ReloadBooklist(Globals._config.DefaultBooklistLocation);
        Globals._commands.LoadSystemMessage();
        do
        {
            string input = Console.ReadLine();
            Globals._inputHandler.HandleInput(input);
        } while (Globals._running);
    }
}