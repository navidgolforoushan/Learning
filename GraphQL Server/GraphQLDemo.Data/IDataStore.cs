using GraphQLDemo.Data.Data.Entities;
using GraphQLDemo.Data.Repositories;

namespace GraphQL.AttachedResourceInterfaces
{
    public interface IDataStore
    {
        public ProfileRepository ProfilesRepository { get;}
    }
}
