﻿namespace CLIMATE_REST_API.Models
{
    public class UserFilter
    {
        public string? Role 
        { get; set; }

        public string? UserEmail 
        { get; set; }

        public DateTime? CreatedFrom 
        { get; set; }

        public DateTime? CreatedTo 
        { get; set; }
    }
}
