using Microsoft.AspNetCore.Identity;

namespace MercadoProdutos.Models
{
    public class Role : IdentityRole<Guid>
    {
        public List<UserRole> UserRoles { get; set; }
    }
}
