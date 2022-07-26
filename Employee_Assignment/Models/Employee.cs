using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employee_Assignment.Models
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string? FirstName { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string? LastName { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string? Mobile { get; set; }
        [Required]
        [Column(TypeName = "varchar(40)")]
        public string? Email { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string? Address_1 { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string? Address_2 { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string? City { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int Postal { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string? Country { get; set; }
    }
}
