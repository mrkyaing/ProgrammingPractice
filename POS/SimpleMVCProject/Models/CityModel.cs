using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace SimpleMVCProject.Models
{
    public class CityModel
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}