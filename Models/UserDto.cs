﻿namespace VolunteeringPlatform.Models
{
    public class UserDto
    {
        public int Id { get; set; }

        public string Username { get; set; } =string.Empty;

        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public int AssociationId { get; set; } 
        public bool isAdmin { get; set; }
    }
}
