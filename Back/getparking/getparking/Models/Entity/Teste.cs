using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace getparking.Models.Entity
{
    [Table("teste")]
    public class Teste
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Nome")]
        [StringLength(50)]
        [Required]
        public String Nome { get; set; }
    }
}