using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelperMethods.Models
{
    [DisplayName("новый юзер")]
    public partial class UserMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public int UserId { get; set; }

        [DisplayName("Имя")]
        public string FirstName { get; set; }

        [DisplayName("Фамилия")]
        public string LastName { get; set; }

        [DisplayName("Дата рождения")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [DisplayName("Адрес")]
        public Address HomeAddress { get; set; }

        [DisplayName("Подтвердил регистрацию?")]
        public bool IsApproved { get; set; }

        [UIHint("Enum")]
        [DisplayName("Роль")]
        public Role Role { get; set; }
    }
}