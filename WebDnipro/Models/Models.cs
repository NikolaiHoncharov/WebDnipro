﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebDnipro.Models
{
    public class LoginModel
        {
            [Required]
            [Display(Name = "Логин")]
            public string Name { get; set; }

            [Required]
            [Display(Name = "Пароль")]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }
}