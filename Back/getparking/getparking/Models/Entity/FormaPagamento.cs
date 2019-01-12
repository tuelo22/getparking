using GetParking.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace getparking.Models.Entity
{
    [Table("FormaPagamento")]
    public class FormaPagamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdFormaPagamento")]
        public int IdFormaPagamento { get; set; }

        [Column("Principal")]
        [StringLength(1)]
        [Required]
        public String Principal { get; set; } //S - Sim | N - Não

        [Column("Tipo")]
        [StringLength(10)]
        [Required]
        public String Tipo { get; set; } //Cartão | Dinheiro
        
        [Column("NumeroCartao")]
        [StringLength(16)]
        public String NumeroCartao { get; set; }

        [Column("Titular")]
        [StringLength(60)]
        public String Titular { get; set; }        

        [Column("MesAnoValidade")]
        [StringLength(6)]
        public String MesAnoValidade { get; set; }

        [Column("CVV")]
        [StringLength(3)]
        public String CVV { get; set; }

        public int IdUsuarioFK { get; set; }
        [ForeignKey("IdUsuarioFK")]
        public virtual Usuario Usuario { get; set; }
    }
}