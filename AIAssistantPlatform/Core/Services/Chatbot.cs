using AIAssistantPlatform.Core.Interfaces;

namespace AIAssistantPlatform.Core.Services;

public class Chatbot
{
    private readonly IEnumerable<IPlugin> _plugins;

    public Chatbot(IEnumerable<IPlugin> plugins)
    {
        _plugins = plugins;
    }

    public string HandleMessage(string input)
    {
        foreach (var plugin in _plugins)
        {
            input = plugin.Process(input);
        }

        return input;
    }
}
