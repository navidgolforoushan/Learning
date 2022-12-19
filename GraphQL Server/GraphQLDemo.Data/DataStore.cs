using GraphQL.AttachedResourceInterfaces;
using GraphQLDemo.Data.Data;
using GraphQLDemo.Data.Repositories;

namespace GraphQLDemo.Data
{
    public class FakeDataStore : IDataStore
    {
        ProfileRepository IDataStore.ProfilesRepository => new ProfileRepository(new InitialData());
    }
}
