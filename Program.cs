using System.Text.RegularExpressions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
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

app.MapGet("/cardflag/{cardNumber}", (string cardNumber) =>
{
    var cardFlags = new Dictionary<string, string>
    {
        { "Visa", "^4[0-9]{12}(?:[0-9]{3})?$|^4[0-9]{15}$" },
        { "Mastercard", "^5[1-5][0-9]{14}$" },
        { "American Express", "^3[47][0-9]{13}$" },
        { "Diners Club", "^3(?:0[0-5]|[68][0-9])[0-9]{11}$" },
        { "Discover", "^6(?:011|5[0-9]{2})[0-9]{12}$" },
        { "EnRoute", "^(2014|2149)[0-9]{11}$" },
        { "JCB", "^(?:2131|1800|35\\d{3})\\d{11}$" },
        { "Voyage", "^8699[0-9]{11}$" },
        { "Hipercard", "^(606282|3841)[0-9]{10,17}$" },
        { "Aura", "^50[0-9]{14,17}$" }
    };

    foreach (var cardFlag in cardFlags)
    {
        if (Regex.IsMatch(cardNumber, cardFlag.Value))
        {
            return Results.Json(new { flag = cardFlag.Key });
        }
    }
    return Results.Json(new { flag = "Unidentified" });
});

app.Run();
