using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using WebApplication1.Data.Enum;
using WebApplication1.Models;

namespace WebApplication1.Entity
{
    public class User
    {
        public long Id { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public Role Role { get; set; }

        public Profile Profile { get; set; }


        public string Liked { get; set; }

    }
}
