﻿namespace Entities
{
    public class User:ObjetoBase
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Photo { get; set; }
    }
}
