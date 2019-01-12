using GetParking.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace getparking.Models.Entity
{
    [Table("Reserva")]
    public class Reserva
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdReserva")]
        public int Id { get; set; }

        [Column("Entrada", TypeName = "date")]
        public DateTime Entrada { get; set; }

        [Column("Saida", TypeName = "date")]
        public DateTime Saida { get; set; }
        
        [Column("Status")]
        [Required]
        public String Status { get; set; } //F - finalizado | E - Estacionado | A - Aguardando

        public int IdUsuarioFK { get; set; }
        [ForeignKey("IdUsuarioFK")]
        public virtual Usuario Usuario { get; set; }

        public int IdVagaFK { get; set; }
        [ForeignKey("IdVagaFK")]
        public virtual Vaga Vaga { get; set; }

    }
}