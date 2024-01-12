using System.Net.Mime;
using System.Text.Json;
using SQL_practice.ViewModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var filename = "textObjects.json";

app.MapGet("/textobjects", async () =>
{
    if (File.Exists(filename))
    {
        var json = await File.ReadAllTextAsync(filename);
        var textObjects = JsonSerializer.Deserialize<TextObject[]>(json);
        return textObjects;
    }
    //var files = Directory.GetFiles(".", "*.json");
    //var textObject = new List<TextObject>();
    //foreach (var file in files)
    //{
    //    var json = await File.ReadAllTextAsync(filename);
    //    var textObjects = JsonSerializer.Deserialize<TextObject[]>(json);
    //    return textObjects;

    //}
    return new TextObject[0];

});
app.MapPost("/textobjects", async (TextObject textObject) =>
{
    var json = File.Exists(filename) ? await File.ReadAllTextAsync(filename) : "[]";
    var textObjects = JsonSerializer.Deserialize<TextObject[]>(json).ToList();
    textObjects.Add(textObject);
    json = JsonSerializer.Serialize(textObjects);
    await File.WriteAllTextAsync(filename, json);
    return textObjects;
    //

});

app.UseStaticFiles();
app.Run();


