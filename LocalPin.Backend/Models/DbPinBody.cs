using System;
using LinqToDB.Mapping;
using LocalPin.Shared.Models;

namespace LocalPin.Backend.Models
{
    [Table(Name = "pin_bodies")]
    [Column("id", nameof(Id))]
    [Column("image", nameof(Image))]
    [Column("description", nameof(Description))]
    public record DbPinBody : PinBody
    {
    }
}