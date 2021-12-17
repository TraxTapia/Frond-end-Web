namespace TraxtWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ArchivoBase64
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }

        public byte[] doc { get; set; }

        public DateTime? fechaAlta { get; set; }

        public bool Activo { get; set; }
    }
}
