using AIAssistantPlatform.Core.Interfaces;

namespace AIAssistantPlatform.Plugins
{
    public class WeatherPlugin : IPlugin
    {
        public string Name => "Weather";

        public string Process(string input)
        {
            return "Weather info: Sunny 25°C";
        }
    }
}
