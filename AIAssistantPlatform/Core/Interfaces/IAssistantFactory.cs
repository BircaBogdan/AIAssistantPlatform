using AIAssistantPlatform.Core.Interfaces;

namespace AIAssistantPlatform.Core.Interfaces
{
    public interface IAssistantFactory
    {
        IPlugin CreatePlugin();
        IResponseStrategy CreateResponseStrategy();
    }
}
