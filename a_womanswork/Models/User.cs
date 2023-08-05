using System;
namespace a_womanswork.Models
{
    public class User
    {
        public User()
        {
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        // Other properties like Name, Password, ProfilePictureUrl, etc., depending on your requirements.
    }
}
