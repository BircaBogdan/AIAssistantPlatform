using AIAssistantPlatform.Core.Interfaces;

namespace AIAssistantPlatform.Core.Services
{
    public class FriendlyResponseStrategy : IResponseStrategy
    {
        public string GenerateResponse(string input)
        {
            return "😊 Friendly: " + input;
        }
    }
}
