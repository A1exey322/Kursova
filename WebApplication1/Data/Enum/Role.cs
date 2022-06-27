using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Data.Enum
{
    public enum Role
    {
        [Display(Name = "User")]
        User = 0,
        [Display(Name = "Moderator")]
        Moderator = 1,
        [Display(Name = "Admin")]
        Admin = 2,
    }
}
