using GraphQLDemo.Data.Data.Entities;

namespace GraphQLDemo.Data.Data
{
    public class InitialData
    {
        public InitialData()
        {
            Profiles = new List<Profile> { 
            new Profile(Guid.Parse("e467a907-ce5b-4997-9257-add590913ae5"),"Navid","Golforoushan","I'm new here!",new Address(),new Address()),
            new Profile(Guid.Parse("e9bdbcd4-c6e6-4eda-aed9-b9c79e844182"),"Nima","Golforoushan","I'm electical eng!",new Address(),new Address()),
            new Profile(Guid.Parse("e9bdbcd4-c6e6-4eda-aed9-b9c79e844181"),"Robert Cecil","Martin","Hi I'm uncle bob!",new Address(),new Address()),
            };
        }

        public List<Profile> Profiles { get; }
    }
}
