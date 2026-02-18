using AIAssistantPlatform.Core.Interfaces;

namespace AIAssistantPlatform.Core.Services
{
    public abstract class PluginCreator
    {
        public abstract IPlugin CreatePlugin();
    }
}
