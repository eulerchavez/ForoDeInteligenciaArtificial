﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ForoIA.Models {

    public class ExternalLoginConfirmationViewModel {

        [Required]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }

    }

    public class ExternalLoginListViewModel {

        public string ReturnUrl { get; set; }

    }

    public class SendCodeViewModel {

        public string SelectedProvider { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }

        public string ReturnUrl { get; set; }

        public bool RememberMe { get; set; }

    }

    public class VerifyCodeViewModel {

        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Código")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "¿Recordar este explorador?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }

    }

    public class ForgotViewModel {

        [Required]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }

    }

    public class LoginViewModel {

        [Required]
        [Display(Name = "Usario")]
        [StringLength(25)]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Display(Name = "¿Recordar cuenta?")]
        public bool RememberMe { get; set; }

    }

    public class RegisterViewModel {

        [Required]
        [StringLength(25)]
        [Display(Name = "Nombre de usuario")]
        [System.Web.Mvc.Remote("CheckExistingUser", "Account", HttpMethod = "POST", ErrorMessage = "Usuario no disponible.")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Correo electrónico")]
        [System.Web.Mvc.Remote("CheckAvailableEmail", "Account", HttpMethod = "POST", ErrorMessage = "Correo electronico ya registrado.")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar contraseña")]
        [Compare("Password", ErrorMessage = "La contraseña y la contraseña de confirmación no coinciden.")]
        public string ConfirmPassword { get; set; }

    }

    public class ResetPasswordViewModel {

        [Required]
        [EmailAddress]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar contraseña")]
        [Compare("Password", ErrorMessage = "La contraseña y la contraseña de confirmación no coinciden.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }

    }

    public class ForgotPasswordViewModel {

        [Required]
        [EmailAddress]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }

    }

}
