using GraphQL.Types;
using GraphQLDemo.Data.Data.Entities;

namespace GraphQLDemo.Api.GraphQLProfile
{
    public class ProfileType: ObjectGraphType<Profile>
    {
        public ProfileType()
        {
            Name = "Profile";
            Description = "Profile Type";
            Field(d => d.Id, nullable: false).Description("Priofile Id");
            Field(d => d.FirstName, nullable: false).Description("Profile owner first name");
            Field(d => d.LastName, nullable: false).Description("Profile owner last name");
            Field(d => d.HomeAddress, nullable: false).Description("Profile owner home address");
            Field(d => d.CurrentAddress, nullable: false).Description("Profile owner current location will estimated by phone gps or network IP");
        }
    }
}
