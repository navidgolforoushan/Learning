using GraphQL.AttachedResourceInterfaces;
using GraphQL.Types;
using GraphQLDemo.Data.Data.Entities;

namespace GraphQLDemo.Api.GraphQLProfile
{
    public class ProfileQuery: ObjectGraphType
    {
        public ProfileQuery(IDataStore dataStore)
        {
            Field<ProfileType>("profile")
            .Resolve(context => dataStore.ProfilesRepository.GetAll().First());
        }
    }
}
