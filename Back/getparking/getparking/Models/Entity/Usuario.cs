using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GetParking.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdUsuario")]
        public int Id { get; set; }

        [Column("Nome")]
        [StringLength(120)]
        [Required]
        public String Nome { get; set; }

        [Column("TpDocumento")]
        [StringLength(4)]
        [Required]
        public String TpDocumento { get; set; }

        [Column("Documento")]
        [StringLength(14)]
        [Required]
        public String Documento { get; set; }

        [Column("Senha")]
        [StringLength(16)]
        [Required]
        public String Senha { get; set; }

        [Column("Telefone")]
        [StringLength(20)]
        [Required]
        public String Telefone { get; set; }

        [Column("Email")]
        [StringLength(120)]
        [Required]
        public String Email { get; set; }
    }
}
