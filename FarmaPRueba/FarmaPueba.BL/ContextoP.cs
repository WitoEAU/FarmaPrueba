using FarmaPrueba.BL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

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

    }
}
