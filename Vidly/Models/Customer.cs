using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Mapping;

namespace Vidly.Models
{
    public class Customer
    {
        [Required] public int Id { get; set; }
        [Required, MaxLength(250)] public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }
        public MemberShipType MemberShipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}