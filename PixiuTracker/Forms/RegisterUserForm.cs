﻿using System.ComponentModel.DataAnnotations;

namespace PixiuTracker.Forms
{
    public class RegisterUserForm
    {
        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string ApiKey { get; set; }

        [Required]
        public string ApiSecret { get; set; }
    }
}
