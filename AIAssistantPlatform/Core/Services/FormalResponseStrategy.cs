using AIAssistantPlatform.Core.Interfaces;

namespace AIAssistantPlatform.Core.Services
{
    public class FormalResponseStrategy : IResponseStrategy
    {
        public string GenerateResponse(string input)
        {
            return "Formal response: " + input;
        }
    }
}
