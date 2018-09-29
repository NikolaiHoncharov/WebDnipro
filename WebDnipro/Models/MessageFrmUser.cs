using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebDnipro.Models
{
    public class MessageFrmUser
    {
        
        public int MessageFrmUserId { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail не прошел валидация")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Display(Name = "Skype")]
        public string Skype { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [Display(Name = "Номер телефона")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [Display(Name = "Сообщение")]
        public string Message { get; set; }

    }
}