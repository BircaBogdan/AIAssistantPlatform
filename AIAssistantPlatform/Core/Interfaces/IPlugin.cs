namespace AIAssistantPlatform.Core.Interfaces;

public interface IPlugin
{
    string Name { get; }
    string Process(string input);
}
