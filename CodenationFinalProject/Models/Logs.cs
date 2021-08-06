using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CodenationFinalProject.Repository;

namespace CodenationFinalProject.Models
{
    [Table("logs")]
    // os models precisam herdar de IEntity para gsarantir que a propriedade ID seja implementada
    public class Logs : IEntity
    {
        [Key]
        [Column("id"), Required]
        public int Id { get; set; }

        [Column("user_id"), Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public Users Users { get; set; }

        [Column("error_id"), Required]
        public int ErrorId { get; set; }

        [ForeignKey("ErrorId")]
        public Error Error { get; set; }


        public DateTime CreatedDate { get; set; }

        public Logs()
        {
            this.CreatedDate = DateTime.UtcNow;
        }

    }
}
