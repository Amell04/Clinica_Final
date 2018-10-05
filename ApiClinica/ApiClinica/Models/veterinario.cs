namespace ApiClinica.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("veterinario")]
    public partial class veterinario
    {
        [Key]
        public int codVeterinario { get; set; }

        [StringLength(100)]
        public string nombre { get; set; }

        [StringLength(100)]
        public string apellido { get; set; }

        [StringLength(10)]
        public string dui { get; set; }

        [StringLength(14)]
        public string telefono { get; set; }

        [StringLength(10)]
        public string sexo { get; set; }

        [StringLength(150)]
        public string direccion { get; set; }
    }
}
