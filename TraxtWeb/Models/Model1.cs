using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TraxtWeb.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=DbContext")
        {
        }

        public virtual DbSet<ArchivoBase64> ArchivoBase64 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArchivoBase64>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<ArchivoBase64>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);
        }
    }
}
