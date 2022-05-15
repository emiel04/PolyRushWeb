﻿using System.ComponentModel.DataAnnotations;

namespace PolyRushWeb.Models
{
    public class ForgotPasswordModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
