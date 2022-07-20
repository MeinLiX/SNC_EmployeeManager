using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace SNC_WCFService.Models
{
    [DataContract]
    public class EmployeeModel
    {
        [DataMember]
        [Key]
        public Guid ID { get; set; }

        [DataMember]
        [Required]
        public string FirstName { get; set; }

        [DataMember]
        [Required]
        public string LastName { get; set; }

        [DataMember]
        [Required]
        public string Patronymic { get; set; }

        [DataMember]
        [Required]
        public int DRFO { get; set; } //external key?

        [DataMember]
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [DataMember]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [DataMember]
        [Required]
        public DateTime CreateDate { get; set; } = DateTime.Now;

        [DataMember]
        [Required]
        public DateTime UpdateDate { get; set; } = DateTime.Now;

        public string GetFullName() => $"{FirstName} {LastName} {Patronymic}";
    }
}