using System;
using LinqToDB.Mapping;
using LocalPin.Shared.Models;

namespace LocalPin.Backend.Models
{
    
    [Table(Name="pin_types")]
    [Column("id", nameof(Id))]
    [Column("name", nameof(Name))]
    [Column("icon", nameof(Icon))]
    [Column("color", nameof(Color))]
    public record DbPinType : PinType
    {
    }
}