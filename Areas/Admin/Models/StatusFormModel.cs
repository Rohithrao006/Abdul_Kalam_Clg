using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Areas.Admin.Models
{
    public class Status
    {
        [Key]
        public int Id{get;set;}
        public string status{get;set;}
    }
}
