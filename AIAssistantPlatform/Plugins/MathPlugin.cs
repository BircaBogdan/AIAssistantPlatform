using AIAssistantPlatform.Core.Interfaces;

namespace AIAssistantPlatform.Plugins
{
    public class MathPlugin : IPlugin
    {
        public string Name => "Math";

        public string Process(string input)
        {
            return "Math result: 42";
        }
    }
}
