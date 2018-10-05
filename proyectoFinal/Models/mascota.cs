namespace proyectoFinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mascota")]
    public partial class mascota
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mascota()
        {
            cita = new HashSet<cita>();
        }

        [Key]
        public int codmascota { get; set; }

        public int? codpropietario { get; set; }

        public int? codtipo { get; set; }

        [StringLength(50)]
        [Required]
        [RegularExpression("^[a-zA-Z Ò—·ÈÌÛ˙¡…Õ”⁄]+?$", ErrorMessage = "Solo se permiten letras")]
        public string nombre { get; set; }

        [StringLength(5)]
        [Required]
        public string peso { get; set; }

        [StringLength(10)]
        [Required]
        public string sexo { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        public DateTime? fechanacimiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cita> cita { get; set; }

        public virtual Propietario_Mascota Propietario_Mascota { get; set; }

        public virtual tipo_mascota tipo_mascota { get; set; }
    }
}
