﻿namespace ApiProjeKampi.WebApi.Dtos.ContactDtos
{
    public class CreateContactDto
    {
        
        public string MapLocation { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string OpenHours { get; set; }
    }
}
}
