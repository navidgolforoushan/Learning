using GraphQL.Types;
using System.Xml.Linq;

public class ItemInputType : InputObjectGraphType
{
    public ItemInputType()
    {
        Name = "ItemInput";
        Field<NonNullGraphType<StringGraphType>>("tag");
        Field<NonNullGraphType<StringGraphType>>("title");
        Field<NonNullGraphType<DecimalGraphType>>("price");
    }
}