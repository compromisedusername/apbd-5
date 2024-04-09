namespace SimpleApi.Endpoints;

public static class AnimalMappings
{
    public static void MapAnimalEndpoints(this WebApplication app)
    {
        app.MapGet("/animals-minimalApi", () =>
        {
            return Results.Ok();
        });
    }
}