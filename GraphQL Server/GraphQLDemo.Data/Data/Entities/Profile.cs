
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace GraphQLDemo.Data.Data.Entities
{
    /// <summary>
    /// Profile record type
    /// </summary>
    /// <param name="FirstName">First Name</param>
    /// <param name="LastName">Last Name</param>
    /// <remarks>
    /// Client profile information
    /// </remarks>
    [DebuggerDisplay("Name={FirstName},{LastName}")]
    public readonly record struct Profile(
        Guid Id,
        [property: JsonPropertyName("firstName")][StringLength(100)] string FirstName,
        [property: JsonPropertyName("lastName")][StringLength(150)] string LastName,
        [property: JsonPropertyName("bio")] string Biography,
        [property: JsonPropertyName("home")] Address HomeAddress,
        [property: JsonPropertyName("location")] Address CurrentAddress);
}
