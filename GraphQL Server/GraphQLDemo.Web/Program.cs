using GraphQL.NewtonsoftJson;
using GraphQL.Types;
using GraphQL;
using System.Text.Json;
using Microsoft.AspNetCore.Server.Kestrel.Core;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IDocumentWriter, DocumentWriter>();
builder.Services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
builder.Services.AddTransient<ISchema, GameStoreSchema>();
builder.Services.AddTransient<ItemType>();
builder.Services.AddTransient<GameStoreQuery>();
builder.Services.AddGraphQL(o => o.EndPoint = "/graphql");
builder.Services.Configure<KestrelServerOptions>(o => o.AllowSynchronousIO = true);
var app = builder.Build();


app.MapGet("/", () => "Hello World!");
app.UseGraphQL();
app.Run();
