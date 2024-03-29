﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufos.WebApi.ViewModels
{
    public class LoginViewModel
    {
        //Data annotations
        [Required]
        public string Email { get; set; }
        //definir tamanho do campo
        [StringLength(250, MinimumLength = 5)]
        public string Senha { get; set; }
    }
}
