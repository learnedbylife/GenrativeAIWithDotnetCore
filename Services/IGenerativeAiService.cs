using static GenrativeAIWithDotnetCore.Services.GenerativeAiService;

namespace GenrativeAIWithDotnetCore.Services
{
    public interface IGenerativeAiService
    {
        Task<string> GenerateTextAsync(string prompt);
    }
}