using YounathanAMiniChallengeFiveToSeven_Endpoints.services.MadLib;
using YounathanAMiniChallengeFiveToSeven_Endpoints.services.OddEven;
using YounathanAMiniChallengeFiveToSeven_Endpoints.services.ReverseNum;
using YounathanAMiniChallengeFiveToSeven_Endpoints.services.ReverseWord;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMadLibServices, MadLibServices>();
builder.Services.AddScoped<IOddEvenService, OddEvenService>();
builder.Services.AddScoped<IReverseWordService, ReverseWordService>();
builder.Services.AddScoped<IReverseNumService, ReverseNumService>();

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
