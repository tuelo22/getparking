using GetParking.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace getparking.Models.Entity
{
    [Table("Pagamento")]
    public class Pagamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdPagamento")]
        public int Id { get; set; }
               
        [Column("ValorPagar", TypeName = "double")]
        public double ValorPagar { get; set; }

        [Column("Data", TypeName = "date")]
        public DateTime Data { get; set; }

        public int IdUsuarioFK { get; set; }
        [ForeignKey("IdUsuarioFK")]
        public virtual Usuario Usuario { get; set; }

        public int IdVagaFK { get; set; }
        [ForeignKey("IdVagaFK")]
        public virtual Vaga Vaga { get; set; }
    }
}