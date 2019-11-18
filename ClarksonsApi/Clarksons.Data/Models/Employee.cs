using System;
using System.ComponentModel.DataAnnotations;

namespace Clarksons.Search.Service.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string  Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime HireDate { get; set; }
    }
}
