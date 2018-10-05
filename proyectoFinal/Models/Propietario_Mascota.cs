namespace proyectoFinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Propietario_Mascota
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Propietario_Mascota()
        {
            mascota = new HashSet<mascota>();
        }

        [Key]
        public int codpropietario { get; set; }

        [StringLength(50)]
        [Required]
        //[RegularExpression("^[a-zA-Z]+?$", ErrorMessage = "Solo se Permiten Letras")]
        [RegularExpression("^[a-zA-Z Ò—·ÈÌÛ˙¡…Õ”⁄]+?$", ErrorMessage = "Solo se Permiten Letras")]
        public string nombre { get; set; }

        [StringLength(50)]
        [Required]
        [RegularExpression("^[a-zA-Z Ò—·ÈÌÛ˙¡…Õ”⁄]+?$", ErrorMessage = "Solo se Permiten Letras")]
        public string apellido { get; set; }

        [StringLength(15)]
        [Required]
        [RegularExpression(@"^\(?([0-9]{8})\)?[-]([0-9]{1})$", ErrorMessage = "Introduzca un N˙mero V·lido")]
        public string dui { get; set; }

        [StringLength(10)]
        [Required]
        public string sexo { get; set; }

        [StringLength(100)]
        [Required]
        public string direccion { get; set; }

        [StringLength(15)]
        [Required]
        [RegularExpression(@"^\(?([0-9]{4})\)?[-]([0-9]{4})$", ErrorMessage = "Introduzca un N˙mero V·lido")]
        public string telefono { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mascota> mascota { get; set; }
    }
}
