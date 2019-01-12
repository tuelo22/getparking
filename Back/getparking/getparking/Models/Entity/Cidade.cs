using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GetParking.Models
{
    [Table("Cidade")]
    public class Cidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdCidade")]
        public int Id { get; set; }

        [Column("Nome")]
        [StringLength(120)]
        [Required]
        public String Nome { get; set; }

        [Column("UF")]
        [StringLength(2)]
        [Required]
        public String UF { get; set; }
    }
}
