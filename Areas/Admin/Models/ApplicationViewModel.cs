using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace WebApplication.Areas.Admin.Models
{
    public class ApplicationViewModel
    {
        [Required]
        [StringLength(30)]
        public string StudentName { get; set; }

        [Required]
        [StringLength(30)]
        public string FatherName { get; set; }

        [Required]
        [StringLength(30)]
        public string MotherName { get; set; }

        [Required]
        [StringLength(16)]
        public string AadharNo { get; set; }

        [Required]
        public string SchoolEducation { get; set; }

        [Required]
        public int HallTicketNo { get; set; }

        [Required]
        public double GradePoint { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        public string SchoolName { get; set; }

        [Required]
        public string SchoolAddress { get; set; }

        [Required]
        public string CoursePreferred { get; set; }

        [Required]
        public string Medium { get; set; }

        [Required]
        public string Language { get; set; }

        [Required]
        public string Religion { get; set; }

        [Required]
        public string Caste { get; set; }


        [Required]
        public string SubCaste { get; set; }

        [Required]
        public string MotherTongue { get; set; }

        [Required]
        public int TotalFee { get; set; }

        public int BalanceFee { get; set; }

        [Required]
        public string ParentOccupation { get; set; }

        [Required]
        public string StudentAddress { get; set; }

        [Required]
        public string ContactNo { get; set; }

        [Required]
        public string IdentificationMarks { get; set; }

        [Required]
        public DateTime DateOfAdmission { get; set; }


        public IFormFile StudentPhoto { get; set; }
        public IFormFile StudentSign { get; set; }
        public IFormFile ParentSign { get; set; }
    }
}