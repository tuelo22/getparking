using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GetParking.Models
{
    [Table("Bairro")]
    public class Bairro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdBairro")]
        public int Id { get; set; }

        [Column("Nome")]
        public String Nome { get; set; }

        public int IdCidadeFK { get; set; }
        [ForeignKey("IdCidadeFK")]
        public virtual Cidade Cidade { get; set; }
    }
}
