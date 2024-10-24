using OpenAI;
using OpenAI.Chat;

namespace GenrativeAIWithDotnetCore.Services
{
    public class GenerativeAiService: IGenerativeAiService
    {
        private readonly IConfiguration _configuration;

        public GenerativeAiService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<string> GenerateTextAsync(string prompt)
        {
            ChatClient client = new(model: "gpt-3.5-turbo", apiKey: _configuration.GetValue<string>("OpenAI:ApiKey"));

            ChatCompletion completion = await client.CompleteChatAsync(prompt);

            return completion.Content[0].Text;
    }
    }

}
