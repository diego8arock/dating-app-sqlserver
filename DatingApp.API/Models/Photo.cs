using System;

namespace DatingApp.API.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }
        //By referencian User and UserId the EF can now have a strong association with User Table (i.e. not nullable and delete cascade)
        public User User { get; set; }
        public int UserId { get; set; }
    }
}