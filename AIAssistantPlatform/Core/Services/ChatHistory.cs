using AIAssistantPlatform.Core.Models;

namespace AIAssistantPlatform.Core.Services;

public class ChatHistory
{
    private readonly List<Message> _messages = new();

    public void Add(Message message)
    {
        _messages.Add(message);
    }

    public IEnumerable<Message> GetAll()
    {
        return _messages;
    }
}
