using System.ComponentModel.DataAnnotations;

namespace DemoApplication.Models;

public class LoginUserRequest
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}