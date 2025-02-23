﻿using Microsoft.AspNetCore.Mvc.Rendering;
using SMSProject.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UoN.ExpressiveAnnotations.NetCore.Attributes;

namespace SMSProject.ViewModels
{
    public class UserViewModel
    {
		public string Id { get; set; } = null!;


		public string? FullName { get; set; } = null!;
        public string ?Username { get; set; } = null!;
        public string ?Email { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; }
	

	
		public IList<string> SelectedRoles { get; set; } = new List<string>();

		public IEnumerable<SelectListItem>? Roles { get; set; }
	/*	[MaxLength(100)]*/
        public string? Grade { get; set; } = null!;
        public bool IsDeleted { get; set; } 
        public bool IsEmailConfirmed { get; set; } 
        public DateTime CreatedOn { get; set; }
        public DateTime? LastUpdatedOn { get; set; }
        public string? Parents { get; set; }
/*        public string? ParentsDetails { get; set; }
        public string? ProfilePicture { get; set; }*/
        [Display(Name = "File")]
        [NotMapped] // Mark this property as not mapped to the database
        public IFormFile? File { get; set; }

        public string? FileAttachment { get; set; }

        public string? FilePath { get; set; }
        public string? FileName { get; set; }
        //public string? Password { get; set; }
        public string? PhoneNumber { get; set; } = null!;
        public string? Address { get; set; } = null!;
        public string? Parents1 { get; set; } = null!;
        public string? Parents2 { get; set; } = null!;
    }
}
