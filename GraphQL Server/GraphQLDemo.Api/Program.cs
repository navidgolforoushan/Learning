using GraphQL;
using GraphQL.AttachedResourceInterfaces;
using GraphQLDemo.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGraphQL(o => o
    .AddSystemTextJson());
builder.Services.AddControllers();
builder.Services.AddSingleton<IDataStore>(new FakeDataStore());
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
app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.UseWebSockets();

app.UseGraphQLGraphiQL();
app.UseGraphQLAltair();
app.UseGraphQLVoyager();

await app.RunAsync();


