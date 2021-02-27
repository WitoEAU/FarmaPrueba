using FarmaPrueba.BL;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FarmaPueba.BL
{
    public class ContextoP : DbContext
    {
        public ContextoP() : base(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDBFilename=" +
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop)  + @"\Farmaprueba.DB.mdf"  )
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();           
            }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

    }
}
