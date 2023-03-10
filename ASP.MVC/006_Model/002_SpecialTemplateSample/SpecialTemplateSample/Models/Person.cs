using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpecialTemplateSample.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        
        public Role Role { get; set; }
    }

    public enum Role
    {
        Guest, User, Admin
    }
}