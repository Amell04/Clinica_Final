namespace proyectoFinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("recetaDetalle")]
    public partial class recetaDetalle
    {
        [Key]
        public int idreceta { get; set; }

        public int? idMed { get; set; }

        public int? idConsulta { get; set; }

        [StringLength(50)]
        [Required]
        public string dosis { get; set; }

        public int? cantidad { get; set; }

        public virtual consulta consulta { get; set; }

        public virtual Medicamento Medicamento { get; set; }
    }
}
