using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Default model should be DallE!!
app.MapGet("/generate", (ImageSize size, string prompt, Model model) =>
{
    return CreateImage(prompt, model);
})
.WithName("CreateImage")
.WithOpenApi();


app.MapPost("/history", (int id1, int id2, int id3) =>
{
    return GetImagesUrls(id1, id2, id3);
})
.WithName("GetImages")
.WithOpenApi();


app.Run();

string CreateImage(string prompt, Model model)
{
    return $"https://image.jpg/{prompt}/{model}";
}

string GetImagesUrls(params int[] ids)
{
    var builder = new StringBuilder();
    foreach (var id in ids)
    {
        builder.AppendLine($"https://image.jpg/{id}");
    }
    return builder.ToString();
}

public enum ImageSize
{
    Small,
    Medium,
    Large
}

public enum Model
{
    DallE,
    Midjourney,
    PikaLabs
}