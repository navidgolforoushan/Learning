using System.ComponentModel.DataAnnotations;

namespace GraphQLDemo.Data.Data.Entities
{
    public readonly record struct Message(int Id,[Required]string Body);
}
