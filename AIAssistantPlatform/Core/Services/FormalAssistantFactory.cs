using AIAssistantPlatform.Core.Interfaces;
using AIAssistantPlatform.Plugins;

namespace AIAssistantPlatform.Core.Services
{
    public class FormalAssistantFactory : IAssistantFactory
    {
        public IPlugin CreatePlugin()
        {
            return new MathPlugin();
        }

        public IResponseStrategy CreateResponseStrategy()
        {
            return new FormalResponseStrategy();
        }
    }
}
