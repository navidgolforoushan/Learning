using GraphQL.Types;

public class GameStoreSchema : Schema
{
    public GameStoreSchema(IServiceProvider serviceProvider) : base(serviceProvider)
    {
        Query = serviceProvider.GetRequiredService<GameStoreQuery>();
       
    }
}