using GenrativeAIWithDotnetCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace GenrativeAIWithDotnetCore.Endpoints
{
    public static class PromptEndpoint
    {
        public static IEndpointRouteBuilder MapPromptEndpoint(this IEndpointRouteBuilder app)
        {
            var quizGroup = app.MapGroup("/api/prompt");

            quizGroup.MapPost("", async (IGenerativeAiService quizService,[FromBody] string prompt) =>
            {
                if (string.IsNullOrWhiteSpace(prompt))
                {
                    return Results.BadRequest("Please enter prompt");
                }
                
                return Results.Ok(await quizService.GenerateTextAsync(prompt));
            });


            return app;
        }
    }
}
