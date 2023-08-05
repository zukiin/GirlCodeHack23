using System;
using System.ComponentModel.DataAnnotations;

namespace a_womanswork.Models
{
    public class Post
    {
        public Post()
        {
        }

        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        // Other properties like UserId, MediaUrl, etc., depending on your requirements.
    }
}
