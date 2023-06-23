using OpenAI_API;
using System.Text;

namespace Centrim_Realms.Data
{
    public class AIResponseService
    {
        public async Task<string> CreateWorld(string worldName)
        {
            StringBuilder ret = new StringBuilder();

            var api = new OpenAIAPI("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");

            var chat = api.Chat.CreateConversation();

            chat.AppendUserInput($"Create a description of a fantasy area named {worldName}. Please only respond with the description.");

            await foreach (var res in chat.StreamResponseEnumerableFromChatbotAsync())
            {
                ret.Append(res);
            }

            return ret.ToString();
        }
    }

}
