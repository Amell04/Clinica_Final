namespace proyectoFinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Medicamento")]
    public partial class Medicamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medicamento()
        {
            recetaDetalle = new HashSet<recetaDetalle>();
        }

        [Key]
        public int idMed { get; set; }

        [Column("Medicamento")]
        [StringLength(50)]
        [Required]
        public string Medicamento1 { get; set; }

        [Column(TypeName = "date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime? fechaVencimiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<recetaDetalle> recetaDetalle { get; set; }
    }
}
