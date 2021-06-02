using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SynelProject.Models
{
    [Table("employees")]
    public class Employee
    {
        [Key]
        [Required]
        [Ignore]
        [Column("id")]
        public int ID { get; set; }

        /// <summary>
        /// todo: something
        /// </summary>
        [Name("Personnel_Records.Payroll_Number")]
        [MaxLength(20)]
        [Column("payrollnumber")]
        public string PayrollNumber { get; set; }

        /// <summary>
        /// todo: something
        /// </summary>
        [Name("Personnel_Records.Forenames")]
        [MaxLength(20)]
        [Column("forenames")]
        public string Forenames { get; set; }

        /// <summary>
        /// todo: something
        /// </summary>
        [Name("Personnel_Records.Surname")]
        [MaxLength(20)]
        [Column("surname")]
        public string Surname { get; set; }

        /// <summary>
        /// todo: something
        /// </summary>
        [Name("Personnel_Records.Date_of_Birth")]
        [MaxLength(20)]
        [Column("dateofbirth")]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// todo: something
        /// </summary>
        [Name("Personnel_Records.Telephone")]
        [MaxLength(20)]
        [Column("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// todo: something
        /// </summary>
        [Name("Personnel_Records.Mobile")]
        [MaxLength(20)]
        [Column("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// todo: something
        /// </summary>
        [Name("Personnel_Records.Address")]
        [MaxLength(20)]
        [Column("address")]
        public string Address { get; set; }

        /// <summary>
        /// todo: something
        /// </summary>
        [Name("Personnel_Records.Address_2")]
        [MaxLength(20)]
        [Column("address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// todo: something
        /// </summary>
        [Name("Personnel_Records.Postcode")]
        [MaxLength(20)]
        [Column("postcode")]
        public string Postcode { get; set; }

        /// <summary>
        /// todo: something
        /// </summary>
        [Name("Personnel_Records.EMail_Home")]
        [MaxLength(20)]
        [Column("email")]
        public string Email { get; set; }

        /// <summary>
        /// todo: something
        /// </summary>
        [Name("Personnel_Records.Start_Date")]
        [MaxLength(20)]
        [Column("startdate")]
        public string StartDate { get; set; }

    }
}
