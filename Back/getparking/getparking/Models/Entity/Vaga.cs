using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GetParking.Models
{
    [Table("Vaga")]
    public class Vaga
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdVaga")]
        public int Id { get; set; }

        [Column("Codigo")]
        [StringLength(10)]
        [Required]
        public String Codigo { get; set; }

        [Column("Status")]
        [StringLength(10)] //Livre - Ocupada
        [Required]
        public String Status { get; set; }

        [Column("Tipo")]
        [StringLength(10)] // Normal - CPD - Idoso
        public String Tipo { get; set; }

        public int IdQuarteiraoFK { get; set; }
        [ForeignKey("IdQuarteiraoFK")]
        public virtual Quarteirao Quarteirao { get; set; }
    }
}
