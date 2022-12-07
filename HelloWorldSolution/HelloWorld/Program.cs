using HelloWorld;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<DateUtils>();

var app = builder.Build();

app.MapGet("/break/{minutes:int}", (int minutes, DateUtils helper) =>
{
    var res = new BreakTimerResponse(
        minutes,
        DateTime.Now,
        helper.TakeABreak(minutes)
        );

    return Results.Ok(res);

});

app.Run();

Console.WriteLine("Running");

public record BreakTimerResponse(int minutes, DateTime startTime, DateTime endTime);