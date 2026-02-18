using AIAssistantPlatform.Core.Interfaces;
using AIAssistantPlatform.Plugins;

namespace AIAssistantPlatform.Core.Services
{
    public class FriendlyAssistantFactory : IAssistantFactory
    {
        public IPlugin CreatePlugin()
        {
            return new WeatherPlugin();
        }

        public IResponseStrategy CreateResponseStrategy()
        {
            return new FriendlyResponseStrategy();
        }
    }
}
