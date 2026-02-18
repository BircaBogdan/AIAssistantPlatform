using AIAssistantPlatform.Core.Interfaces;
using AIAssistantPlatform.Plugins;

namespace AIAssistantPlatform.Core.Services
{
    public class MathPluginCreator : PluginCreator
    {
        public override IPlugin CreatePlugin()
        {
            return new MathPlugin();
        }
    }
}
