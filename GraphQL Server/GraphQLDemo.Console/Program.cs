using System;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using GraphQL.NewtonsoftJson;

namespace Hello.GraphQL
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var schema = new Schema { Query=new HelloWorldQuery() };

            var json = await schema.ExecuteAsync(_ =>
            {
                _.Query = "{ hello , howdy}";
            });

            Console.WriteLine(json);
        }
    }
}