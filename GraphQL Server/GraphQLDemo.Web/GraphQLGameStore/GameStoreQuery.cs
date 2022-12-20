using GraphQL;
using GraphQL.Types;

public class GameStoreQuery : ObjectGraphType
{
    public GameStoreQuery()
    {
        Field<StringGraphType>(
            name: "name",
            resolve: context => "Steam"
        );

        Field<ItemType>(
        "item",
        arguments: new QueryArguments(new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "tag" }),
        resolve: context =>
        {
            var tag = context.GetArgument<string>("tag");
            return new DataSource().GetItemByTag(tag);
        }
    );
    }
}