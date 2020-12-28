using System.ComponentModel.DataAnnotations;

namespace QuizApp.Domain.Auth
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
