using AIAssistantPlatform.Core.Interfaces;
using AIAssistantPlatform.Plugins;

namespace AIAssistantPlatform.Core.Services
{
    public class WeatherPluginCreator : PluginCreator
    {
        public override IPlugin CreatePlugin()
        {
            return new WeatherPlugin();
        }
    }
}
