using Microsoft.AspNetCore.Identity;

namespace MercadoProdutos.Models
{
    public class UserRole : IdentityUserRole<Guid>
    {
        public User User;
        public Role Role { get; set; }
    }
}
