var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<ISnoopyService, SnoopyService>();

var app = builder.Build();
var counter = 0;

app.MapGet("/{val}", (int val) =>
{
    counter += val;
    return counter;
});

app.Run();
