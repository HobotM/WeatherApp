    using System.ComponentModel.DataAnnotations;
    public class RegisterModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

       

    }