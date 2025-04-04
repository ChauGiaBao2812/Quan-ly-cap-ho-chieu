using System;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Form
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Gender { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Birthdate { get; set; }

        public string Birthplace { get; set; }

        [Required]
        public string CCCD { get; set; }

        [DataType(DataType.Date)]
        public DateTime? CCCD_Date { get; set; }

        public string CCCD_Place { get; set; }

        public string CCCD_Ethnicity { get; set; }

        public string Religion { get; set; }

        [Phone]
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Province { get; set; }
        public string District { get; set; }
        public string Commune_Ward { get; set; }
        public string House_Number { get; set; }

        public string Province1 { get; set; }
        public string District1 { get; set; }
        public string Commune_Ward1 { get; set; }
        public string House_Number1 { get; set; }

        public string Profession { get; set; }
        public string Agency { get; set; }
        public string Agency_Address { get; set; }

        public string Father_Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Father_Birthdate { get; set; }

        public string Mother_Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Mother_Birthdate { get; set; }

        public string Content { get; set; }
        public string Place_of_receiving_documents { get; set; }
    }
}