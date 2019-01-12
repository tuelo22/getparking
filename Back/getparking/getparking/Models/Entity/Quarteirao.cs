using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GetParking.Models
{
    /// <summary>
    ///  Quarteirão é o bloco de vagas ou seja o a "rua"
    /// </summary>
    [Table("Quarteirao")]
    public class Quarteirao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdQuarteirao")]
        public int Id { get; set;}

        [Column("Latitude")]
        public Double Latitude { get; set; }

        [Column("Longitude")]
        public Double Longitude { get; set; }

        public int IdRuaFK { get; set; }
        [ForeignKey("IdRuaFK")]
        public virtual Rua Rua { get; set; }
    }
}