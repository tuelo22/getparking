using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GetParking.Models
{
    [Table("Veiculo")]
    public class Veiculo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdVeiculos")]
        public int Id { get; set; }

        [Column("Placa")]
        [StringLength(50)]
        [Required]
        public String Placa { get; set; }

        [Column("Marca")]
        [StringLength(10)]
        [Required]
        public String Marca { get; set; }

        [Column("Cor")]
        [StringLength(50)]
        [Required]
        public String Cor { get; set; }

        [Column("Tipo")]
        [StringLength(10)]
        public String Tipo { get; set; }

        public int IdUsuarioFK { get; set; }
        [ForeignKey("IdUsuarioFK")]
        public virtual Usuario Usuario { get; set; }
    }
}
