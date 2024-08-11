using GetAegeanAirlinesLowCostTickets.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;
// Add services to the container.


builder.Services.AddLogging(logging => logging.AddConsole());


// Add Aegean Services Lib
builder.Services.AddAegeanServices();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMvc();


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
