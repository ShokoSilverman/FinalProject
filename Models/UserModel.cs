using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class UserModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public bool isAdmin { get; set; } = false;

        public UserModel()
        {
            
        }
    }
}