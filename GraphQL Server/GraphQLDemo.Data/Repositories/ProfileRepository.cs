using GraphQLDemo.Data.Data;
using GraphQLDemo.Data.Data.Entities;

namespace GraphQLDemo.Data.Repositories
{
    public class ProfileRepository
    {
        private readonly InitialData dataStore;

        public ProfileRepository(InitialData dataStore)
        {
            this.dataStore = dataStore;
        }

        public IEnumerable<Profile> GetAll()
        {
            return dataStore.Profiles;
        }

        public Profile GetById(Guid id)
        {
            return dataStore.Profiles.FirstOrDefault(x => x.Id.Equals(id));
        }
    }
}
