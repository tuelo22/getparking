using GetParking.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace getparking.Models.Entity
{
    [Table("Denuncia")]
    public class Denuncia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdDenuncia")]
        public int Id { get; set; }

        [Column("Descricao")]
        [StringLength(250)]
        [Required]
        public String Descricao { get; set; }

        [Column("Data", TypeName = "date")]
        public DateTime Data { get; set; }

        [Column("Imagem", TypeName = "Blob")]
        public byte[] Imagem { get; set; }

        public int IdInfratorFK { get; set; }
        [ForeignKey("IdInfratorFK")]
        public virtual Usuario Infrator { get; set; }

        public int IdRelatorFK { get; set; }
        [ForeignKey("IdRelatorFK")]
        public virtual Usuario Relator { get; set; }

        public int IdVeiculoFK { get; set; }
        [ForeignKey("IdVeiculoFK")]
        public virtual Veiculo Veiculo { get; set; }

        public int IdVagaFK { get; set; }
        [ForeignKey("IdVagaFK")]
        public virtual Vaga Vaga { get; set; }

        [Column("PlacaInfrator")]
        [StringLength(10)]
        public String PlacaInfrator { get; set; }
    }
}