using CurrencyExchangeServiceAPI.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// ÀRºA¶×²v
var exchangeRate = new Dictionary<string, Dictionary<string, decimal>>
{
    {"TWD", new Dictionary<string, decimal> {{"TWD", 1}, {"JPY", 3.669M}, {"USD", 0.03281M}}},
    {"JPY", new Dictionary<string, decimal> {{"TWD", 0.26956M}, {"JPY", 1}, {"USD", 0.00885M}}},
    {"USD", new Dictionary<string, decimal> {{"TWD", 30.444M}, {"JPY", 111.801M}, {"USD", 1}}}
};
var currencyExchangeService = new CurrencyExchangeService(exchangeRate);

// µù¥U CurrencyExchangeService
builder.Services.AddSingleton(currencyExchangeService);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
