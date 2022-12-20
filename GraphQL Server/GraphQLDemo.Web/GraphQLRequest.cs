

using GraphQL.SystemTextJson;
using System.Text.Json.Serialization;

public class GraphQLRequest
{
    public string Query { get; set; }

    [JsonConverter(typeof(ObjectDictionaryConverter))]
    public Dictionary<string, object> Variables
    {
        get; set;
    }
}