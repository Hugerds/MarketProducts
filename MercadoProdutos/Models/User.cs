using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace MercadoProdutos.Models
{
    public class User :  IdentityUser <Guid>
    {
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool Excluded { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Document { get; set; }
        public UserType UserType { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
    public enum UserType
    {
        [Description("Mercado")]
        Market = 0,
        [Description("Usuário Padrão")]
        User = 1,
    }
}
