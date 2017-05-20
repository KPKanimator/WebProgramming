using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using ModelValidation.Models;

namespace ModelValidation.Infrastructure
{
    public class NoVasyaOnMondayAttribute : ValidationAttribute
    {
        public NoVasyaOnMondayAttribute()
        {
            ErrorMessage = "Васи в понедельник отдыхают!";
        }

        public override bool IsValid(object value)
        {
            Appointment app = value as Appointment;
            if (app == null || string.IsNullOrEmpty(app.ClientName) ||
                    app.Date == null)
            {
                // Отсутствует модель правильного типа для проверки или
                // нет значений для обязательных свойств ClientName и Date
                return true;
            }
            else
            {
                return !(app.ClientName == "Вася" && app.Date.DayOfWeek == DayOfWeek.Monday);
            }
        }
    }
}