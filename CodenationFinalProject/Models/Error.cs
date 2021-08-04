using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CodenationFinalProject.Repository;

namespace CodenationFinalProject.Models
{
    public class Error : IEntity
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("error_name")]
        [StringLength(50)]
        [Required]
        public string ErrorName { get; set; }

        [Column("description")]
        [StringLength(200)]
        [Required]
        public string Description { get; set; }

        [Column("severity")]
        [Required]
        public int Severity { get; set; }


        public List<Logs> Logs;

    }
}
