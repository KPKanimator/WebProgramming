using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SqlInjection.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

    }

    class UserContext : DbContext
    {
        public UserContext()
            :base ("DefaultConnection")
        {

        }

        public DbSet<User> Users { get; set; }
    }
}