using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GetParking.Models
{
    [Table("Rua")]
    public class Rua
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdRua")]
        public int Id { get; set; }

        [Column("Nome")]
        public String Nome { get; set; }

        public int IdBairroFK { get; set; }
        [ForeignKey("IdBairroFK")]
        public virtual Bairro Bairro { get; set; }
    }
}
