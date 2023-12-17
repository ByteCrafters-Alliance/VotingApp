using VotingApp;
using VotingApp.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSignalR();

builder.Services.AddCors(options =>
{
    options.AddPolicy("ReactAppPolicy",
        builder => builder
            .AllowAnyMethod()
            .AllowAnyHeader()
            .WithOrigins("http://localhost:3000")  // Update with your React.js app URL
            .AllowCredentials());
});

builder.Services.AddPersistence(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// 
app.UseHttpsRedirection();

app.UseRouting();
app.UseAuthorization();

app.UseCors("ReactAppPolicy");

app.UseEndpoints(endpoint => 
{
    endpoint.MapHub<VoteHub>("/vote-hub");

    endpoint.MapControllers();
});


app.Run();
