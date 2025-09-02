using ModelContextProtocol.Server;
using System.ComponentModel;

[McpServerToolType]
public static class StrawberryTool
{
    [McpServerTool, Description("Echoes the message back to the client.")]
    public static string Echo(string message) => $"Hello from C#: {message}";

    [McpServerTool, Description("Counts the number of times a specified character appears in a string, ignoring case.")]
    public static int CountCharactersInString(char character, string message)
    {
        if (message == null)
            return 0;
        char lowerChar = char.ToLowerInvariant(character);
        return message.Count(c => char.ToLowerInvariant(c) == lowerChar);
    }
}
